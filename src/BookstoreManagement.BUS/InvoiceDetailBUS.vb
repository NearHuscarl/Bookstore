Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class InvoiceDetailBUS
	Private invoiceDetailDAL As InvoiceDetailDAL
	Private invoiceBUS As InvoiceBUS
	Private customerBUS As CustomerBUS
	Private parameterBUS As ParameterBUS
	Private bookBUS As BookBUS

	Public Sub New()
		invoiceDetailDAL = New InvoiceDetailDAL()
		invoiceBUS = New InvoiceBUS()
		customerBUS = New CustomerBUS()
		parameterBUS = New ParameterBUS()
		bookBUS = New BookBUS()
	End Sub

	Public Sub New(connectionStr As String)
		invoiceDetailDAL = New InvoiceDetailDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As String) As Result
		Return invoiceDetailDAL.getNextId(nextId)
	End Function

	Private Function Validate(invoiceDetail As InvoiceDetailDTO) As Result
		If (invoiceDetail.BookID Is Nothing) Then
			Return New Result(False, $"Book ID of {invoiceDetail.ID} is missing", "")
		End If

		If (invoiceDetail.Amount < 0) Then
			Return New Result(False, $"Amount of {invoiceDetail.ID} is out of range", "")
		End If

		If (invoiceDetail.SalesPrice < 0) Then
			Return New Result(False, $"SalesPrice of {invoiceDetail.ID} is out of range", "")
		End If

		Return New Result(True)
	End Function

	Private Function IsValidToAdd(invoiceDetail As InvoiceDetailDTO) As Result
		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)

		If result.FlagResult = False Then
			Return result
		End If

		result = Validate(invoiceDetail)
		If (result.FlagResult = False) Then
			Return result
		End If

		Dim book As BookDTO
		result = bookBUS.select_ByID(invoiceDetail.BookID, book)

		If (result.FlagResult = True) Then
			If (book.Stock - invoiceDetail.Amount < parameter.MinStockAfterSales) Then
				Return New Result(False, $"Stock after sales of {book.ID} is smaller than minimum allowed ({book.Stock} - {invoiceDetail.Amount} < {parameter.MinStockAfterSales})", "")
			End If
		Else
			Return New Result(False, $"Cannot load book when validating invoice detail", "")
		End If

		Return result
	End Function

	Private Function IsValidToUpdate(oldInvoiceDetail As InvoiceDetailDTO, newInvoiceDetail As InvoiceDetailDTO) As Result
		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)

		If result.FlagResult = False Then
			Return result
		End If

		result = Validate(newInvoiceDetail)
		If (result.FlagResult = False) Then
			Return result
		End If

		If (oldInvoiceDetail.BookID <> newInvoiceDetail.BookID) Then
			Return IsValidToAdd(newInvoiceDetail)
		End If

		Dim book As BookDTO
		result = bookBUS.select_ByID(oldInvoiceDetail.BookID, book)

		If (result.FlagResult = True) Then
			If (book.Stock + newInvoiceDetail.Amount - oldInvoiceDetail.Amount < parameter.MinStockAfterSales) Then
				Return New Result(False, $"Stock after sales of {book.ID} is smaller than minimum allowed ({book.Stock} - {newInvoiceDetail.Amount - oldInvoiceDetail.Amount} < {parameter.MinStockAfterSales})", "")
			End If
		Else
			Return New Result(False, $"Cannot load book when validating invoice detail", "")
		End If

		Return result
	End Function

	Public Function insert(invoiceDetail As InvoiceDetailDTO) As Result
		Return invoiceDetailDAL.insert(invoiceDetail)
	End Function

	Public Function insertAll(invoiceDetails As List(Of InvoiceDetailDTO)) As Result
		Dim oldBooks As List(Of BookDTO) = New List(Of BookDTO)
		Dim oldCustomers As List(Of CustomerDTO) = New List(Of CustomerDTO)
		Dim result As Result

		For Each invoiceDetail As InvoiceDetailDTO In invoiceDetails
			result = IsValidToAdd(invoiceDetail)

			If (result.FlagResult = False) Then
				Return result
			End If

			Dim book As BookDTO
			result = bookBUS.select_ByID(invoiceDetail.BookID, book)

			If (result.FlagResult = True) Then
				oldBooks.AddIfNotExist(book, BookComparer.Instance)

				book.Stock -= invoiceDetail.Amount
				bookBUS.update(book)
			Else
				' Reverse changes in books
				For Each b As BookDTO In oldBooks
					bookBUS.update(b)
				Next
				Return New Result(False, $"Cannot load book for invoice detail {invoiceDetail.ID}", "")
			End If

			Dim invoice As InvoiceDTO
			result = invoiceBUS.select_ByID(invoiceDetail.InvoiceID, invoice)

			If (result.FlagResult = False) Then
				Return New Result(False, $"Cannot load invoice {invoiceDetail.ID}", "")
			End If

			Dim customer As CustomerDTO
			result = customerBUS.select_ByID(invoice.CustomerID, customer)

			If (result.FlagResult = True) Then
				oldCustomers.AddIfNotExist(customer, CustomerComparer.Instance)

				customer.CurrentDebt += invoiceDetail.SalesPrice * invoiceDetail.Amount
				customerBUS.update(customer)
			Else
				For Each c As CustomerDTO In oldCustomers
					customerBUS.update(c)
				Next
				Return New Result(False, $"Cannot load customer for invoice detail {invoiceDetail.ID}", "")
			End If
		Next

		Return invoiceDetailDAL.insertAll(invoiceDetails)
	End Function

	Public Function selectAll(ByRef invoiceDetails As List(Of InvoiceDetailDTO)) As Result
		Return invoiceDetailDAL.selectAll(invoiceDetails)
	End Function

	Public Function selectAll_ByInvoice(invoiceID As String, ByRef invoiceDetails As List(Of InvoiceDetailDTO)) As Result
		Return invoiceDetailDAL.selectAll_ByInvoice(invoiceID, invoiceDetails)
	End Function

	Public Function selectAll_ByBook(bookID As String, ByRef invoiceDetails As List(Of InvoiceDetailDTO)) As Result
		Return invoiceDetailDAL.selectAll_ByBook(bookID, invoiceDetails)
	End Function

	Public Function update(newinvoiceDetail As InvoiceDetailDTO) As Result
		Dim result As Result

		Dim oldInvoiceDetail As InvoiceDetailDTO
		result = invoiceDetailDAL.select_ByID(newinvoiceDetail.ID, oldInvoiceDetail)

		If (result.FlagResult = False) Then
			Return New Result(False, $"Cannot get invoice detail {newinvoiceDetail.ID}", "")
		End If

		result = IsValidToUpdate(oldInvoiceDetail, newinvoiceDetail)

		If (result.FlagResult = False) Then
			Return result
		End If

		Dim book As BookDTO
		result = bookBUS.select_ByID(newinvoiceDetail.BookID, book)

		If (result.FlagResult = True) Then ' TODO: update stock when bookID changed too
			book.Stock += (newinvoiceDetail.Amount - oldInvoiceDetail.Amount)
			bookBUS.update(book)
		Else
			Return New Result(False, $"Cannot get book for invoice detail {newinvoiceDetail.ID}", "")
		End If

		Dim invoice As InvoiceDTO
		result = invoiceBUS.select_ByID(newinvoiceDetail.InvoiceID, invoice)

		If (result.FlagResult = False) Then
			Return New Result(False, $"Cannot load invoice {newinvoiceDetail.ID}", "")
		End If

		Dim customer As CustomerDTO
		result = customerBUS.select_ByID(invoice.CustomerID, customer)

		If (result.FlagResult = True) Then
			customer.CurrentDebt += (newinvoiceDetail.SalesPrice * newinvoiceDetail.Amount) - (oldInvoiceDetail.SalesPrice * oldInvoiceDetail.Amount)
			customerBUS.update(customer)
		Else
			Return New Result(False, $"Cannot load customer for invoice detail {newinvoiceDetail.ID}", "")
		End If

		Return invoiceDetailDAL.update(newinvoiceDetail)
	End Function

	Public Function select_ByID(invoiceDetailID As String, ByRef invoiceDetail As InvoiceDetailDTO) As Result
		Return invoiceDetailDAL.select_ByID(invoiceDetailID, invoiceDetail)
	End Function

	Public Function delete(invoiceDetailID As String) As Result
		Return invoiceDetailDAL.delete(invoiceDetailID)
	End Function
End Class

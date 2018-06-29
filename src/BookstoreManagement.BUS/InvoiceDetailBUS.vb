Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class InvoiceDetailBUS
	Private invoiceDetailDAL As InvoiceDetailDAL
	Private parameterBUS As ParameterBUS
	Private bookBUS As BookBUS

	Public Sub New()
		invoiceDetailDAL = New InvoiceDetailDAL()
		parameterBUS = New ParameterBUS()
		bookBUS = New BookBUS()
	End Sub

	Public Sub New(connectionStr As String)
		invoiceDetailDAL = New InvoiceDetailDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As String) As Result
		Return invoiceDetailDAL.getNextId(nextId)
	End Function

	Private Function IsValidToAdd(invoiceDetail As InvoiceDetailDTO) As Result
		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)
		Dim book As BookDTO

		If result.FlagResult = True Then
			If (invoiceDetail.BookID Is Nothing) Then
				Return New Result(False, $"Book ID of {invoiceDetail.ID} is missing", "")
			End If

			result = bookBUS.select_ByID(invoiceDetail.BookID, book)

			If (result.FlagResult = True) Then
				If (book.Stock - invoiceDetail.Amount < parameter.MinStockAfterSales) Then
					Return New Result(False, $"Stock after sales of {book.ID} is smaller than minimum allowed ({book.Stock} - {invoiceDetail.Amount} < {parameter.MinStockAfterSales})", "")
				End If
			Else
				Return New Result(False, $"Cannot load book when validating invoice detail", "")
			End If
		End If
		Return result
	End Function

	Private Function IsValidToUpdate(invoiceDetail As InvoiceDetailDTO) As Result
		Return IsValidToAdd(invoiceDetail)
	End Function

	Public Function insert(invoiceDetail As InvoiceDetailDTO) As Result
		Return invoiceDetailDAL.insert(invoiceDetail)
	End Function

	Public Function insertAll(invoiceDetails As List(Of InvoiceDetailDTO)) As Result
		Dim result As Result

		For Each invoiceDetail As InvoiceDetailDTO In invoiceDetails
			result = IsValidToAdd(invoiceDetail)

			If (result.FlagResult = True) Then
				Dim book As BookDTO

				result = bookBUS.select_ByID(invoiceDetail.BookID, book)

				If (result.FlagResult = True) Then
					book.Stock -= invoiceDetail.Amount
					bookBUS.update(book)
				Else
					Return New Result(False, $"Cannot get book for invoice detail ${invoiceDetail.ID}", "")
				End If
			Else
				Return result
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

		result = IsValidToUpdate(newinvoiceDetail)

		If (result.FlagResult = True) Then
			Dim oldInvoiceDetail As InvoiceDetailDTO
			result = invoiceDetailDAL.select_ByID(newinvoiceDetail.ID, oldInvoiceDetail)

			If (result.FlagResult = True) Then
				Dim book As BookDTO

				result = bookBUS.select_ByID(newinvoiceDetail.BookID, book)

				If (result.FlagResult = True) Then ' TODO: update stock when bookID changed too
					book.Stock += (newinvoiceDetail.Amount - oldInvoiceDetail.Amount)
					bookBUS.update(book)
				Else
					Return New Result(False, $"Cannot get book for invoice detail ${newinvoiceDetail.ID}", "")
				End If
			Else
				Return New Result(False, $"Cannot get invoice detail ${newinvoiceDetail.ID}", "")
			End If
		Else
			Return result
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

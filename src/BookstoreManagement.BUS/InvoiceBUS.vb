Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class InvoiceBUS
	Private invoiceDAL As InvoiceDAL
	Private parameterBUS As ParameterBUS
	Private customerBUS As CustomerBUS

	Public Sub New()
		invoiceDAL = New InvoiceDAL()
		parameterBUS = New ParameterBUS()
		customerBUS = New CustomerBUS()
	End Sub

	Public Sub New(connectionStr As String)
		invoiceDAL = New InvoiceDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As String) As Result
		Return invoiceDAL.getNextId(nextId)
	End Function

	Private Function IsValidInvoice(invoice As InvoiceDTO) As Result
		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)
		Dim customer As CustomerDTO

		If result.FlagResult = True Then
			If (invoice.CustomerID = Nothing) Then
				Return New Result(False, $"Customer ID of invoice {invoice.ID} is missing", "")
			End If

			If (invoice.InvoiceDate = Nothing) Then
				Return New Result(False, $"Date of invoice {invoice.ID} is missing", "")
			End If

			result = customerBUS.select_ByID(invoice.CustomerID, customer)

			If (result.FlagResult = True) Then
				If (customer.CurrentDebt > parameter.MaxDebt) Then
					Return New Result(False, $"Customer {customer.ID}'s current debt is larger than the maximum allowed ({customer.CurrentDebt} > {parameter.MaxDebt})", "")
				End If
			Else
				Return New Result(False, $"Cannot load customer when validating invoice", "")
			End If
		End If
		Return result
	End Function

	Public Function insert(invoice As InvoiceDTO) As Result
		Dim result As Result

		result = IsValidInvoice(invoice)

		If (result.FlagResult = False) Then
			Return result
		End If

		Return invoiceDAL.insert(invoice)
	End Function

	Public Function select_ByID(invoiceID As String, ByRef invoice As InvoiceDTO) As Result
		Return invoiceDAL.select_ByID(invoiceID, invoice)
	End Function

	Public Function selectAll(ByRef invoices As List(Of InvoiceDTO)) As Result
		Return invoiceDAL.selectAll(invoices)
	End Function

	Public Function selectAll_ByDate(InvoiceDate As DateTime, ByRef invoices As List(Of InvoiceDTO)) As Result
		Return invoiceDAL.selectAll_ByDate(InvoiceDate, invoices)
	End Function
	Public Function selectAll_ByCustomer(customerID As String, ByRef invoices As List(Of InvoiceDTO)) As Result
		Return invoiceDAL.selectAll_ByCustomer(customerID, invoices)
	End Function

	Public Function update(invoice As InvoiceDTO) As Result
		Return invoiceDAL.update(invoice)
	End Function

	Public Function delete(invoiceID As String) As Result
		Return invoiceDAL.delete(invoiceID)
	End Function
End Class

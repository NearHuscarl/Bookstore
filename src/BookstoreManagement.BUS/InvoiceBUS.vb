Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class InvoiceBUS
	Private invoiceDAL As InvoiceDAL

	Public Sub New()
		invoiceDAL = New InvoiceDAL()
	End Sub

	Public Sub New(connectionStr As String)
		invoiceDAL = New InvoiceDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return invoiceDAL.getNextId(nextId)
	End Function

	Public Function insert(invoice As InvoiceDTO) As Result
		Return invoiceDAL.insert(invoice)
	End Function

	Public Function sellectALL(ByRef invoices As List(Of InvoiceDTO)) As Result
		Return invoiceDAL.sellectALL(invoices)
	End Function

	Public Function sellectALL_ByDate(dateCreated As DateTime, ByRef invoices As List(Of InvoiceDTO)) As Result
		Return invoiceDAL.sellectALL_ByDate(dateCreated, invoices)
	End Function
	Public Function sellectALL_ByCustomer(customerID As String, ByRef invoices As List(Of InvoiceDTO)) As Result
		Return invoiceDAL.sellectALL_ByCustomer(customerID, invoices)
	End Function

	Public Function update(invoice As InvoiceDTO) As Result
		Return invoiceDAL.update(invoice)
	End Function

	Public Function delete(invoiceID As String) As Result
		Return invoiceDAL.delete(invoiceID)
	End Function
End Class

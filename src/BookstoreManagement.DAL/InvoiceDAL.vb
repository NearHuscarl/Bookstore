Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class InvoiceDAL
   Private connectionStr As String

   Public Sub New()
      connectionStr = ConfigurationManager.AppSettings("ConnectionStr")
   End Sub

   Public Sub New(connectionStr As String)
      Me.connectionStr = connectionStr
   End Sub

   Public Function getNextId(ByRef nextId As Integer) As Result
      Return New Result(True)
   End Function

   Public Function insert(reader As InvoiceDTO) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL(ByRef listInvoice As List(Of InvoiceDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL_ByDate(dateCreate As DateTime, ByRef listInvoice As List(Of InvoiceDTO)) As Result
      Return New Result(True)
   End Function
   Public Function sellectALL_ByCustomer(customerID As String, ByRef listInvoice As List(Of InvoiceDTO)) As Result
      Return New Result(True)
   End Function

   Public Function update(invoice As InvoiceDTO) As Result
      Return New Result(True)
   End Function

   Public Function delete(invoiceID As String) As Result
      Return New Result(True)
   End Function

End Class

Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class InvoiceDetailDAL
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

   Public Function insert(reader As InvoiceDetailDTO) As Result
      Return New Result(True)
   End Function

   Public Function insertAll(invoiceDetailDTOs As List(Of InvoiceDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL(ByRef listInvoiceDetail As List(Of InvoiceDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL_ByInvoice(invoiceID As String, ByRef listInvoiceDetail As List(Of InvoiceDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL_ByBook(bookID As String, ByRef listInvoiceDetail As List(Of InvoiceDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function update(invoiceDetail As InvoiceDetailDTO) As Result
      Return New Result(True)
   End Function

   Public Function delete(invoiceDetailID As String) As Result
      Return New Result(True)
   End Function
End Class

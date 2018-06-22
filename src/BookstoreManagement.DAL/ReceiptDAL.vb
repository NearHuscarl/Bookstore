Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class ReceiptDAL
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

   Public Function insert(reader As ReceiptDTO) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL(ByRef listReceipt As List(Of ReceiptDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL_ByDate(dateCollect As DateTime, ByRef listReceipt As List(Of ReceiptDTO)) As Result
      Return New Result(True)
   End Function
   Public Function sellectALL_ByCustomer(customerID As String, ByRef listReceipt As List(Of ReceiptDTO)) As Result
      Return New Result(True)
   End Function

   Public Function update(Receipt As ReceiptDTO) As Result
      Return New Result(True)
   End Function

   Public Function delete(ReceiptID As String) As Result
      Return New Result(True)
   End Function
End Class

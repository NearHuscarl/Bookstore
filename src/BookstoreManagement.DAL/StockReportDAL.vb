Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class StockReportDAL
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

   Public Function insert(reader As StockReportDTO) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL(ByRef listStockReport As List(Of StockReportDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL_ByDate(dateReport As DateTime, ByRef listStockReport As List(Of StockReportDTO)) As Result
      Return New Result(True)
   End Function

   Public Function update(stockReport As StockReportDTO) As Result
      Return New Result(True)
   End Function

   Public Function delete(stockReportID As String) As Result
      Return New Result(True)
   End Function

End Class

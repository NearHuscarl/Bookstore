Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class StockReportDetailDAL
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

   Public Function insert(reader As StockReportDetailDTO) As Result
      Return New Result(True)
   End Function

   Public Function insertAll(stockReportDetailDTOs As List(Of StockReportDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL(ByRef listStockReportDetail As List(Of StockReportDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL_ByStockReport(stockReportID As String, ByRef listStockReportDetail As List(Of StockReportDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL_ByBook(bookID As String, ByRef listStockReportDetail As List(Of StockReportDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function update(stockReportDetail As StockReportDetailDTO) As Result
      Return New Result(True)
   End Function

   Public Function delete(stockReportDetailID As String) As Result
      Return New Result(True)
   End Function
End Class
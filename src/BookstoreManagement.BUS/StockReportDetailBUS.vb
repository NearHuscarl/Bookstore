Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class StockReportDetailBUS
	Private stockReportDetailDAL As StockReportDetailDAL

	Public Sub New()
		stockReportDetailDAL = New StockReportDetailDAL()
	End Sub

	Public Sub New(connectionStr As String)
		stockReportDetailDAL = New StockReportDetailDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return stockReportDetailDAL.getNextId(nextId)
	End Function

	Public Function insert(stockReportDetail As StockReportDetailDTO) As Result
		Return stockReportDetailDAL.insert(stockReportDetail)
	End Function

	Public Function insertAll(stockReportDetails As List(Of StockReportDetailDTO)) As Result
		Return stockReportDetailDAL.insertAll(stockReportDetails)
	End Function

	Public Function select_ByID(stockReportDetailID As String, ByRef stockReportDetail As StockReportDetailDTO) As Result
		Return stockReportDetailDAL.select_ByID(stockReportDetailID, stockReportDetail)
	End Function

	Public Function selectAll(ByRef stockReportDetails As List(Of StockReportDetailDTO)) As Result
		Return stockReportDetailDAL.selectAll(stockReportDetails)
	End Function

	Public Function selectAll_ByStockReport(stockReportID As String, ByRef stockReportDetails As List(Of StockReportDetailDTO)) As Result
		Return stockReportDetailDAL.selectAll_ByStockReport(stockReportID, stockReportDetails)
	End Function

	Public Function selectAll_ByBook(bookID As String, ByRef stockReportDetails As List(Of StockReportDetailDTO)) As Result
		Return stockReportDetailDAL.selectAll_ByBook(bookID, stockReportDetails)
	End Function

	Public Function update(stockReportDetail As StockReportDetailDTO) As Result
		Return stockReportDetailDAL.update(stockReportDetail)
	End Function

	Public Function delete(stockReportDetailID As String) As Result
		Return stockReportDetailDAL.delete(stockReportDetailID)
	End Function
End Class

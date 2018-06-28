Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class StockReportBUS
	Private stockReportDAL As StockReportDAL

	Public Sub New()
		stockReportDAL = New StockReportDAL()
	End Sub

	Public Sub New(connectionStr As String)
		stockReportDAL = New StockReportDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return stockReportDAL.getNextId(nextId)
	End Function

	Public Function insert(stockReport As StockReportDTO) As Result
		Return stockReportDAL.insert(stockReport)
	End Function

	Public Function selectAll(ByRef stockReports As List(Of StockReportDTO)) As Result
		Return stockReportDAL.selectAll(stockReports)
	End Function

	Public Function selectAll_ByDate(dateReported As DateTime, ByRef stockReports As List(Of StockReportDTO)) As Result
		Return stockReportDAL.selectAll_ByDate(dateReported, stockReports)
	End Function

	Public Function update(stockReport As StockReportDTO) As Result
		Return stockReportDAL.update(stockReport)
	End Function

	Public Function delete(stockReportID As String) As Result
		Return stockReportDAL.delete(stockReportID)
	End Function
End Class

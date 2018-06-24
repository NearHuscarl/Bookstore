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
		Return getNextId(nextId)
	End Function

	Public Function insert(stockReport As StockReportDTO) As Result
		Return insert(stockReport)
	End Function

	Public Function sellectALL(ByRef stockReports As List(Of StockReportDTO)) As Result
		Return sellectALL(stockReports)
	End Function

	Public Function sellectALL_ByDate(dateReported As DateTime, ByRef stockReports As List(Of StockReportDTO)) As Result
		Return sellectALL_ByDate(dateReported, stockReports)
	End Function

	Public Function update(stockReport As StockReportDTO) As Result
		Return update(stockReport)
	End Function

	Public Function delete(stockReportID As String) As Result
		Return delete(stockReportID)
	End Function
End Class

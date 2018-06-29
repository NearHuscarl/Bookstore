Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class DebtReportBUS
	Private debtReportDAL As DebtReportDAL

	Public Sub New()
		debtReportDAL = New DebtReportDAL()
	End Sub

	Public Sub New(connectionStr As String)
		debtReportDAL = New DebtReportDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return debtReportDAL.getNextId(nextId)
	End Function

	Public Function insert(debtReport As DebtReportDTO) As Result
		Return debtReportDAL.insert(debtReport)
	End Function

	Public Function select_ByID(debtReportID As String, ByRef debtReport As DebtReportDTO) As Result
		Return debtReportDAL.select_ByID(debtReportID, debtReport)
	End Function

	Public Function selectAll(ByRef debtReports As List(Of DebtReportDTO)) As Result
		Return debtReportDAL.selectAll(debtReports)
	End Function

	Public Function selectAll_ByDate(dateReport As DateTime, ByRef debtReports As List(Of DebtReportDTO)) As Result
		Return debtReportDAL.selectAll_ByDate(dateReport, debtReports)
	End Function

	Public Function update(debtReport As DebtReportDTO) As Result
		Return debtReportDAL.update(debtReport)
	End Function

	Public Function delete(debtReportID As String) As Result
		Return debtReportDAL.delete(debtReportID)
	End Function
End Class

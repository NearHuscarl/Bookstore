Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class DebtReportDetailBUS
	Private debtReportDetailDAL As DebtReportDetailDAL

	Public Sub New()
		debtReportDetailDAL = New DebtReportDetailDAL()
	End Sub

	Public Sub New(connectionStr As String)
		debtReportDetailDAL = New DebtReportDetailDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return debtReportDetailDAL.getNextId(nextId)
	End Function

	Public Function insert(debtReportDetail As DebtReportDetailDTO) As Result
		Return debtReportDetailDAL.insert(debtReportDetail)
	End Function

	Public Function insertAll(debtReportDetails As List(Of DebtReportDetailDTO)) As Result
		Return debtReportDetailDAL.insertAll(debtReportDetails)
	End Function

	Public Function select_ByID(debtReportDetailID As String, ByRef debtReportDetail As DebtReportDetailDTO) As Result
		Return debtReportDetailDAL.select_ByID(debtReportDetailID, debtReportDetail)
	End Function

	Public Function selectAll(ByRef debtReportDetails As List(Of DebtReportDetailDTO)) As Result
		Return debtReportDetailDAL.selectAll(debtReportDetails)
	End Function

	Public Function selectAll_ByDebtReport(debtReportID As String, ByRef debtReportDetails As List(Of DebtReportDetailDTO)) As Result
		Return debtReportDetailDAL.selectAll_ByDebtReport(debtReportID, debtReportDetails)
	End Function

	Public Function selectAll_ByCustomer(customerID As String, ByRef debtReportDetails As List(Of DebtReportDetailDTO)) As Result
		Return debtReportDetailDAL.selectAll_ByCustomer(customerID, debtReportDetails)
	End Function

	Public Function update(debtReportDetail As DebtReportDetailDTO) As Result
		Return debtReportDetailDAL.update(debtReportDetail)
	End Function

	Public Function delete(debtReportDetailID As String) As Result
		Return debtReportDetailDAL.delete(debtReportDetailID)
	End Function
End Class

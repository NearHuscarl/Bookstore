Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class DebtReportDetailDAL
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

   Public Function insert(reader As DebtReportDetailDTO) As Result
      Return New Result(True)
   End Function

   Public Function insertAll(debtReportDetailDTOs As List(Of DebtReportDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL(ByRef listDebtReportDetail As List(Of DebtReportDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL_ByDebtReport(debtReportID As String, ByRef listDebtReportDetail As List(Of DebtReportDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL_ByCustomer(customerID As String, ByRef listDebtReportDetail As List(Of DebtReportDetailDTO)) As Result
      Return New Result(True)
   End Function

   Public Function update(debtReportDetail As DebtReportDetailDTO) As Result
      Return New Result(True)
   End Function

   Public Function delete(debtReportDetailID As String) As Result
      Return New Result(True)
   End Function
End Class

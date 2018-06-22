Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class DebtReportDAL
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

   Public Function insert(reader As DebtReportDTO) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL(ByRef listDebtReport As List(Of DebtReportDTO)) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL_ByDate(dateReport As DateTime, ByRef listDebtReport As List(Of DebtReportDTO)) As Result
      Return New Result(True)
   End Function

   Public Function update(debtReport As DebtReportDTO) As Result
      Return New Result(True)
   End Function

   Public Function delete(debtReportID As String) As Result
      Return New Result(True)
   End Function

End Class

Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class ImportBUS
	Private importDAL As ImportDAL
	Private parameterBUS As ParameterBUS

	Public Sub New()
		importDAL = New ImportDAL()
		parameterBUS = New ParameterBUS()
	End Sub

	Public Sub New(connectionStr As String)
		importDAL = New ImportDAL(connectionStr)
		parameterBUS = New ParameterBUS()
	End Sub

	Public Function insert(importInfo As ImportDTO) As Result
		' Validate here
		Return importDAL.insert(importInfo)
	End Function

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return importDAL.getNextId(nextId)
	End Function
End Class

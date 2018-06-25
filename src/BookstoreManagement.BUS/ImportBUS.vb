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

	Public Function update(import As ImportDTO) As Result
		Return importDAL.update(import)
	End Function

	Public Function delete(import As String) As Result
		Return importDAL.delete(import)
	End Function
End Class

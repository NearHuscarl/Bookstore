Imports System.Text.RegularExpressions
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

	Public Function getNextId(ByRef nextId As String) As Result
		Return importDAL.getNextId(nextId)
	End Function

	Public Function selectAll(ByRef _imports As List(Of ImportDTO)) As Result
		Dim result = importDAL.selectAll(_imports)

		If (result.FlagResult = True) Then
			For Each _import As ImportDTO In _imports
				_import.ImportDate = _import.ImportDate.ToShortDateString()
			Next
		End If

		Return result
	End Function

	Public Function insert(import As ImportDTO) As Result
		' Validate here
		Return importDAL.insert(import)
	End Function

	Public Function update(import As ImportDTO) As Result
		Return importDAL.update(import)
	End Function

	Public Function delete(importID As String) As Result
		Return importDAL.delete(importID)
	End Function
End Class

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
		Dim latestId As String = "IMPORT002"
		Dim result As New Result(True)

		'TODO: Remove to use getLatestId()
		'result = importDAL.getLatestId(latestId)
		If (result.FlagResult = True) Then
			Dim IdPrefix As String = Regex.Replace(latestId, "[\d]", "")
			Dim IdNumber As Integer = Regex.Replace(latestId, "[^\d]", "")

			IdNumber += 1

			nextId = IdPrefix + (IdNumber).ToString("D3")
		Else
			nextId = Nothing
		End If

		Return result
	End Function

	Public Function selectALL(ByRef _imports As List(Of ImportDTO)) As Result
		Return importDAL.selectAll(_imports)
	End Function

	Public Function insert(import As ImportDTO) As Result
		' Validate here
		Return importDAL.insert(import)
	End Function

	Public Function update(import As ImportDTO) As Result
		Return importDAL.update(import)
	End Function

	Public Function delete(import As String) As Result
		Return importDAL.delete(import)
	End Function
End Class

Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class ParameterBUS
	Private parameterDAL As ParameterDAL

	Public Sub New()
		parameterDAL = New ParameterDAL()
	End Sub

	Public Sub New(connectionStr As String)
		parameterDAL = New ParameterDAL(connectionStr)
	End Sub

	Private Function IsValidToUpdate(parameters As ParameterDTO) As Result
		If (parameters.MinImportAmount < 0) Then
			Return New Result(False, "Minimum Import Amount is out of range", "")
		End If

		If (parameters.MaxStockBeforeImport < 0) Then
			Return New Result(False, "Maximum Stock Before Import is out of range", "")
		End If

		If (parameters.MaxDebt < 0) Then
			Return New Result(False, "Maximum Debt is out of range", "")
		End If

		If (parameters.MinStockAfterSales < 0) Then
			Return New Result(False, "Minimum Stock After Sales is out of range", "")
		End If

		Return New Result(True)
	End Function

	Public Function selectAll(ByRef parameters As ParameterDTO) As Result
		' Validate here
		Return parameterDAL.selectAll(parameters)
	End Function

	Public Function update(parameters As ParameterDTO) As Result
		Dim result = IsValidToUpdate(parameters)

		If (result.FlagResult = True) Then
			Return parameterDAL.update(parameters)
		End If

		Return result
	End Function
End Class

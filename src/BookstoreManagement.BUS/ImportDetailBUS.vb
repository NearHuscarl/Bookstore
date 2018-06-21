Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class ImportDetailBUS
	Private importDetailDAL As ImportDetailDAL
	Private parameterBUS As ParameterBUS

	Public Sub New()
		importDetailDAL = New ImportDetailDAL()
		parameterBUS = New ParameterBUS()
	End Sub

	Public Sub New(connectionStr As String)
		importDetailDAL = New ImportDetailDAL(connectionStr)
		parameterBUS = New ParameterBUS()
	End Sub

	Public Function isValidImportDetail(importDetailDTO As ImportDetailDTO)
		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)

		If result.FlagResult = True Then
			If (importDetailDTO.ImportAmount < parameter.MinImportAmount) Then
				Return False
			End If

			If (importDetailDTO.CurrentAmount > parameter.MinStockBeforeImport) Then
				Return False
			End If

			Return True
		End If
		Return False
	End Function

	Public Function insertAll(importDetailDTOs As List(Of ImportDetailDTO)) As Result

		Return importDetailDAL.insertAll(importDetailDTOs)

	End Function

	Public Function getNextId(ByRef nextId As Integer) As Result

		Return importDetailDAL.getNextId(nextId)

	End Function
End Class

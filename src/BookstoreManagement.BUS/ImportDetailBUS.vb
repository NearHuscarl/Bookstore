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

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return importDetailDAL.getNextId(nextId)
	End Function

	Public Function isValidImportDetail(importDetail As ImportDetailDTO)
		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)

		If result.FlagResult = True Then
			If (importDetail.ImportAmount < parameter.MinImportAmount) Then
				Return False
			End If

			If (importDetail.CurrentAmount > parameter.MinStockBeforeImport) Then
				Return False
			End If

			Return True
		End If
		Return False
	End Function

	Public Function selectAll(ByRef importDetails As List(Of ImportDetailDTO)) As Result
		Return importDetailDAL.selectALL(importDetails)
	End Function

	Public Function selectAll_ByImport(importID As String, ByRef importDetails As List(Of ImportDetailDTO)) As Result
		'Return importDetailDAL.selectALL_ByImport(importID, importDetails)

		' TODO: remove
		importDetails = New List(Of ImportDetailDTO)
		importDetails.Add(New ImportDetailDTO("IMPORTDETAIL000", "IMPORT00", "BOOK001", 50, 30, 50))
		importDetails.Add(New ImportDetailDTO("IMPORTDETAIL001", "IMPORT00", "BOOK002", 40, 100, 60))
		importDetails.Add(New ImportDetailDTO("IMPORTDETAIL002", "IMPORT00", "BOOK003", 20, 300, 40))

		Return New Result(True)
	End Function

	Public Function insertAll(importDetails As List(Of ImportDetailDTO)) As Result
		Return importDetailDAL.insertAll(importDetails)
	End Function

	Public Function update(importDetail As ImportDetailDTO) As Result
		Return importDetailDAL.update(importDetail)
	End Function

	Public Function delete(importDetailID As String) As Result
		Return importDetailDAL.delete(importDetailID)
	End Function
End Class

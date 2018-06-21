Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class BookImportBUS
	Private bookImportDAL As BookImportDAL
	Private parameterBUS As ParameterBUS

	Public Sub New()
		bookImportDAL = New BookImportDAL()
		parameterBUS = New ParameterBUS()
	End Sub

	Public Sub New(connectionStr As String)
		bookImportDAL = New BookImportDAL(connectionStr)
		parameterBUS = New ParameterBUS()
	End Sub

	Public Function isValidBookImportInfo(importInfo As ImportDTO)
		If (importInfo.Name.Length < 1) Then
			Return False
		End If

		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)

		If result.FlagResult = True Then
			If (importInfo.ImportAmount < parameter.MinImportAmount) Then
				Return False
			End If

			' TODO: Check if number of books in inventory is small enough

			Return True
		End If
		Return False
	End Function

	Public Function insert(receipt As ReceiptDTO) As Result
		' Validate here
		Dim result As Result

		For Each importInfo As ImportDTO In receipt.BookImports
			result = bookImportDAL.insert(importInfo)

			If (result.FlagResult <> True) Then
				Return result
			End If
		Next

		Return result
	End Function

	Public Function insert(importInfo As ImportDTO) As Result
		' Validate here
		Return bookImportDAL.insert(importInfo)
	End Function

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return bookImportDAL.getNextId(nextId)
	End Function
End Class

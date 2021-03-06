﻿Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class ImportDetailBUS
	Private importDetailDAL As ImportDetailDAL
	Private parameterBUS As ParameterBUS
	Private bookBUS As BookBUS

	Public Sub New()
		importDetailDAL = New ImportDetailDAL()
		parameterBUS = New ParameterBUS()
		bookBUS = New BookBUS()
	End Sub

	Public Sub New(connectionStr As String)
		importDetailDAL = New ImportDetailDAL(connectionStr)
		parameterBUS = New ParameterBUS()
	End Sub

	Public Function getNextId(ByRef nextId As String) As Result
		Return importDetailDAL.getNextId(nextId)
	End Function

	Public Function insert(importDetail As ImportDetailDTO) As Result
		Return importDetailDAL.insert(importDetail)
	End Function

	Private Function Validate(importDetail As ImportDetailDTO) As Result
		If (importDetail.BookID Is Nothing) Then
			Return New Result(False, $"Book ID of {importDetail.ID} is missing", "")
		End If

		If (importDetail.ImportAmount < 0) Then
			Return New Result(False, $"Import amount of {importDetail.ID} is  out of range", "")
		End If

		If (importDetail.ImportPrice < 0) Then
			Return New Result(False, $"Import price of {importDetail.ID} is  out of range", "")
		End If

		Return New Result(True)
	End Function

	Private Function IsValidToAdd(importDetail As ImportDetailDTO) As Result
		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)
		Dim book As BookDTO

		If result.FlagResult = False Then
			Return result
		End If

		result = Validate(importDetail)
		If result.FlagResult = False Then
			Return result
		End If

		If (importDetail.ImportAmount < parameter.MinImportAmount) Then
			Return New Result(False, $"Import amount of {importDetail.ID} is smaller than minimum allowed ({importDetail.ImportAmount} < {parameter.MinImportAmount})", "")
		End If

		result = bookBUS.select_ByID(importDetail.BookID, book)

		If (result.FlagResult = True) Then
			If (book.Stock > parameter.MaxStockBeforeImport) Then
				Return New Result(False, $"Stock of {book.ID} is larger than minimum required to import ({book.Stock} > {parameter.MaxStockBeforeImport})", "")
			End If
		Else
			Return New Result(False, $"Cannot load book when validating import detail", "")
		End If

		Return result
	End Function

	Private Function IsValidToUpdate(importDetail As ImportDetailDTO) As Result
		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)

		If result.FlagResult = False Then
			Return result
		End If

		result = Validate(importDetail)
		If result.FlagResult = False Then
			Return result
		End If

		If (importDetail.ImportAmount < parameter.MinImportAmount) Then
			Return New Result(False, $"Import amount of {importDetail.ID} is smaller than minimum allowed ({importDetail.ImportAmount} < {parameter.MinImportAmount})", "")
		End If

		Return result
	End Function

	Public Function selectAll(ByRef importDetails As List(Of ImportDetailDTO)) As Result
		Return importDetailDAL.selectAll(importDetails)
	End Function

	Public Function selectAll_ByBook(bookID As String, ByRef importDetails As List(Of ImportDetailDTO)) As Result
		Return importDetailDAL.selectAll_ByBook(bookID, importDetails)
	End Function

	Public Function selectAll_ByImport(importID As String, ByRef importDetails As List(Of ImportDetailDTO)) As Result
		Return importDetailDAL.selectAll_ByImport(importID, importDetails)
	End Function

	Public Function insertAll(importDetails As List(Of ImportDetailDTO)) As Result
		Dim oldBooks As List(Of BookDTO) = New List(Of BookDTO)
		Dim result As Result

		For Each importDetail As ImportDetailDTO In importDetails
			result = IsValidToAdd(importDetail)

			If (result.FlagResult = False) Then
				Return result
			End If

			Dim book As BookDTO
			result = bookBUS.select_ByID(importDetail.BookID, book)

			If (result.FlagResult = True) Then
				oldBooks.AddIfNotExist(book, BookComparer.Instance)

				book.Stock += importDetail.ImportAmount
				bookBUS.update(book)
			Else
				' Reverse changes in books
				For Each b As BookDTO In oldBooks
					bookBUS.update(b)
				Next
				Return New Result(False, $"Cannot get book for import detail ${importDetail.ID}", "")
			End If
		Next

		Return importDetailDAL.insertAll(importDetails)
	End Function

	Public Function update(newImportDetail As ImportDetailDTO) As Result
		Dim oldCustomers As List(Of CustomerDTO) = New List(Of CustomerDTO)
		Dim oldImportDetail As ImportDetailDTO
		Dim result As Result

		result = importDetailDAL.select_ByID(newImportDetail.ID, oldImportDetail)

		If (result.FlagResult = False) Then
			Return New Result(False, $"Cannot get import detail ${newImportDetail.ID}", "")
		End If

		result = IsValidToUpdate(newImportDetail)

		If (result.FlagResult = False) Then
			Return result
		End If

		Dim book As BookDTO
		result = bookBUS.select_ByID(newImportDetail.BookID, book)

		If (result.FlagResult = True) Then ' TODO: update stock when bookID changed too
			book.Stock += (newImportDetail.ImportAmount - oldImportDetail.ImportAmount)
			bookBUS.update(book)
		Else
			Return New Result(False, $"Cannot get book for import detail ${newImportDetail.ID}", "")
		End If

		Return importDetailDAL.update(newImportDetail)
	End Function

	Public Function delete(importDetailID As String) As Result
		Return importDetailDAL.delete(importDetailID)
	End Function

	Public Function IsValidImportDetail(importDetail As ImportDetailDTO) As Result
		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)
		Dim book As BookDTO

		If result.FlagResult = True Then
			If (importDetail.BookID Is Nothing) Then
				Return New Result(False, $"Book ID of {importDetail.ID} is missing", "")
			End If

			If (importDetail.ImportAmount < parameter.MinImportAmount) Then
				Return New Result(False, $"Import amount of {importDetail.ID} is smaller than minimum allowed ({importDetail.ImportAmount} < {parameter.MinImportAmount})", "")
			End If

			result = bookBUS.select_ByID(importDetail.BookID, book)

			If (result.FlagResult = True) Then
				If (book.Stock > parameter.MaxStockBeforeImport) Then
					Return New Result(False, $"Stock of {book.ID} is larger than minimum required to import ({book.Stock} > {parameter.MaxStockBeforeImport})", "")
				End If
			End If
		End If
		Return result
	End Function

End Class

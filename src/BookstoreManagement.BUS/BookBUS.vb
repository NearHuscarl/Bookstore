﻿Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class BookBUS
	Private bookDAL As BookDAL

	Public Sub New()
		bookDAL = New BookDAL()
	End Sub

	Public Sub New(connectionStr As String)
		bookDAL = New BookDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As String) As Result
		Return bookDAL.getNextId(nextId)
	End Function

	Public Function insert(book As BookDTO) As Result
		Return bookDAL.insert(book)
	End Function
	Public Function select_ByID(bookID As String, ByRef book As BookDTO) As Result
		Return bookDAL.select_ByID(bookID, book)
	End Function

	Public Function selectAll(ByRef books As List(Of BookDTO)) As Result
		Return bookDAL.selectAll(books)
	End Function

	Public Function selectAll_BySearch(name As String, ByRef books As List(Of BookDTO)) As Result
		Return bookDAL.selectAll_BySearch(name, books)
	End Function

	Public Function selectAll_ByAuthor(authorID As String, ByRef books As List(Of BookDTO)) As Result
		Return bookDAL.selectAll_ByAuthor(authorID, books)
	End Function

	Public Function selectAll_ByBookCategory(bookCategoryID As String, ByRef books As List(Of BookDTO)) As Result
		Return bookDAL.selectAll_ByBookCategory(bookCategoryID, books)
	End Function

	Public Function update(book As BookDTO) As Result
		Return bookDAL.update(book)
	End Function

	Public Function delete(bookID As String) As Result
		Return bookDAL.delete(bookID)
	End Function
End Class

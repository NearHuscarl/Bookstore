Imports BookstoreManagement.DAL
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

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return bookDAL.getNextId(nextId)
	End Function

	Public Function insert(book As BookDTO) As Result
		Return bookDAL.insert(book)
	End Function

	Public Function sellectALL(ByRef books As List(Of BookDTO)) As Result
		Return bookDAL.sellectALL(books)
	End Function

	Public Function sellectALL_ByAuthor(authorID As String, ByRef books As List(Of BookDTO)) As Result
		Return bookDAL.sellectALL_ByAuthor(authorID, books)
	End Function

	Public Function sellectALL_ByBookCategory(bookCategoryID As String, ByRef books As List(Of BookDTO)) As Result
		Return bookDAL.sellectALL_ByBookCategory(bookCategoryID, books)
	End Function

	Public Function update(book As BookDTO) As Result
		Return bookDAL.update(book)
	End Function

	Public Function delete(bookID As String) As Result
		Return bookDAL.delete(bookID)
	End Function
End Class

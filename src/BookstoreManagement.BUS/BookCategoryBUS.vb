Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class BookCategoryBUS
	Private bookCategoryDAL As BookCategoryDAL

	Public Sub New()
		bookCategoryDAL = New BookCategoryDAL()
	End Sub

	Public Sub New(connectionStr As String)
		bookCategoryDAL = New BookCategoryDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As String) As Result
		Return bookCategoryDAL.getNextId(nextId)
	End Function

	Public Function insert(category As BookCategoryDTO) As Result
		Return bookCategoryDAL.insert(category)
	End Function

	Public Function select_ByID(bookCategoryID As String, ByRef bookCategory As BookCategoryDTO) As Result
		Return bookCategoryDAL.select_ByID(bookCategoryID, bookCategory)
	End Function

	Public Function selectAll(ByRef bookCategories As List(Of BookCategoryDTO)) As Result
		Return bookCategoryDAL.selectAll(bookCategories)
	End Function

	Public Function selectAll_BySearch(name As String, ByRef bookCategories As List(Of BookCategoryDTO)) As Result
		Return bookCategoryDAL.selectAll_BySearch(name, bookCategories)
	End Function

	Public Function update(bookCategory As BookCategoryDTO) As Result
		Return bookCategoryDAL.update(bookCategory)
	End Function

	Public Function delete(bookCategoryID As String) As Result
		Return bookCategoryDAL.delete(bookCategoryID)
	End Function
End Class

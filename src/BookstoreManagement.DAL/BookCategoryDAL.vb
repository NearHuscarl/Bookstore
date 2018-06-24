﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class BookCategoryDAL
	Private connectionStr As String

	Public Sub New()
		connectionStr = ConfigurationManager.AppSettings("ConnectionStr")
	End Sub

	Public Sub New(connectionStr As String)
		Me.connectionStr = connectionStr
	End Sub

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return New Result(True)
	End Function

	Public Function insert(category As BookCategoryDTO) As Result
		Return New Result(True)
	End Function

	Public Function sellectALL(ByRef bookCategories As List(Of BookCategoryDTO)) As Result
		Return New Result(True)
	End Function

	Public Function update(bookCategory As BookCategoryDTO) As Result
		Return New Result(True)
	End Function

	Public Function delete(bookCategoryID As String) As Result
		Return New Result(True)
	End Function
End Class
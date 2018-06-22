Imports System.Configuration
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

   Public Function insert(reader As BookCategoryDTO) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL(ByRef listBookCategory As List(Of BookCategoryDTO)) As Result
      Return New Result(True)
   End Function

   Public Function update(BookCategory As BookCategoryDTO) As Result
      Return New Result(True)
   End Function

   Public Function delete(BookCategoryID As String) As Result
      Return New Result(True)
   End Function

End Class
Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class AuthorDAL
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

   Public Function insert(reader As AuthorDTO) As Result
      Return New Result(True)
   End Function

   Public Function sellectALL(ByRef listAuthor As List(Of AuthorDTO)) As Result
      Return New Result(True)
   End Function

   Public Function update(author As AuthorDTO) As Result
      Return New Result(True)
   End Function

   Public Function delete(AuthorID As String) As Result
      Return New Result(True)
   End Function

End Class

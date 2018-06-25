﻿Imports System.Configuration
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

      Dim query As String = String.Empty
      query &= " SELECT TOP 1 [ID] "
      query &= " FROM [Author] "
      query &= " ORDER BY [ID] DESC "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
            End With

            Try
               conn.Open()

               Dim author As SqlDataReader
               Dim idOnDB As Integer

               author = comm.ExecuteReader()
               idOnDB = Nothing

               If author.HasRows = True Then
                  While author.Read()
                     idOnDB = author("ID")
                  End While
               End If

               nextId = idOnDB + 1 'new ID = current ID + 1

            Catch exception As Exception
               conn.Close()

               nextId = 1

               Console.WriteLine("Get next Author ID failed") 'for debug
               Return New Result(False, "Get next Author ID failed", exception.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Get next Author ID succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function insert(author As AuthorDTO) As Result

      Dim query As String = String.Empty
      query &= " INSERT INTO [Author] ([ID], [Name]) "
      query &= " VALUES (@ID, @Name) "

      Dim nextID = 0
      Dim result As Result

      result = getNextId(nextID)
      If (result.FlagResult = False) Then
         Return result
      End If
      author.ID = nextID

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query

               .Parameters.AddWithValue("@ID", author.ID)
               .Parameters.AddWithValue("@Name", author.Name)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()

            Catch exception As Exception
               conn.Close()

               Console.WriteLine("Insert Author failed") 'for debug
               Return New Result(False, "Insert Author failed", exception.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Insert Author succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function selectAll(ByRef authors As List(Of AuthorDTO)) As Result

      Dim query As String = String.Empty
      query &= " SELECT [ID], [Name] "
      query &= " FROM [Author] "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
            End With

            Try
               conn.Open()

               Dim author As SqlDataReader
               author = comm.ExecuteReader()

               If author.HasRows = True Then
                  authors.Clear()
                  While author.Read()
                     authors.Add(New AuthorDTO(author("ID"), author("Name")))
                  End While
               End If

            Catch ex As Exception
               conn.Close()

               Console.WriteLine("Get Authors failed") 'for debug
               Return New Result(False, "Get Authors failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Get Authors succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function update(author As AuthorDTO) As Result

      Dim query As String = String.Empty
      query &= " UPDATE [Author] SET "
      query &= " [Name] = @Name "
      query &= " WHERE [ID] = @ID "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
               .Parameters.AddWithValue("@ID", author.ID)
               .Parameters.AddWithValue("@Name", author.Name)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()

            Catch ex As Exception
               Console.WriteLine(ex.StackTrace)
               conn.Close()

               Console.WriteLine("Update Author failed") 'for debug
               Return New Result(False, "Update Author failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Update Author succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function delete(authorID As String) As Result

      Dim query As String = String.Empty
      query &= " DELETE FROM [Author] "
      query &= " WHERE [ID] = @ID "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
               .Parameters.AddWithValue("@ID", authorID)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()

            Catch ex As Exception
               Console.WriteLine(ex.StackTrace)
               conn.Close()

               Console.WriteLine("Delete Author failed") 'for debug
               Return New Result(False, "Delete Author failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Delete Author succeed") 'for debug
      Return New Result(True)
   End Function

End Class

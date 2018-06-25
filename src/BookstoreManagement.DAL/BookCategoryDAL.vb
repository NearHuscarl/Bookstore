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

      Dim query As String = String.Empty
      query &= " SELECT TOP 1 [ID] "
      query &= " FROM [BookCategory] "
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

               Dim bookCategory As SqlDataReader
               Dim idOnDB As Integer

               bookCategory = comm.ExecuteReader()
               idOnDB = Nothing

               If bookCategory.HasRows = True Then
                  While bookCategory.Read()
                     idOnDB = bookCategory("ID")
                  End While
               End If

               nextId = idOnDB + 1 'new ID = current ID + 1

            Catch exception As Exception
               conn.Close()

               nextId = 1

               Console.WriteLine("Get next Book Category ID failed") 'for debug
               Return New Result(False, "Get next Book Category ID failed", exception.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Get next Book Category ID succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function insert(bookCategory As BookCategoryDTO) As Result

      Dim query As String = String.Empty
      query &= " INSERT INTO [BookCategory] ([ID], [Name]) "
      query &= " VALUES (@ID, @Name) "

      Dim nextID = 0
      Dim result As Result

      result = getNextId(nextID)
      If (result.FlagResult = False) Then
         Return result
      End If
      bookCategory.ID = nextID

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query

               .Parameters.AddWithValue("@ID", bookCategory.ID)
               .Parameters.AddWithValue("@Name", bookCategory.Name)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()
            Catch exception As Exception
               conn.Close()

               Console.WriteLine("Book Category insert failed") 'for debug
               Return New Result(False, "Book Category insert failed", exception.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Book Category insert succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function selectAll(ByRef bookCategories As List(Of BookCategoryDTO)) As Result

      Dim query As String = String.Empty
      query &= " SELECT [ID], [Name] "
      query &= " FROM [BookCategory] "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
            End With

            Try
               conn.Open()

               Dim bookCategory As SqlDataReader
               bookCategory = comm.ExecuteReader()

               If bookCategory.HasRows = True Then
                  bookCategories.Clear()
                  While bookCategory.Read()
                     bookCategories.Add(New BookCategoryDTO(bookCategory("ID"), bookCategory("Name")))
                  End While
               End If

            Catch ex As Exception
               conn.Close()

               Console.WriteLine("Get Book Categories failed") 'for debug
               Return New Result(False, "Get Book Categories failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Get Book Categories succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function update(bookCategory As BookCategoryDTO) As Result

      Dim query As String = String.Empty
      query &= " UPDATE [BookCategory] SET "
      query &= " [Name] = @Name "
      query &= " WHERE [ID] = @ID "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
               .Parameters.AddWithValue("@ID", bookCategory.ID)
               .Parameters.AddWithValue("@Name", bookCategory.Name)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()

            Catch ex As Exception
               Console.WriteLine(ex.StackTrace)
               conn.Close()

               Console.WriteLine("Update Book Category failed")
               Return New Result(False, "Update Book Category failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Update Book Category succeed")
      Return New Result(True)
   End Function

   Public Function delete(bookCategoryID As String) As Result

      Dim query As String = String.Empty
      query &= " DELETE FROM [BookCategory] "
      query &= " WHERE [ID] = @ID "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
               .Parameters.AddWithValue("@ID", bookCategoryID)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()

            Catch ex As Exception
               Console.WriteLine(ex.StackTrace)
               conn.Close()

               Console.WriteLine("Delete Book Category failed")
               Return New Result(False, "Delete Book Category failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Delete Book Category succeed")
      Return New Result(True)
   End Function
End Class
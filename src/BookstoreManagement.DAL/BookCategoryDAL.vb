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

	Public Function getNextId(ByRef nextId As String) As Result

		Dim query As String = String.Empty
		query &= "SELECT TOP 1 [ID] "
		query &= "FROM [BookCategory] "
		query &= "ORDER BY [ID] DESC"

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
					Dim idOnDB As String

					bookCategory = comm.ExecuteReader()
					idOnDB = Nothing

					If bookCategory.HasRows = True Then
						While bookCategory.Read()
							idOnDB = bookCategory("ID")
						End While
					End If

					idOnDB.IncrementID("CATEGORY", "D8")
					nextId = idOnDB

				Catch exception As Exception

					Debug.WriteLine("Get next book category ID failed")
					Return New Result(False, "Get next book category ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get next book category ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(bookCategory As BookCategoryDTO) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [BookCategory] ([ID], [Name]) "
		query &= "VALUES (@ID, @Name)"

		Dim nextID = String.Empty
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

					Debug.WriteLine("Insert book category failed")
					Return New Result(False, "Insert book category failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert book category succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef bookCategories As List(Of BookCategoryDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [Name] "
		query &= "FROM [BookCategory]"

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

					Debug.WriteLine("Get book categories failed")
					Return New Result(False, "Get book categories failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get book categories succeed")
		Return New Result(True)
	End Function

	Public Function update(bookCategory As BookCategoryDTO) As Result

		Dim query As String = String.Empty
		query &= "UPDATE [BookCategory] SET "
		query &= "[Name] = @Name"
		query &= " WHERE [ID] = @ID"

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

					Debug.WriteLine("Update book category failed")
					Return New Result(False, "Update book category failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update book category succeed")
		Return New Result(True)
	End Function

	Public Function delete(bookCategoryID As String) As Result

		Dim query As String = String.Empty
		query &= "DELETE FROM [BookCategory] "
		query &= "WHERE [ID] = @ID"

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

					Debug.WriteLine("Delete book category failed")
					Return New Result(False, "Delete book category failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Delete book category succeed")
		Return New Result(True)
	End Function
End Class
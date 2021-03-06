﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility


Public Class BookDAL
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
		query &= "FROM [Book] "
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

					Dim reader As SqlDataReader
					Dim idOnDB As String

					reader = comm.ExecuteReader()
					idOnDB = Nothing

					If reader.HasRows = True Then
						While reader.Read()
							idOnDB = reader("ID")
						End While
					End If

					idOnDB.IncrementID("BOOK", "D4")
					nextId = idOnDB

				Catch exception As Exception

					'Debug.WriteLine("Get next book ID failed")
					Return New Result(False, "Get next book ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get next book ID succeed")
		Return New Result(True)

	End Function

	Public Function insert(book As BookDTO) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [Book] ([ID], [Name], [AuthorID], [BookCategoryID], [Stock], [Price]) "
		query &= "VALUES (@ID, @Name, @AuthorID, @BookCategoryID, @Stock, @Price)"

		Dim nextID = String.Empty
		Dim result As Result

		result = getNextId(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		book.ID = nextID

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query

					.Parameters.AddWithValue("@ID", book.ID)
					.Parameters.AddWithValue("@Name", book.Name)
					.Parameters.AddWithValue("@AuthorID", book.AuthorID)
					.Parameters.AddWithValue("@BookCategoryID", book.BookCategoryID)
					.Parameters.AddWithValue("@Stock", book.Stock)
					.Parameters.AddWithValue("@Price", book.Price)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch exception As Exception

					'Debug.WriteLine("Insert book failed")
					Return New Result(False, "Insert book failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Insert book succeed")
		Return New Result(True)
	End Function

	Public Function select_ByID(bookID As String, ByRef book As BookDTO) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [Name], [AuthorID], [BookCategoryID], [Stock], [Price] "
		query &= "FROM [Book] "
		query &= "WHERE [Book].[ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", bookID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						reader.Read()
						book = New BookDTO(reader("ID"), reader("Name"), reader("AuthorID"), reader("BookCategoryID"), reader("Stock"), reader("Price"))
					End If

				Catch ex As Exception

					'Debug.WriteLine("Get book failed")
					Return New Result(False, "Get book failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get book succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef books As List(Of BookDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [Name], [AuthorID], [BookCategoryID], [Stock], [Price] "
		query &= "FROM [Book] "
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

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						books.Clear()
						While reader.Read()
							books.Add(New BookDTO(reader("ID"), reader("Name"), reader("AuthorID"), reader("BookCategoryID"), reader("Stock"), reader("Price")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get books failed")
					Return New Result(False, "Get book failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get book succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_BySearch(name As String, ByRef books As List(Of BookDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [Name], [AuthorID], [BookCategoryID], [Stock], [Price] "
		query &= "FROM [Book] "
		query &= "WHERE [Name] LIKE '%' + @Name + '%' "
		query &= "ORDER BY [ID] DESC"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@Name", name)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						books.Clear()
						While reader.Read()
							books.Add(New BookDTO(reader("ID"), reader("Name"), reader("AuthorID"), reader("BookCategoryID"), reader("Stock"), reader("Price")))
						End While
					End If

				Catch ex As Exception

					'Debug.WriteLine("Get books failed")
					Return New Result(False, "Get books failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get books succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByAuthor(authorID As String, ByRef books As List(Of BookDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [Name], [AuthorID], [BookCategoryID], [Stock], [Price] "
		query &= "FROM [Book] "
		query &= "WHERE [Book].[AuthorID] = @AuthorID"
		query &= " ORDER BY [ID] DESC"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@AuthorID", authorID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						books.Clear()
						While reader.Read()
							books.Add(New BookDTO(reader("ID"), reader("Name"), reader("AuthorID"), reader("BookCategoryID"), reader("Stock"), reader("Price")))
						End While
					End If

				Catch ex As Exception

					'Debug.WriteLine("Get books failed")
					Return New Result(False, "Get books failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get books succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByBookCategory(bookCategoryID As String, ByRef books As List(Of BookDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [Name], [AuthorID], [BookCategoryID], [Stock], [Price] "
		query &= "FROM [Book] "
		query &= "WHERE [Book].[BookCategoryID] = @BookCategoryID"
		query &= " ORDER BY [ID] DESC"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@BookCategoryID", bookCategoryID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						books.Clear()
						While reader.Read()
							books.Add(New BookDTO(reader("ID"), reader("Name"), reader("AuthorID"), reader("BookCategoryID"), reader("Stock"), reader("Price")))
						End While
					End If

				Catch ex As Exception

					'Debug.WriteLine("Get books failed")
					Return New Result(False, "Get books failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get books succeed")
		Return New Result(True)
	End Function

	Public Function update(book As BookDTO) As Result

		Dim query As String = String.Empty
		query &= "UPDATE [Book] SET "
		query &= "[Name] = @Name, "
		query &= "[AuthorID] = @AuthorID, "
		query &= "[BookCategoryID] = @BookCategoryID, "
		query &= "[Stock] = @Stock, "
		query &= "[Price] = @Price"
		query &= " WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", book.ID)
					.Parameters.AddWithValue("@Name", book.Name)
					.Parameters.AddWithValue("@AuthorID", book.AuthorID)
					.Parameters.AddWithValue("@BookCategoryID", book.BookCategoryID)
					.Parameters.AddWithValue("@Stock", book.Stock)
					.Parameters.AddWithValue("@Price", book.Price)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					'Debug.WriteLine("Update book failed")
					Return New Result(False, "Update book failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Update book succeed")
		Return New Result(True)
	End Function

	Public Function delete(bookID As String) As Result

		Dim query As String = String.Empty
		query &= "DELETE FROM [Book] "
		query &= "WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", bookID)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					'Debug.WriteLine("Delete book failed")
					Return New Result(False, "Delete book failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Delete book succeed")
		Return New Result(True)
	End Function
End Class

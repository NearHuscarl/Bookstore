Imports System.Configuration
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

	Public Function getNextId(ByRef nextId As Integer) As Result

		Dim query As String = String.Empty
		query &= " SELECT TOP 1 [ID] "
		query &= " FROM [Book] "
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

					Dim book As SqlDataReader
					Dim idOnDB As Integer

					book = comm.ExecuteReader()
					idOnDB = Nothing

					If book.HasRows = True Then
						While book.Read()
							idOnDB = book("ID")
						End While
					End If

					nextId = idOnDB + 1 'new ID = current ID + 1

				Catch exception As Exception
					nextId = 1

					Debug.WriteLine("Get next book ID failed")
					Return New Result(False, "Get next book ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get next book ID succeed")
		Return New Result(True)

	End Function

	Public Function insert(book As BookDTO) As Result

		Dim query As String = String.Empty
		query &= " INSERT INTO [Book] ([ID], [Name], [AuthorID], [BookCategoryID], [Stock], [Price]) "
		query &= " VALUES (@ID, @Name, @AuthorID, @BookCategoryID, @Stock, @Price) "

		Dim nextID = 0
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

					Debug.WriteLine("Insert book failed")
					Return New Result(False, "Insert book failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert book succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef books As List(Of BookDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [Name], [AuthorID], [BookCategoryID], [Stock], [Price] "
		query &= " FROM [Book] "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
				End With

				Try
					conn.Open()

					Dim book As SqlDataReader
					book = comm.ExecuteReader()

					If book.HasRows = True Then
						books.Clear()
						While book.Read()
							books.Add(New BookDTO(book("ID"), book("Name"), book("AuthorID"), book("BookCategoryID"), book("Stock"), book("Price")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get books failed")
					Return New Result(False, "Get books failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get books succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByAuthorID(authorID As String, ByRef books As List(Of BookDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [Name], [AuthorID], [BookCategoryID], [Stock], [Price] "
		query &= " FROM [Book] "
		query &= " WHERE [Book].[AuthorID] = @AuthorID "

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

					Dim book As SqlDataReader
					book = comm.ExecuteReader()

					If book.HasRows = True Then
						books.Clear()
						While book.Read()
							books.Add(New BookDTO(book("ID"), book("Name"), book("AuthorID"), book("BookCategoryID"), book("Stock"), book("Price")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get books failed")
					Return New Result(False, "Get books failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get books succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByBookCategoryID(bookCategoryID As String, ByRef books As List(Of BookDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [Name], [AuthorID], [BookCategoryID], [Stock], [Price] "
		query &= " FROM [Book]"
		query &= " WHERE [Book].[BookCategoryID] = @BookCategoryID"

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

					Dim book As SqlDataReader
					book = comm.ExecuteReader()

					If book.HasRows = True Then
						books.Clear()
						While book.Read()
							books.Add(New BookDTO(book("ID"), book("Name"), book("AuthorID"), book("BookCategoryID"), book("Stock"), book("Price")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get books failed")
					Return New Result(False, "Get books failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get books succeed")
		Return New Result(True)
	End Function

	Public Function update(book As BookDTO) As Result

		Dim query As String = String.Empty
		query &= " UPDATE [Book] SET "
		query &= " [Name] = @Name , "
		query &= " [AuthorID] = @AuthorID , "
		query &= " [BookCategoryID] = @BookCategoryID , "
		query &= " [Stock] = @Stock , "
		query &= " [Price] = @Price "
		query &= " WHERE [ID] = @ID "

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

					Debug.WriteLine("Update book failed")
					Return New Result(False, "Update book failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update book succeed")
		Return New Result(True)
	End Function

	Public Function delete(bookID As String) As Result

		Dim query As String = String.Empty
		query &= " DELETE FROM [Book] "
		query &= " WHERE "
		query &= " [ID] = @ID "

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

					Debug.WriteLine("Delete book failed")
					Return New Result(False, "Delete book failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Delete book succeed")
		Return New Result(True)
	End Function
End Class

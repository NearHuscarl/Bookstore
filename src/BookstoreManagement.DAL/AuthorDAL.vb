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

	Public Function getNextId(ByRef nextId As String) As Result

		Dim query As String = String.Empty
		query &= "SELECT TOP 1 [ID] "
		query &= "FROM [Author] "
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

					idOnDB.IncrementID("AUTHOR", "D4")
					nextId = idOnDB

				Catch exception As Exception

					'Debug.WriteLine("Get next author ID failed")
					Return New Result(False, "Get next author ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get next author ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(author As AuthorDTO) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [Author] ([ID], [Name]) "
		query &= "VALUES (@ID, @Name)"

		Dim nextID = String.Empty
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

					'Debug.WriteLine("Insert author failed")
					Return New Result(False, "Insert author failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Insert author succeed")
		Return New Result(True)
	End Function

	Public Function select_ByID(authorID As String, ByRef author As AuthorDTO) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [Name] "
		query &= "FROM [Author] "
		query &= "WHERE [Author].[ID] = @ID"

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

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						reader.Read()
						author = New AuthorDTO(reader("ID"), reader("Name"))
					End If

				Catch ex As Exception

					'Debug.WriteLine("Get author failed")
					Return New Result(False, "Get author failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get author succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef authors As List(Of AuthorDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [Name] "
		query &= "FROM [Author] "
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
						authors.Clear()
						While reader.Read()
							authors.Add(New AuthorDTO(reader("ID"), reader("Name")))
						End While
					End If

				Catch ex As Exception

					'Debug.WriteLine("Get authors failed")
					Return New Result(False, "Get authors failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get authors succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_BySearch(name As String, ByRef authors As List(Of AuthorDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [Name] "
		query &= "FROM [Author] "
		query &= "WHERE [Name] LIKE '%' + @Name + '%' "
		query &= " ORDER BY [ID] DESC"

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
						authors.Clear()
						While reader.Read()
							authors.Add(New AuthorDTO(reader("ID"), reader("Name")))
						End While
					End If

				Catch ex As Exception

					'Debug.WriteLine("Get authors failed")
					Return New Result(False, "Get authors failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get authors succeed")
		Return New Result(True)
	End Function

	Public Function update(author As AuthorDTO) As Result

		Dim query As String = String.Empty
		query &= "UPDATE [Author] SET"
		query &= "[Name] = @Name"
		query &= " WHERE [ID] = @ID"

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

					'Debug.WriteLine("Update author failed")
					Return New Result(False, "Update author failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Update author succeed")
		Return New Result(True)
	End Function

	Public Function delete(authorID As String) As Result

		Dim query As String = String.Empty
		query &= "DELETE FROM [Author]"
		query &= " WHERE [ID] = @ID"

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

					'Debug.WriteLine("Delete author failed")
					Return New Result(False, "Delete author failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Delete author succeed")
		Return New Result(True)
	End Function

End Class

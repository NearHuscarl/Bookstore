Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class ImportDAL
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
		query &= "FROM [Import] "
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

					idOnDB.IncrementID("IMPORT", "D4")
					nextId = idOnDB

				Catch exception As Exception

					Debug.WriteLine("Get next import ID failed")
					Return New Result(False, "Get next import ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get next import ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(import As ImportDTO) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [Import] ([ID], [ImportDate]) "
		query &= "VALUES (@ID, @ImportDate)"

		Dim nextID = String.Empty
		Dim result As Result

		result = getNextId(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		import.ID = nextID

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query

					.Parameters.AddWithValue("@ID", import.ID)
					.Parameters.AddWithValue("@ImportDate", import.ImportDate)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch exception As Exception

					Debug.WriteLine("Insert import failed")
					Return New Result(False, "Insert import failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert import succeed")
		Return New Result(True)
	End Function

	Public Function select_ByID(importID As String, ByRef import As ImportDTO) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [ImportDate] "
		query &= "FROM [Import] "
		query &= "WHERE [Import].[ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", importID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						reader.Read()
						import = New ImportDTO(reader("ID"), reader("ImportDate"))
					End If

				Catch ex As Exception

					Debug.WriteLine("Get import failed")
					Return New Result(False, "Get import failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get import succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef _imports As List(Of ImportDTO)) As Result 'trùng keyword

		Dim query As String = String.Empty
		query &= "SELECT [ID], [ImportDate] "
		query &= "FROM [Import] "
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
						_imports.Clear()
						While reader.Read()
							_imports.Add(New ImportDTO(reader("ID"), reader("ImportDate")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get imports failed")
					Return New Result(False, "Get imports failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get imports succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByDate(importDate As DateTime, ByRef _imports As List(Of ImportDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [ImportDate] "
		query &= "FROM [Import] "
		query &= "WHERE [Import].[ImportDate] = @ImportDate"
		query &= " ORDER BY [ID] DESC"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ImportDate", importDate)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						_imports.Clear()
						While reader.Read()
							_imports.Add(New ImportDTO(reader("ID"), reader("ImportDate")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get imports failed")
					Return New Result(False, "Get imports failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get imports succeed")
		Return New Result(True)
	End Function

	Public Function update(import As ImportDTO) As Result

		Dim query As String = String.Empty
		query &= "UPDATE [Import] SET "
		query &= "[ImportDate] = @ImportDate"
		query &= " WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", import.ID)
					.Parameters.AddWithValue("@ImportDate", import.ImportDate)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update import failed")
					Return New Result(False, "Update import failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update import succeed")
		Return New Result(True)
	End Function

	Public Function delete(importID As String) As Result

		Dim query As String = String.Empty
		query &= "DELETE FROM [Import] "
		query &= "WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", importID)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Delete import failed")
					Return New Result(False, "Delete import failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Delete import succeed")
		Return New Result(True)
	End Function
End Class

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

	Public Function getNextId(ByRef nextId As Integer) As Result

		Dim query As String = String.Empty
		query &= " SELECT TOP 1 [ID] "
		query &= " FROM [Import] "
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

					Dim import As SqlDataReader
					Dim idOnDB As Integer

					import = comm.ExecuteReader()
					idOnDB = Nothing

					If import.HasRows = True Then
						While import.Read()
							idOnDB = import("ID")
						End While
					End If

					If IsNothing(idOnDB) Then
						nextId = "IMPORT0001"

					Else
						Dim IdPrefix As String = Regex.Replace(idOnDB, "[\d]", "")
						Dim IdNumber As Integer = Regex.Replace(idOnDB, "[^\d]", "")

						IdNumber += 1

						nextId = IdPrefix + IdNumber.ToString("D4")
					End If
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
		query &= " INSERT INTO [Import] ([ID], [ImportDate]) "
		query &= " VALUES (@ID, @ImportDate) "

		Dim nextID = 0
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

	Public Function selectAll(ByRef _imports As List(Of ImportDTO)) As Result 'trùng keyword

		Dim query As String = String.Empty
		query &= " SELECT [ID], [ImportDate] "
		query &= " FROM [Import]"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
				End With

				Try
					conn.Open()

					Dim import As SqlDataReader
					import = comm.ExecuteReader()

					If import.HasRows = True Then
						_imports.Clear()
						While import.Read()
							_imports.Add(New ImportDTO(import("ID"), import("ImportDate")))
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

	Public Function selectAll_ByImportDate(importDate As DateTime, ByRef _imports As List(Of ImportDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [ImportDate] "
		query &= " FROM [Import]"
		query &= " WHERE [Import].[ImportDate] = @ImportDate"


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

					Dim import As SqlDataReader
					import = comm.ExecuteReader()

					If import.HasRows = True Then
						_imports.Clear()
						While import.Read()
							_imports.Add(New ImportDTO(import("ID"), import("ImportDate")))
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
		query &= " UPDATE [Import] SET "
		query &= " [ImportDate] = @ImportDate "
		query &= " WHERE [ID] = @ID "

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
		query &= " DELETE FROM [Import] "
		query &= " WHERE [ID] = @ID "

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

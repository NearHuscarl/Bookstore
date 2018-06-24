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

		query &= "SELECT TOP 1 [ID]"
		query &= "FROM [Import]"
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
					Dim idOnDB As Integer

					reader = comm.ExecuteReader()
					idOnDB = Nothing

					If reader.HasRows = True Then
						While reader.Read()
							idOnDB = reader("ID")
						End While
					End If

					nextId = idOnDB + 1 ' new ID = current ID + 1

				Catch exception As Exception
					conn.Close()

					nextId = 1
					Return New Result(False, "Get Next Reader ID Failed", exception.StackTrace)

				End Try

			End Using

		End Using

		Return New Result(True)
	End Function

	Public Function insert(import As ImportDTO) As Result
		Dim query As String = String.Empty

		query &= "INSERT INTO [Import] ([ID], [DateImport])"
		query &= "VALUES (@ID, @DateImport)"

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
					.Parameters.AddWithValue("@DateImport", import.DateImport)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch exception As Exception
					conn.Close()
					Return New Result(False, "Import failed", exception.StackTrace)
				End Try

			End Using

		End Using

		Return New Result(True)
	End Function

	Public Function update(import As ImportDTO) As Result
		Return New Result(True)
	End Function

	Public Function delete(import As ImportDTO) As Result
		Return New Result(True)
	End Function
End Class

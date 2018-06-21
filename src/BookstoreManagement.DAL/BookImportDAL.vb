Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class BookImportDAL
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
		query &= "FROM [BookImport]"
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

	Public Function insert(reader As ImportDTO) As Result
		Dim query As String = String.Empty

		query &= "INSERT INTO [BookImport] ([ID], [Name], [Category], [Author], [Amount], [Price], [ReceivedDate])"
		query &= "VALUES (@ID, @Name, @Category, @Author, @Amount, @Price, @ReceivedDate)"

		Dim nextID = 0
		Dim result As Result

		result = getNextId(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		reader.ID = nextID

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query

					.Parameters.AddWithValue("@ID", reader.ID)
					.Parameters.AddWithValue("@Name", reader.Name)
					.Parameters.AddWithValue("@Category", reader.Category)
					.Parameters.AddWithValue("@Author", reader.Author)
					.Parameters.AddWithValue("@Amount", reader.ImportAmount)
					.Parameters.AddWithValue("@Price", reader.ImportPrice)
					.Parameters.AddWithValue("@ReceivedDate", reader.ReceivedDate)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch exception As Exception
					conn.Close()
					Return New Result(False, "Add Book Import Infos failed", exception.StackTrace)
				End Try

			End Using

		End Using

		Return New Result(True)
	End Function
End Class

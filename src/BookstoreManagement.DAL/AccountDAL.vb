Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class AccountDAL
	Private connectionStr As String

	Public Sub New()
		connectionStr = ConfigurationManager.AppSettings("ConnectionStr")
	End Sub

	Public Sub New(connectionStr As String)
		Me.connectionStr = connectionStr
	End Sub

	Public Function select_byID(ID As String, ByRef account As AccountDTO) As Result
		Dim query As String = String.Empty

		query &= " SELECT [ID], [Name], [Password], [Privilege]"
		query &= " FROM [Account]"
		query &= " WHERE [Account].[ID] = @ID "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", ID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						While reader.Read()
							account = New AccountDTO(
								reader("ID"),
								reader("Name"),
								reader("Password"),
								reader("Privilege")
								)
						End While
					End If

				Catch exception As Exception
					Console.WriteLine(exception.StackTrace)
					conn.Close()
					Return New Result(False, "Retrieve accounts failed!", exception.StackTrace)
				End Try

			End Using

		End Using

		Return New Result(True)
	End Function

	Public Function select_byName(username As String, ByRef account As AccountDTO) As Result
		Dim query As String = String.Empty

		query &= " SELECT [ID], [Name], [Password], [Privilege]"
		query &= " FROM [Account]"
		query &= " WHERE [Account].[Name] = @Name "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@Name", username)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						While reader.Read()
							account = New AccountDTO(
								reader("ID"),
								reader("Name"),
								reader("Password"),
								reader("Privilege")
								)
						End While
					End If

				Catch exception As Exception
					Console.WriteLine(exception.StackTrace)
					conn.Close()
					Return New Result(False, "Retrieve accounts failed!", exception.StackTrace)
				End Try

			End Using

		End Using

		Return New Result(True)
	End Function

	Public Function update(account As AccountDTO) As Result

		Dim query As String = String.Empty
		query &= "UPDATE [Account] SET "
		query &= " [Name] = @Name, "
		query &= " [Password] = @Password, "
		query &= " [Privilege] = @Privilege"
		query &= " WHERE [ID] = @ID "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", account.ID)
					.Parameters.AddWithValue("@Name", account.Name)
					.Parameters.AddWithValue("@Password", account.Password)
					.Parameters.AddWithValue("@Privilege", account.Privilege)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update account failed")
					Return New Result(False, "Update account failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update account succeed")
		Return New Result(True)
	End Function
End Class

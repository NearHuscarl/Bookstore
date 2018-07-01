Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class OptionDAL
	Private connectionStr As String

	Public Sub New()
		connectionStr = ConfigurationManager.AppSettings("ConnectionStr")
	End Sub

	Public Sub New(connectionStr As String)
		Me.connectionStr = connectionStr
	End Sub

	Public Function selectAll(ByRef _option As OptionDTO) As Result
		Dim query As String = String.Empty

		query &= " SELECT [RememberMe], [RememberedAccount]"
		query &= " FROM [Option]"

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
						reader.Read()

						If IsDBNull(reader("RememberedAccount")) Then
							_option = New OptionDTO(reader("RememberMe"), Nothing)
						Else
							_option = New OptionDTO(reader("RememberMe"), reader("RememberedAccount"))
						End If

					End If

				Catch exception As Exception
					Console.WriteLine(exception.StackTrace)
					conn.Close()
					Return New Result(False, "Retrieve options failed!", exception.StackTrace)
				End Try

			End Using

		End Using

		Return New Result(True)
	End Function

	Public Function update(_option As OptionDTO) As Result

		Dim query As String = String.Empty
		query &= "UPDATE [Option] SET "
		query &= " [RememberMe] = @RememberMe, "
		query &= " [RememberedAccount] = @RememberedAccount"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@RememberMe", _option.RememberMe)
					.Parameters.AddWithValue("@RememberedAccount", _option.RememberedAccount)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update options failed")
					Return New Result(False, "Update options failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update options succeed")
		Return New Result(True)
	End Function
End Class

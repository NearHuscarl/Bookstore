Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class ParameterDAL
	Private connectionStr As String

	Public Sub New()
		connectionStr = ConfigurationManager.AppSettings("ConnectionStr")
	End Sub

	Public Sub New(connectionStr As String)
		Me.connectionStr = connectionStr
	End Sub

	Public Function selectAll(ByRef parameter As ParameterDTO) As Result
		Dim query As String = String.Empty

		query &= " SELECT [MinImportAmount], [MinStockBeforeImport], [MinStockAfterSales], [MaxDept], [UseRegulation]"
		query &= " FROM [Parameter]"

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
						While reader.Read()
							parameter = New ParameterDTO(
								reader("MinImportAmount"),
								reader("MinStockBeforeImport"),
								reader("MinStockAfterSales"),
								reader("MaxDept"),
								reader("UseRegulation")
								)
						End While
					End If

				Catch exception As Exception
					Console.WriteLine(exception.StackTrace)
					conn.Close()
					Return New Result(False, "Retrieve parameters failed!", exception.StackTrace)
				End Try

			End Using

		End Using

		Return New Result(True)
	End Function
End Class

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

		query &= " SELECT [MinImportAmount], [MaxStockBeforeImport], [MinStockAfterSales], [MaxDebt], [UseRegulation]"
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
								reader("MaxStockBeforeImport"),
								reader("MinStockAfterSales"),
								reader("MaxDebt"),
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

	Public Function update(parameters As ParameterDTO) As Result

		Dim query As String = String.Empty
		query &= "UPDATE [Parameter] SET "
		query &= " [MinImportAmount] = @MinImportAmount"
		query &= " [MinStockBeforeImport] = @MinStockBeforeImport"
		query &= " [MinStockAfterSales] = @MinStockAfterSales"
		query &= " [MaxDebt] = @MaxDebt"
		query &= " [UseRegulation] = @UseRegulation"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@MinImportAmount", parameters.MinImportAmount)
					.Parameters.AddWithValue("@MinStockBeforeImport", parameters.MaxStockBeforeImport)
					.Parameters.AddWithValue("@MinStockAfterSales", parameters.MinStockAfterSales)
					.Parameters.AddWithValue("@MaxDebt", parameters.MaxDebt)
					.Parameters.AddWithValue("@UseRegulation", parameters.UseRegulation)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update parameters failed")
					Return New Result(False, "Update parameters failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update parameters succeed")
		Return New Result(True)
	End Function

	Public Function delete(parameters As ParameterDTO) As Result
		Return New Result(True)
	End Function
End Class

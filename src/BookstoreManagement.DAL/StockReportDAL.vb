Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class StockReportDAL
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
		query &= "FROM [StockReport] "
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

					Dim stockReport As SqlDataReader
					Dim idOnDB As String

					stockReport = comm.ExecuteReader()
					idOnDB = Nothing

					If stockReport.HasRows = True Then
						While stockReport.Read()
							idOnDB = stockReport("ID")
						End While
					End If


					idOnDB.IncrementID("STOCKREPORT", "D8")
					nextId = idOnDB

				Catch exception As Exception

					Debug.WriteLine("Get next stock report ID failed")
					Return New Result(False, "Get next stock report ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get next stock report ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(stockReport As StockReportDTO) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [StockReport] ([ID], [ReportDate]) "
		query &= "VALUES (@ID, @ReportDate)"

		Dim nextID = String.Empty
		Dim result As Result

		result = getNextId(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		stockReport.ID = nextID

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query

					.Parameters.AddWithValue("@ID", stockReport.ID)
					.Parameters.AddWithValue("@ReportDate", stockReport.ReportDate)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch exception As Exception

					Debug.WriteLine("Insert stock report failed")
					Return New Result(False, "Insert stock report failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert stock report succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef stockReports As List(Of StockReportDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [ReportDate] "
		query &= " FROM [StockReport] "
		query &= " ORDER BY [ID] DESC"


		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
				End With

				Try
					conn.Open()

					Dim stockReport As SqlDataReader
					stockReport = comm.ExecuteReader()

					If stockReport.HasRows = True Then
						stockReports.Clear()
						While stockReport.Read()
							stockReports.Add(New StockReportDTO(stockReport("ID"), stockReport("ReportDate")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get stock reports failed")
					Return New Result(False, "Get stock reports failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get stock reports succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByDate(reportDate As DateTime, ByRef stockReports As List(Of StockReportDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [ReportDate] "
		query &= " FROM [StockReport]"
		query &= " WHERE [StockReport].[ReportDate] = @ReportDate"
		query &= " ORDER BY [ID] DESC"


		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ReportDate", reportDate)
				End With

				Try
					conn.Open()

					Dim stockReport As SqlDataReader
					stockReport = comm.ExecuteReader()

					If stockReport.HasRows = True Then
						stockReports.Clear()
						While stockReport.Read()
							stockReports.Add(New StockReportDTO(stockReport("ID"), stockReport("ReportDate")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get stock reports failed")
					Return New Result(False, "Get stock reports failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get stock reports succeed")
		Return New Result(True)
	End Function

	Public Function update(stockReport As StockReportDTO) As Result
		Dim query As String = String.Empty
		query &= "UPDATE [StockReport] SET "
		query &= "[ReportDate] = @ReportDate"
		query &= " WHERE [ID] = @ID "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", stockReport.ID)
					.Parameters.AddWithValue("@ReportDate", stockReport.ReportDate)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update stock report failed")
					Return New Result(False, "Update stock report failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update stock report succeed")
		Return New Result(True)
	End Function

	Public Function delete(stockReportID As String) As Result

		Dim query As String = String.Empty
		query &= " DELETE FROM [StockReport] "
		query &= " WHERE [ID] = @ID "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", stockReportID)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Delete stock report failed")
					Return New Result(False, "Delete stock report failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Delete stock report succeed")
		Return New Result(True)
	End Function
End Class
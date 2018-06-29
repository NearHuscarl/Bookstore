Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class DebtReportDAL
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
		query &= "FROM [DebtReport] "
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


					idOnDB.IncrementID("DEBTREPORT", "D4")
					nextId = idOnDB

				Catch exception As Exception

					'Debug.WriteLine("Get next debt report ID failed")
					Return New Result(False, "Get next debt report ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get next debt report ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(debtReport As DebtReportDTO) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [DebtReport] ([ID], [ReportDate]) "
		query &= "VALUES (@ID, @ReportDate)"

		Dim nextID = String.Empty
		Dim result As Result

		result = getNextId(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		debtReport.ID = nextID

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query

					.Parameters.AddWithValue("@ID", debtReport.ID)
					.Parameters.AddWithValue("@ReportDate", debtReport.ReportDate)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch exception As Exception

					'Debug.WriteLine("Insert debt report failed")
					Return New Result(False, "Insert debt report failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Insert debt report succeed")
		Return New Result(True)
	End Function

	Public Function select_ByID(debtReportID As String, ByRef debtReport As DebtReportDTO) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [ReportDate] "
		query &= "FROM [DebtReport] "
		query &= "WHERE [DebtReport].[ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", debtReportID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						reader.Read()
						debtReport = New DebtReportDTO(reader("ID"), reader("ReportDate"))

					End If

				Catch ex As Exception

					'Debug.WriteLine("Get debt report failed")
					Return New Result(False, "Get debt report failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get debt report succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef debtReports As List(Of DebtReportDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [ReportDate] "
		query &= " FROM [DebtReport] "
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

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						debtReports.Clear()
						While reader.Read()
							debtReports.Add(New DebtReportDTO(reader("ID"), reader("ReportDate")))
						End While
					End If

				Catch ex As Exception

					'Debug.WriteLine("Get debt reports failed")
					Return New Result(False, "Get debt reports failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get debt reports succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByDate(reportDate As DateTime, ByRef debtReports As List(Of DebtReportDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [ReportDate] "
		query &= " FROM [DebtReport]"
		query &= " WHERE [DebtReport].[ReportDate] = @ReportDate"
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

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						debtReports.Clear()
						While reader.Read()
							debtReports.Add(New DebtReportDTO(reader("ID"), reader("ReportDate")))
						End While
					End If

				Catch ex As Exception

					'Debug.WriteLine("Get debt reports failed")
					Return New Result(False, "Get debt reports failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Get debt reports succeed")
		Return New Result(True)
	End Function

	Public Function update(debtReport As DebtReportDTO) As Result
		Dim query As String = String.Empty
		query &= "UPDATE [DebtReport] SET "
		query &= "[ReportDate] = @ReportDate"
		query &= " WHERE [ID] = @ID "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", debtReport.ID)
					.Parameters.AddWithValue("@ReportDate", debtReport.ReportDate)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					'Debug.WriteLine("Update debt report failed")
					Return New Result(False, "Update debt report failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Update debt report succeed")
		Return New Result(True)
	End Function

	Public Function delete(debtReportID As String) As Result

		Dim query As String = String.Empty
		query &= " DELETE FROM [DebtReport] "
		query &= " WHERE [ID] = @ID "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", debtReportID)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					'Debug.WriteLine("Delete debt report failed")
					Return New Result(False, "Delete debt report failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		'Debug.WriteLine("Delete debt report succeed")
		Return New Result(True)
	End Function
End Class

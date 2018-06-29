Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class StockReportDetailDAL
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
		query &= "FROM [StockReportDetail] "
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


					idOnDB.IncrementID("STOCKRPDTL", "D4")
					nextId = idOnDB

				Catch exception As Exception

					Debug.WriteLine("Get next stock report detail ID failed")
					Return New Result(False, "Get next stock report detail ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get next stock report detail ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(stockReportDetail As StockReportDetailDTO) As Result
		Dim query As String = String.Empty
		query &= "INSERT INTO [StockReportDetail] ([ID], [StockReportID], [BookID], [OpeningStock], [NewStock], [ClosingStock]) "
		query &= "VALUES (@ID, @StockReportID, @BookID, @OpeningStock, @NewStock, @ClosingStock)"

		Dim nextID = String.Empty
		Dim result As Result

		result = getNextId(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		stockReportDetail.ID = nextID

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query

					.Parameters.AddWithValue("@ID", stockReportDetail.ID)
					.Parameters.AddWithValue("@StockReportID", stockReportDetail.StockReportID)
					.Parameters.AddWithValue("@BookID", stockReportDetail.BookID)
					.Parameters.AddWithValue("@OpeningStock", stockReportDetail.OpeningStock)
					.Parameters.AddWithValue("@NewStock", stockReportDetail.NewStock)
					.Parameters.AddWithValue("@ClosingStock", stockReportDetail.ClosingStock)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch exception As Exception

					Debug.WriteLine("Insert stock report detail failed")
					Return New Result(False, "Insert stock report detail failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert stock report detail succeed")
		Return New Result(True)
	End Function

	Public Function insertAll(stockReportDetails As List(Of StockReportDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [StockReportDetail] ([ID], [StockReportID], [BookID], [OpeningStock], [NewStock], [ClosingStock]) "
		query &= "VALUES (@ID, @StockReportID, @BookID, @OpeningStock, @NewStock, @ClosingStock)"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				Try
					For Each stockReportDetail As StockReportDetailDTO In stockReportDetails
						conn.Close()
						comm.Parameters.Clear()

						Dim nextID = String.Empty
						Dim result As Result

						result = getNextId(nextID)
						If (result.FlagResult = False) Then
							Return result
						End If
						stockReportDetail.ID = nextID

						With comm
							.Connection = conn
							.CommandType = CommandType.Text
							.CommandText = query
							.Parameters.AddWithValue("@ID", stockReportDetail.ID)
							.Parameters.AddWithValue("@StockReportID", stockReportDetail.StockReportID)
							.Parameters.AddWithValue("@BookID", stockReportDetail.BookID)
							.Parameters.AddWithValue("@OpeningStock", stockReportDetail.OpeningStock)
							.Parameters.AddWithValue("@NewStock", stockReportDetail.NewStock)
							.Parameters.AddWithValue("@ClosingStock", stockReportDetail.ClosingStock)
						End With

						conn.Open()
						comm.ExecuteNonQuery()
					Next
				Catch exception As Exception

					Debug.WriteLine("Insert stock report details failed")
					Return New Result(False, "Insert stock report details failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert stock report details succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef stockReportDetails As List(Of StockReportDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [StockReportID], [BookID], [OpeningStock], [NewStock], [ClosingStock] "
		query &= "FROM [StockReportDetail] "
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
						stockReportDetails.Clear()
						While reader.Read()
							stockReportDetails.Add(New StockReportDetailDTO(reader("ID"), reader("StockReportID"), reader("BookID"), reader("OpeningStock"), reader("NewStock"), reader("ClosingStock")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get stock report details failed")
					Return New Result(False, "Get stock report details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get stock report details succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByStockReport(stockReportID As String, ByRef stockReportDetails As List(Of StockReportDetailDTO)) As Result
		Dim query As String = String.Empty
		query &= "SELECT [ID], [StockReportID], [BookID], [OpeningStock], [NewStock], [ClosingStock] "
		query &= "FROM [StockReportDetail] "
		query &= "WHERE [StockReportDetail].[StockReportID] = @StockReportID"
		query &= " ORDER BY [ID] DESC"


		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@StockReportID", stockReportID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						stockReportDetails.Clear()
						While reader.Read()
							stockReportDetails.Add(New StockReportDetailDTO(reader("ID"), reader("StockReportID"), reader("BookID"), reader("OpeningStock"), reader("NewStock"), reader("ClosingStock")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get stock report details failed")
					Return New Result(False, "Get stock report details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get stockReportDetails succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByBook(bookID As String, ByRef stockReportDetails As List(Of StockReportDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [StockReportID], [BookID], [OpeningStock], [NewStock], [ClosingStock] "
		query &= "FROM [stockReportDetail] "
		query &= "WHERE [stockReportDetail].[BookID] = @BookID"
		query &= " ORDER BY [ID] DESC"


		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@BookID", bookID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						stockReportDetails.Clear()
						While reader.Read()
							stockReportDetails.Add(New StockReportDetailDTO(reader("ID"), reader("StockReportID"), reader("BookID"), reader("OpeningStock"), reader("NewStock"), reader("ClosingStock")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get stock report details failed")
					Return New Result(False, "Get stock report details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get stock report details succeed")
		Return New Result(True)
	End Function

	Public Function update(stockReportDetail As StockReportDetailDTO) As Result

		Dim query As String = String.Empty
		query &= "UPDATE [StockReportDetail] SET "
		query &= "[StockReportID] = @StockReportID, "
		query &= "[BookID] = @BookID, "
		query &= "[OpeningStock] = @OpeningStock, "
		query &= "[NewStock] = @NewStock, "
		query &= "[ClosingStock] = @ClosingStock"
		query &= " WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", stockReportDetail.ID)
					.Parameters.AddWithValue("@StockReportID", stockReportDetail.StockReportID)
					.Parameters.AddWithValue("@BookID", stockReportDetail.BookID)
					.Parameters.AddWithValue("@OpeningStock", stockReportDetail.OpeningStock)
					.Parameters.AddWithValue("@NewStock", stockReportDetail.NewStock)
					.Parameters.AddWithValue("@ClosingStock", stockReportDetail.ClosingStock)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update stock report detail failed")
					Return New Result(False, "Update stock report detail failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update stock report detail succeed")
		Return New Result(True)
	End Function

	Public Function delete(stockReportDetailID As String) As Result
		Dim query As String = String.Empty
		query &= "DELETE FROM [StockReportDetail] "
		query &= "WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", stockReportDetailID)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Delete stock report detail failed")
					Return New Result(False, "Delete stock report detail failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Delete stock report detail succeed")
		Return New Result(True)
	End Function
End Class
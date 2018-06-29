Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class DebtReportDetailDAL
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
		query &= "FROM [DebtReportDetail] "
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


					idOnDB.IncrementID("DEBTRPDTL", "D4")
					nextId = idOnDB

				Catch exception As Exception

					Debug.WriteLine("Get next debt report detail ID failed")
					Return New Result(False, "Get next debt report detail ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get next debt report detail ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(debtReportDetail As DebtReportDetailDTO) As Result
		Dim query As String = String.Empty
		query &= "INSERT INTO [DebtReportDetail] ([ID], [DebtReportID], [CustomerID], [OpeningDebt], [NewDebt], [ClosingDebt]) "
		query &= "VALUES (@ID, @DebtReportID, @CustomerID, @OpeningDebt, @NewDebt, @ClosingDebt)"

		Dim nextID = String.Empty
		Dim result As Result

		result = getNextId(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		debtReportDetail.ID = nextID

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query

					.Parameters.AddWithValue("@ID", debtReportDetail.ID)
					.Parameters.AddWithValue("@DebtReportID", debtReportDetail.DebtReportID)
					.Parameters.AddWithValue("@CustomerID", debtReportDetail.CustomerID)
					.Parameters.AddWithValue("@OpeningDebt", debtReportDetail.OpeningDebt)
					.Parameters.AddWithValue("@NewDebt", debtReportDetail.NewDebt)
					.Parameters.AddWithValue("@ClosingDebt", debtReportDetail.ClosingDebt)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch exception As Exception

					Debug.WriteLine("Insert debt report detail failed")
					Return New Result(False, "Insert debt report detail failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert debt report detail succeed")
		Return New Result(True)
	End Function

	Public Function insertAll(debtReportDetails As List(Of DebtReportDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [DebtReportDetail] ([ID], [DebtReportID], [CustomerID], [OpeningDebt], [NewDebt], [ClosingDebt]) "
		query &= "VALUES (@ID, @DebtReportID, @CustomerID, @OpeningDebt, @NewDebt, @ClosingDebt)"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				Try
					For Each debtReportDetail As DebtReportDetailDTO In debtReportDetails
						conn.Close()
						comm.Parameters.Clear()

						Dim nextID = String.Empty
						Dim result As Result

						result = getNextId(nextID)
						If (result.FlagResult = False) Then
							Return result
						End If
						debtReportDetail.ID = nextID

						With comm
							.Connection = conn
							.CommandType = CommandType.Text
							.CommandText = query
							.Parameters.AddWithValue("@ID", debtReportDetail.ID)
							.Parameters.AddWithValue("@DebtReportID", debtReportDetail.DebtReportID)
							.Parameters.AddWithValue("@CustomerID", debtReportDetail.CustomerID)
							.Parameters.AddWithValue("@OpeningDebt", debtReportDetail.OpeningDebt)
							.Parameters.AddWithValue("@NewDebt", debtReportDetail.NewDebt)
							.Parameters.AddWithValue("@ClosingDebt", debtReportDetail.ClosingDebt)
						End With

						conn.Open()
						comm.ExecuteNonQuery()
					Next
				Catch exception As Exception

					Debug.WriteLine("Insert debt report details failed")
					Return New Result(False, "Insert debt report details failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert debt report details succeed")
		Return New Result(True)
	End Function

	Public Function select_ByID(debtReportDetailID As String, ByRef debtReportDetail As DebtReportDetailDTO) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [DebtReportID], [CustomerID], [OpeningDebt], [NewDebt], [ClosingDebt] "
		query &= "FROM [DebtReportDetail] "
		query &= "WHERE [DebtReportDetail].[ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", debtReportDetailID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						reader.Read()
						debtReportDetail = New DebtReportDetailDTO(reader("ID"), reader("DebtReportID"), reader("CustomerID"), reader("OpeningDebt"), reader("NewDebt"), reader("ClosingDebt"))
					End If

				Catch ex As Exception

					Debug.WriteLine("Get debt report detail failed")
					Return New Result(False, "Get debt report detail failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get debt report detail succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef debtReportDetails As List(Of DebtReportDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [DebtReportID], [CustomerID], [OpeningDebt], [NewDebt], [ClosingDebt] "
		query &= "FROM [DebtReportDetail] "
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
						debtReportDetails.Clear()
						While reader.Read()
							debtReportDetails.Add(New DebtReportDetailDTO(reader("ID"), reader("DebtReportID"), reader("CustomerID"), reader("OpeningDebt"), reader("NewDebt"), reader("ClosingDebt")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get debt report details failed")
					Return New Result(False, "Get debt report details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get debt report details succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByDebtReport(debtReportID As String, ByRef debtReportDetails As List(Of DebtReportDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [DebtReportID], [CustomerID], [OpeningDebt], [NewDebt], [ClosingDebt] "
		query &= "FROM [DebtReportDetail] "
		query &= "WHERE [DebtReportDetail].[DebtReportID] = @DebtReportID"
		query &= " ORDER BY [ID] DESC"


		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@DebtReportID", debtReportID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						debtReportDetails.Clear()
						While reader.Read()
							debtReportDetails.Add(New DebtReportDetailDTO(reader("ID"), reader("DebtReportID"), reader("CustomerID"), reader("OpeningDebt"), reader("NewDebt"), reader("ClosingDebt")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get debt report details failed")
					Return New Result(False, "Get debt report details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get debtReportDetails succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByCustomer(customerID As String, ByRef debtReportDetails As List(Of DebtReportDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [DebtReportID], [CustomerID], [OpeningDebt], [NewDebt], [ClosingDebt] "
		query &= "FROM [DebtReportDetail] "
		query &= "WHERE [DebtReportDetail].[CustomerID] = @CustomerID"
		query &= " ORDER BY [ID] DESC"


		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@CustomerID", customerID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						debtReportDetails.Clear()
						While reader.Read()
							debtReportDetails.Add(New DebtReportDetailDTO(reader("ID"), reader("DebtReportID"), reader("CustomerID"), reader("OpeningDebt"), reader("NewDebt"), reader("ClosingDebt")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get debt report details failed")
					Return New Result(False, "Get debt report details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get debt report details succeed")
		Return New Result(True)
	End Function

	Public Function update(debtReportDetail As DebtReportDetailDTO) As Result

		Dim query As String = String.Empty
		query &= "UPDATE [DebtReportDetail] SET "
		query &= "[DebtReportID] = @DebtReportID, "
		query &= "[CustomerID] = @CustomerID, "
		query &= "[OpeningDebt] = @OpeningDebt, "
		query &= "[NewDebt] = @NewDebt, "
		query &= "[ClosingDebt] = @ClosingDebt"
		query &= " WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", debtReportDetail.ID)
					.Parameters.AddWithValue("@DebtReportID", debtReportDetail.DebtReportID)
					.Parameters.AddWithValue("@CustomerID", debtReportDetail.CustomerID)
					.Parameters.AddWithValue("@OpeningDebt", debtReportDetail.OpeningDebt)
					.Parameters.AddWithValue("@NewDebt", debtReportDetail.NewDebt)
					.Parameters.AddWithValue("@ClosingDebt", debtReportDetail.ClosingDebt)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update debt report detail failed")
					Return New Result(False, "Update debt report detail failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update debt report detail succeed")
		Return New Result(True)
	End Function

	Public Function delete(debtReportDetailID As String) As Result
		Dim query As String = String.Empty
		query &= "DELETE FROM [DebtReportDetail] "
		query &= "WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", debtReportDetailID)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Delete debt report detail failed")
					Return New Result(False, "Delete debt report detail failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Delete debt report detail succeed")
		Return New Result(True)
	End Function
End Class

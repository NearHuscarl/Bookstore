Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class ReceiptDAL
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
		query &= "FROM [Receipt] "
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


					idOnDB.IncrementID("RECEIPT", "D4")
					nextId = idOnDB

				Catch exception As Exception

					Debug.WriteLine("Get next receipt ID failed")
					Return New Result(False, "Get next receipt ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get next receipt ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(receipt As ReceiptDTO) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [Receipt] ([ID], [CustomerID], [CollectedDate], [CollectedAmount]) "
		query &= "VALUES (@ID, @CustomerID, @CollectedDate, @CollectedAmount)"

		Dim nextID = String.Empty
		Dim result As Result

		result = getNextId(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		receipt.ID = nextID

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query

					.Parameters.AddWithValue("@ID", receipt.ID)
					.Parameters.AddWithValue("@CustomerID", receipt.CustomerID)
					.Parameters.AddWithValue("@CollectedDate", receipt.CollectedDate)
					.Parameters.AddWithValue("@CollectedAmount", receipt.CollectedAmount)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch exception As Exception

					Debug.WriteLine("Insert receipt failed")
					Return New Result(False, "Insert receipt failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert receipt succeed")
		Return New Result(True)
	End Function

	Public Function select_ByID(receiptID As String, ByRef receipt As ReceiptDTO) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [CustomerID], [CollectedDate], [CollectedAmount] "
		query &= "FROM [Receipt] "
		query &= "WHERE [Receipt].[ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", receiptID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						reader.Read()
						receipt = New ReceiptDTO(reader("ID"), reader("CustomerID"), reader("CollectedDate"), reader("CollectAmount"))
					End If

				Catch ex As Exception

					Debug.WriteLine("Get receipt failed")
					Return New Result(False, "Get receipt failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get receipt succeed")
		Return New Result(True)
	End Function


	Public Function selectAll(ByRef receipts As List(Of ReceiptDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [CustomerID], [CollectedDate], [CollectedAmount] "
		query &= "FROM [Receipt] "
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
						receipts.Clear()
						While reader.Read()
							receipts.Add(New ReceiptDTO(reader("ID"), reader("CustomerID"), reader("CollectedDate"), reader("CollectAmount")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get receipts failed")
					Return New Result(False, "Get receipts failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get receipts succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByDate(collectedDate As DateTime, ByRef receipts As List(Of ReceiptDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [CustomerID], [CollectedDate], [CollectedAmount] "
		query &= "FROM [Receipt] "
		query &= "WHERE [Receipt].[CollectedDate] = @CollectedDate"
		query &= " ORDER BY [ID] DESC"


		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@CollectedDate", collectedDate)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						receipts.Clear()
						While reader.Read()
							receipts.Add(New ReceiptDTO(reader("ID"), reader("CustomerID"), reader("CollectedDate"), reader("CollectAmount")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get receipts failed")
					Return New Result(False, "Get receipts failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get receipts succeed")
		Return New Result(True)
	End Function
	Public Function selectAll_ByCustomer(customerID As String, ByRef receipts As List(Of ReceiptDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [CustomerID], [CollectedDate], [CollectedAmount] "
		query &= "FROM [Receipt] "
		query &= "WHERE [Receipt].[CustomerID] = @CustomerID"
		query &= " ORDER BY [ID] DESC"


		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@CustomerID", CustomerID)
				End With

				Try
					conn.Open()

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						receipts.Clear()
						While reader.Read()
							receipts.Add(New ReceiptDTO(reader("ID"), reader("CustomerID"), reader("CustomerID"), reader("CollectAmount")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get receipts failed")
					Return New Result(False, "Get receipts failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get receipts succeed")
		Return New Result(True)
	End Function

	Public Function update(receipt As ReceiptDTO) As Result

		Dim query As String = String.Empty
		query &= "UPDATE [Receipt] SET "
		query &= "[CustomerID] = @CustomerID, "
		query &= "[CollectedDate] = @CollectedDate, "
		query &= "[CollectedAmount] = @CollectedAmount, "
		query &= "WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", receipt.ID)
					.Parameters.AddWithValue("@CustomerID", receipt.CustomerID)
					.Parameters.AddWithValue("@CollectedDate", receipt.CollectedDate)
					.Parameters.AddWithValue("@CollectedAmount", receipt.CollectedAmount)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update receipt failed")
					Return New Result(False, "Update receipt failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update receipt succeed")
		Return New Result(True)
	End Function

	Public Function delete(receiptID As String) As Result

		Dim query As String = String.Empty
		query &= "DELETE FROM [Receipt] "
		query &= "WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", receiptID)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Delete receipt failed")
					Return New Result(False, "Delete receipt failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Delete receipt succeed")
		Return New Result(True)
	End Function
End Class

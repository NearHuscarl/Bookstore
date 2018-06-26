Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports BookstoreManagement.DTO
Imports Utility

Public Class InvoiceDetailDAL
	Private connectionStr As String

	Public Sub New()
		connectionStr = ConfigurationManager.AppSettings("ConnectionStr")
	End Sub

	Public Sub New(connectionStr As String)
		Me.connectionStr = connectionStr
	End Sub

	Public Function getNextId(ByRef nextId As Integer) As Result

		Dim query As String = String.Empty
		query &= " SELECT TOP 1 [ID] "
		query &= " FROM [InvoiceDetail] "
		query &= " ORDER BY [ID] DESC "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
				End With

				Try
					conn.Open()

					Dim invoiceDetail As SqlDataReader
					Dim idOnDB As String

					invoiceDetail = comm.ExecuteReader()
					idOnDB = Nothing

					If invoiceDetail.HasRows = True Then
						While invoiceDetail.Read()
							idOnDB = invoiceDetail("ID")
						End While
					End If

					idOnDB.IncrementID("INVOICEDETAIL", "D7")
					nextId = idOnDB

				Catch exception As Exception

					Debug.WriteLine("Get next invoice detail ID failed")
					Return New Result(False, "Get next invoice detail ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get next invoice detail ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(invoiceDetail As InvoiceDetailDTO) As Result

		Dim query As String = String.Empty
		query &= " INSERT INTO [InvoiceDetail] ([ID], [InvoiceID], [BookID], [Amount], [SalesPrice]) "
		query &= " VALUES (@ID, @InvoiceID, @BookID, @Amount, @SalesPrice) "

		Dim nextID = String.Empty
		Dim result As Result

		result = getNextId(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		invoiceDetail.ID = nextID

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query

					.Parameters.AddWithValue("@ID", invoiceDetail.ID)
					.Parameters.AddWithValue("@InvoiceID", invoiceDetail.InvoiceID)
					.Parameters.AddWithValue("@BookID", invoiceDetail.BookID)
					.Parameters.AddWithValue("@Amount", invoiceDetail.Amount)
					.Parameters.AddWithValue("@SalesPrice", invoiceDetail.SalesPrice)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch exception As Exception

					Debug.WriteLine("Insert invoice detail failed")
					Return New Result(False, "Insert invoice detail failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert invoice detail succeed")
		Return New Result(True)
	End Function

	Public Function insertAll(invoiceDetails As List(Of InvoiceDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= " INSERT INTO [InvoiceDetail] ([ID], [InvoiceID], [BookID], [Amount], [SalesPrice]) "
		query &= " VALUES (@ID, @InvoiceID, @BookID, @Amount, @SalesPrice) "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				Try
					For Each invoiceDetail As InvoiceDetailDTO In invoiceDetails
						conn.Close()

						Dim nextID = String.Empty
						Dim result As Result

						result = getNextId(nextID)
						If (result.FlagResult = False) Then
							Return result
						End If
						invoiceDetail.ID = nextID

						With comm
							.Connection = conn
							.CommandType = CommandType.Text
							.CommandText = query
							.Parameters.AddWithValue("@ID", invoiceDetail.ID)
							.Parameters.AddWithValue("@InvoiceID", invoiceDetail.InvoiceID)
							.Parameters.AddWithValue("@BookID", invoiceDetail.BookID)
							.Parameters.AddWithValue("@Amount", invoiceDetail.Amount)
							.Parameters.AddWithValue("@SalesPrice", invoiceDetail.SalesPrice)
						End With

						conn.Open()
						comm.ExecuteNonQuery()
					Next
				Catch exception As Exception

					Debug.WriteLine("Insert invoice details failed")
					Return New Result(False, "Insert invoice details failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert invoice details succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef invoiceDetails As List(Of InvoiceDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [InvoiceID], [BookID], [Amount], [SalesPrice] "
		query &= " FROM [InvoiceDetail] "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
				End With

				Try
					conn.Open()

					Dim invoiceDetail As SqlDataReader
					invoiceDetail = comm.ExecuteReader()

					If invoiceDetail.HasRows = True Then
						invoiceDetails.Clear()
						While invoiceDetail.Read()
							invoiceDetails.Add(New InvoiceDetailDTO(invoiceDetail("ID"), invoiceDetail("InvoiceID"), invoiceDetail("BookID"), invoiceDetail("Amount"), invoiceDetail("SalesPrice")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get invoice details failed")
					Return New Result(False, "Get invoice details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get invoice details succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByInvoiceID(invoiceID As String, ByRef invoiceDetails As List(Of InvoiceDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [InvoiceID], [BookID], [Amount], [SalesPrice] "
		query &= " FROM [InvoiceDetail]"
		query &= " WHERE [InvoiceDetail].[InvoiceID] = @InvoiceID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@InvoiceID", invoiceID)
				End With

				Try
					conn.Open()

					Dim invoiceDetail As SqlDataReader
					invoiceDetail = comm.ExecuteReader()

					If invoiceDetail.HasRows = True Then
						invoiceDetails.Clear()
						While invoiceDetail.Read()
							invoiceDetails.Add(New InvoiceDetailDTO(invoiceDetail("ID"), invoiceDetail("InvoiceID"), invoiceDetail("BookID"), invoiceDetail("Amount"), invoiceDetail("SalesPrice")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get invoice details failed")
					Return New Result(False, "Get invoice details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get invoice details succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByBookID(bookID As String, ByRef invoiceDetails As List(Of InvoiceDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [InvoiceID], [BookID], [Amount], [SalesPrice] "
		query &= " FROM [InvoiceDetail]"
		query &= " WHERE [InvoiceDetail].[BookID] = @BookID"

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

					Dim invoiceDetail As SqlDataReader
					invoiceDetail = comm.ExecuteReader()

					If invoiceDetail.HasRows = True Then
						invoiceDetails.Clear()
						While invoiceDetail.Read()
							invoiceDetails.Add(New InvoiceDetailDTO(invoiceDetail("ID"), invoiceDetail("InvoiceID"), invoiceDetail("BookID"), invoiceDetail("Amount"), invoiceDetail("SalesPrice")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get invoice details failed")
					Return New Result(False, "Get invoice details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get invoice details succeed")
		Return New Result(True)
	End Function

	Public Function update(invoiceDetail As InvoiceDetailDTO) As Result

		Dim query As String = String.Empty
		query &= " UPDATE [InvoiceDetail] SET "
		query &= " [InvoiceID] = @InvoiceID , "
		query &= " [BookID] = @BookID , "
		query &= " [Amount] = @Amount , "
		query &= " [SalesPrice] = @SalesPrice "
		query &= " WHERE [ID] = @ID "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", invoiceDetail.ID)
					.Parameters.AddWithValue("@InvoiceID", invoiceDetail.InvoiceID)
					.Parameters.AddWithValue("@BookID", invoiceDetail.BookID)
					.Parameters.AddWithValue("@Amount", invoiceDetail.Amount)
					.Parameters.AddWithValue("@SalesPrice", invoiceDetail.SalesPrice)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update invoice detail failed")
					Return New Result(False, "Update invoice detail failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update invoice detail succeed")
		Return New Result(True)
	End Function

	Public Function delete(invoiceDetailID As String) As Result

		Dim query As String = String.Empty
		query &= " DELETE FROM [InvoiceDetail] "
		query &= " WHERE [ID] = @ID "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", invoiceDetailID)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Delete invoice detail failed")
					Return New Result(False, "Delete invoice detail failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Delete invoice detail succeed")
		Return New Result(True)
	End Function
End Class

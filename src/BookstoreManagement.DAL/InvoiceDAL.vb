Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class InvoiceDAL
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
		query &= " FROM [Invoice] "
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

					Dim invoice As SqlDataReader
					Dim idOnDB As Integer

					invoice = comm.ExecuteReader()
					idOnDB = Nothing

					If invoice.HasRows = True Then
						While invoice.Read()
							idOnDB = invoice("ID")
						End While
					End If

					nextId = idOnDB + 1 'new ID = current ID + 1

				Catch exception As Exception
					nextId = 1

					Debug.WriteLine("Get next invoice ID failed")
					Return New Result(False, "Get next invoice ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get next invoice ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(invoice As InvoiceDTO) As Result

		Dim query As String = String.Empty
		query &= " INSERT INTO [Invoice] ([ID], [CustomerID], [InvoiceDate], [Amount], [DebtBeforeSales]) "
		query &= " VALUES (@ID, @CustomerID, @InvoiceDate, @Amount, @DebtBeforeSales) "

		Dim nextID = 0
		Dim result As Result

		result = getNextId(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		invoice.ID = nextID

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query

					.Parameters.AddWithValue("@ID", invoice.ID)
					.Parameters.AddWithValue("@CustomerID", invoice.CustomerID)
					.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate)
					.Parameters.AddWithValue("@Amount", invoice.Amount)
					.Parameters.AddWithValue("@DebtBeforeSales", invoice.DebtBeforeSales)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch exception As Exception

					Debug.WriteLine("Insert invoice failed")
					Return New Result(False, "Insert invoice failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert invoice succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef invoices As List(Of InvoiceDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [CustomerID], [InvoiceDate], [Amount], [DebtBeforeSales] "
		query &= " FROM [Invoice] "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
				End With

				Try
					conn.Open()

					Dim invoice As SqlDataReader
					invoice = comm.ExecuteReader()

					If invoice.HasRows = True Then
						invoices.Clear()
						While invoice.Read()
							invoices.Add(New InvoiceDTO(invoice("ID"), invoice("CustomerID"), invoice("InvoiceDate"), invoice("Amount"), invoice("DebtBeforeSales")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get invoices failed")
					Return New Result(False, "Get invoices failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get invoices succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByInvoiceDate(invoiceDate As DateTime, ByRef invoices As List(Of InvoiceDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [CustomerID], [InvoiceDate], [Amount], [DebtBeforeSales] "
		query &= " FROM [Invoice]"
		query &= " WHERE [Invoice].[InvoiceDate] = @InvoiceDate"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@InvoiceDate", invoiceDate)
				End With

				Try
					conn.Open()

					Dim invoice As SqlDataReader
					invoice = comm.ExecuteReader()

					If invoice.HasRows = True Then
						invoices.Clear()
						While invoice.Read()
							invoices.Add(New InvoiceDTO(invoice("ID"), invoice("CustomerID"), invoice("InvoiceDate"), invoice("Amount"), invoice("DebtBeforeSales")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get invoices failed")
					Return New Result(False, "Get invoices failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get invoices succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByCustomerID(customerID As String, ByRef invoices As List(Of InvoiceDTO)) As Result

		Dim query As String = String.Empty
		query &= " SELECT [ID], [CustomerID], [InvoiceDate], [Amount], [DebtBeforeSales] "
		query &= " FROM [Invoice]"
		query &= " WHERE [Invoice].[CustomerID] = @CustomerID"

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

					Dim invoice As SqlDataReader
					invoice = comm.ExecuteReader()

					If invoice.HasRows = True Then
						invoices.Clear()
						While invoice.Read()
							invoices.Add(New InvoiceDTO(invoice("ID"), invoice("CustomerID"), invoice("InvoiceDate"), invoice("Amount"), invoice("DebtBeforeSales")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get invoices failed")
					Return New Result(False, "Get invoices failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get invoices succeed")
		Return New Result(True)
	End Function

	Public Function update(invoice As InvoiceDTO) As Result

		Dim query As String = String.Empty
		query &= " UPDATE [Invoice] SET "
		query &= " [CustomerID] = @CustomerID ,"
		query &= " [InvoiceDate] = @InvoiceDate ,"
		query &= " [Amount] = @Amount ,"
		query &= " [DebtBeforeSales] = @DebtBeforeSales "
		query &= " WHERE [ID] = @ID "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", invoice.ID)
					.Parameters.AddWithValue("@CustomerID", invoice.CustomerID)
					.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate)
					.Parameters.AddWithValue("@Amount", invoice.Amount)
					.Parameters.AddWithValue("@DebtBeforeSales", invoice.DebtBeforeSales)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update invoice failed")
					Return New Result(False, "Update invoice failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update invoice succeed")
		Return New Result(True)
	End Function

	Public Function delete(invoiceID As String) As Result

		Dim query As String = String.Empty
		query &= " DELETE FROM [Invoice] "
		query &= " WHERE [ID] = @ID "

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", invoiceID)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Delete invoice failed")
					Return New Result(False, "Delete invoice failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Delete invoice succeed")
		Return New Result(True)
	End Function
End Class

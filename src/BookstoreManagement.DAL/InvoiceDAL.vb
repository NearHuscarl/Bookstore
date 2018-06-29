Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
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

	Public Function getNextId(ByRef nextId As String) As Result

		Dim query As String = String.Empty
		query &= "SELECT TOP 1 [ID] "
		query &= "FROM [Invoice] "
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

					idOnDB.IncrementID("INVOICE", "D4")
					nextId = idOnDB

				Catch exception As Exception

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
		query &= "INSERT INTO [Invoice] ([ID], [CustomerID], [InvoiceDate]) "
		query &= "VALUES (@ID, @CustomerID, @InvoiceDate)"

		Dim nextID = String.Empty
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

	Public Function select_ByID(invoiceID As String, ByRef invoice As InvoiceDTO) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [CustomerID], [InvoiceDate] "
		query &= "FROM [Invoice] "
		query &= "WHERE [Invoice].[ID] = @ID"

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

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						reader.Read()
						invoice = New InvoiceDTO(reader("ID"), reader("CustomerID"), reader("InvoiceDate"))
					End If

				Catch ex As Exception

					Debug.WriteLine("Get invoice failed")
					Return New Result(False, "Get invoice failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get invoice succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef invoices As List(Of InvoiceDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [CustomerID], [InvoiceDate] "
		query &= "FROM [Invoice] "
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
						invoices.Clear()
						While reader.Read()
							invoices.Add(New InvoiceDTO(reader("ID"), reader("CustomerID"), reader("InvoiceDate")))
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

	Public Function selectAll_ByDate(invoiceDate As DateTime, ByRef invoices As List(Of InvoiceDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [CustomerID], [InvoiceDate] "
		query &= "FROM [Invoice] "
		query &= "WHERE [Invoice].[InvoiceDate] = @InvoiceDate"
		query &= " ORDER BY [ID] DESC"

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

					Dim reader As SqlDataReader
					reader = comm.ExecuteReader()

					If reader.HasRows = True Then
						invoices.Clear()
						While reader.Read()
							invoices.Add(New InvoiceDTO(reader("ID"), reader("CustomerID"), reader("InvoiceDate")))
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

	Public Function selectAll_ByCustomer(customerID As String, ByRef invoices As List(Of InvoiceDTO)) As Result

		Dim query As String = String.Empty
		query &= "SELECT [ID], [CustomerID], [InvoiceDate] "
		query &= "FROM [Invoice] "
		query &= "WHERE [Invoice].[CustomerID] = @CustomerID"
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
						invoices.Clear()
						While reader.Read()
							invoices.Add(New InvoiceDTO(reader("ID"), reader("CustomerID"), reader("InvoiceDate")))
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
		query &= "UPDATE [Invoice] SET "
		query &= "[CustomerID] = @CustomerID, "
		query &= "[InvoiceDate] = @InvoiceDate"
		query &= " WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", invoice.ID)
					.Parameters.AddWithValue("@CustomerID", invoice.CustomerID)
					.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate)
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
		query &= "DELETE FROM [Invoice] "
		query &= "WHERE [ID] = @ID"

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

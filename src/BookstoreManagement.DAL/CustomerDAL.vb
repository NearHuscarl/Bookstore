Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class CustomerDAL
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
		query &= "FROM [Customer] "
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

					Dim customer As SqlDataReader
					Dim idOnDB As String

					customer = comm.ExecuteReader()
					idOnDB = Nothing

					If customer.HasRows = True Then
						While customer.Read()
							idOnDB = customer("ID")
						End While
					End If

					idOnDB.IncrementID("CUSTOMER", "D4")
					nextId = idOnDB

				Catch exception As Exception

					Debug.WriteLine("Get next customer ID failed")
					Return New Result(False, "Get next customer ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get next customer ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(customer As CustomerDTO) As Result
		Dim query As String = String.Empty

		query &= "INSERT INTO [Customer] ([ID], [Name], [Address], [Email], [PhoneNumber], [CurrentDebt]) "
		query &= "VALUES (@ID, @Name, @Address, @Email, @PhoneNumber, @CurrentDebt)"

		Dim nextID = String.Empty
		Dim result As Result

		result = getNextId(nextID)
		If (result.FlagResult = False) Then
			Return result
		End If
		customer.ID = nextID

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query

					.Parameters.AddWithValue("@ID", customer.ID)
					.Parameters.AddWithValue("@Name", customer.Name)
					.Parameters.AddWithValue("@Address", customer.Address)
					.Parameters.AddWithValue("@Email", customer.Email)
					.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber)
					.Parameters.AddWithValue("@CurrentDebt", customer.CurrentDebt)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch exception As Exception

					Debug.WriteLine("Insert customer failed")
					Return New Result(False, "insert customer failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert customer succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef customers As List(Of CustomerDTO)) As Result
		Dim query As String = String.Empty
		query &= "SELECT [ID], [Name], [Address], [Email], [PhoneNumber], [CurrentDebt] "
		query &= "FROM [Customer] "
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

					Dim customer As SqlDataReader
					customer = comm.ExecuteReader()

					If customer.HasRows = True Then
						customers.Clear()
						While customer.Read()
							customers.Add(New CustomerDTO(customer("ID"), customer("Name"), customer("Address"), customer("Email"), customer("PhoneNumber"), customer("CurrentDebt")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get customers failed")
					Return New Result(False, "Get customers failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get customers succeed")
		Return New Result(True)
	End Function

	Public Function update(customer As CustomerDTO) As Result
		Dim query As String = String.Empty
		query &= "UPDATE [Customer] SET "
		query &= "[Name] = @Name, "
		query &= "[Address] = @Address, "
		query &= "[Email] = @Email, "
		query &= "[PhoneNumber] = @PhoneNumber, "
		query &= "[CurrentDebt] = @CurrentDebt"
		query &= " WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", customer.ID)
					.Parameters.AddWithValue("@Name", customer.Name)
					.Parameters.AddWithValue("@Address", customer.Address)
					.Parameters.AddWithValue("@Email", customer.Email)
					.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber)
					.Parameters.AddWithValue("@CurrentDebt", customer.CurrentDebt)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update customer failed")
					Return New Result(False, "Update customer failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update customer succeed")
		Return New Result(True)
	End Function

	Public Function delete(customerID As String) As Result

		Dim query As String = String.Empty
		query &= "DELETE FROM [Customer] "
		query &= "WHERE [ID] = @ID"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				With comm
					.Connection = conn
					.CommandType = CommandType.Text
					.CommandText = query
					.Parameters.AddWithValue("@ID", customerID)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Delete customer failed")
					Return New Result(False, "Delete customer failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Delete customer succeed")
		Return New Result(True)
	End Function
End Class

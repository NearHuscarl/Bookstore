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
		query &= " SELECT TOP 1 [ID] "
		query &= " FROM [Receipt] "
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

					Dim Receipt As SqlDataReader
					Dim idOnDB As String

					Receipt = comm.ExecuteReader()
					idOnDB = Nothing

					If Receipt.HasRows = True Then
						While Receipt.Read()
							idOnDB = Receipt("ID")
						End While
					End If


					idOnDB.IncrementID("RECEIPT", "D8")
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
		query &= " INSERT INTO [Receipt] ([ID], [CustomerID], [) "
		query &= " VALUES (@ID, @Name) "

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
					.Parameters.AddWithValue("@Name", receipt.Name)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch exception As Exception

					Debug.WriteLine("Insert Receipt failed")
					Return New Result(False, "Insert Receipt failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert Receipt succeed")
		Return New Result(True)
	End Function

	Public Function sellectALL(ByRef receipts As List(Of ReceiptDTO)) As Result
		Return New Result(True)
	End Function

	Public Function sellectALL_ByDate(dateCollected As DateTime, ByRef receipts As List(Of ReceiptDTO)) As Result
		Return New Result(True)
	End Function
	Public Function sellectALL_ByCustomer(customerID As String, ByRef receipts As List(Of ReceiptDTO)) As Result
		Return New Result(True)
	End Function

	Public Function update(receipt As ReceiptDTO) As Result
		Return New Result(True)
	End Function

	Public Function delete(receiptID As String) As Result
		Return New Result(True)
	End Function
End Class

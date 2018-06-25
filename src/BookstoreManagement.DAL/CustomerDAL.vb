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

	Public Function getNextId(ByRef nextId As Integer) As Result
      Dim query As String = String.Empty

      query &= "SELECT TOP 1 [ID]"
      query &= "FROM [Customer]"
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
               Dim idOnDB As Integer

               customer = comm.ExecuteReader()
               idOnDB = Nothing

               If customer.HasRows = True Then
                  While customer.Read()
                     idOnDB = customer("ID")
                  End While
               End If

               nextId = idOnDB + 1 'new ID = current ID + 1

            Catch exception As Exception
               conn.Close()

               nextId = 1

               Console.WriteLine("Get next Customer ID failed") 'for debug

               Return New Result(False, "Get next Customer ID failed", exception.StackTrace)

            End Try

         End Using

      End Using

      Console.WriteLine("Get next Customer ID succeed") 'for debug
      Return New Result(True)
   End Function

	Public Function insert(customer As CustomerDTO) As Result
      Dim query As String = String.Empty

      query &= "INSERT INTO [Customer] ([ID], [Name], [Address], [Email], [PhoneNumber], [CurrentDebt])"
      query &= "VALUES (@ID, @Name, @Address, @Email, @PhoneNumber, @CurrentDebt)"

      Dim nextID = 0
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
               conn.Close()
               Console.WriteLine("Customer insert failed") 'for debug
               Return New Result(False, "Customer insert failed", exception.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Customer insert succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function sellectALL(ByRef customers As List(Of CustomerDTO)) As Result
		Return New Result(True)
	End Function

	Public Function update(customer As CustomerDTO) As Result
		Return New Result(True)
	End Function

	Public Function delete(customerID As String) As Result
		Return New Result(True)
	End Function
End Class

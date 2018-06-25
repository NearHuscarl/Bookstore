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

      query &= "SELECT TOP 1 [ID]"
      query &= "FROM [Invoice]"
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
               Dim idOnDB As Integer

               reader = comm.ExecuteReader()
               idOnDB = Nothing

               If reader.HasRows = True Then
                  While reader.Read()
                     idOnDB = reader("ID")
                  End While
               End If

               nextId = idOnDB + 1 'new ID = current ID + 1

            Catch exception As Exception
               conn.Close()

               nextId = 1

               Console.WriteLine("Get Next Reader ID Failed") 'for debug

               Return New Result(False, "Get Next Reader ID Failed", exception.StackTrace)

            End Try

         End Using

      End Using

      Return New Result(True)

   End Function

	Public Function insert(invoice As InvoiceDTO) As Result
		Return New Result(True)
	End Function

	Public Function sellectALL(ByRef invoices As List(Of InvoiceDTO)) As Result
		Return New Result(True)
	End Function

	Public Function sellectALL_ByDate(dateCreated As DateTime, ByRef invoices As List(Of InvoiceDTO)) As Result
		Return New Result(True)
	End Function
	Public Function sellectALL_ByCustomer(customerID As String, ByRef invoices As List(Of InvoiceDTO)) As Result
		Return New Result(True)
	End Function

	Public Function update(invoice As InvoiceDTO) As Result
		Return New Result(True)
	End Function

	Public Function delete(invoiceID As String) As Result
		Return New Result(True)
	End Function
End Class

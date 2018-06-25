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

	Public Function getNextId(ByRef nextId As Integer) As Result
      Dim query As String = String.Empty

      query &= "SELECT TOP 1 [ID]"
      query &= "FROM [StockReportDetail]"
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

	Public Function insert(stockReportDetail As StockReportDetailDTO) As Result
		Return New Result(True)
	End Function

	Public Function insertAll(stockReportDetails As List(Of StockReportDetailDTO)) As Result
		Return New Result(True)
	End Function

	Public Function sellectALL(ByRef stockReportDetails As List(Of StockReportDetailDTO)) As Result
		Return New Result(True)
	End Function

	Public Function sellectALL_ByStockReport(stockReportID As String, ByRef stockReportDetails As List(Of StockReportDetailDTO)) As Result
		Return New Result(True)
	End Function

	Public Function sellectALL_ByBook(bookID As String, ByRef stockReportDetails As List(Of StockReportDetailDTO)) As Result
		Return New Result(True)
	End Function

	Public Function update(stockReportDetail As StockReportDetailDTO) As Result
      Return New Result(True)
   End Function

   Public Function delete(stockReportDetailID As String) As Result
      Return New Result(True)
   End Function
End Class
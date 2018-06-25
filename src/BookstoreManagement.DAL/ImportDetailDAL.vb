Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class ImportDetailDAL
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
      query &= " FROM [ImportDetail] "
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

               Dim reader As SqlDataReader
               Dim idOnDB As Integer

               reader = comm.ExecuteReader()
               idOnDB = Nothing

               If reader.HasRows = True Then
                  While reader.Read()
                     idOnDB = reader("ID")
                  End While
               End If

               nextId = idOnDB + 1 ' new ID = current ID + 1

            Catch exception As Exception
               conn.Close()

               nextId = 1

               Console.WriteLine("Get next Import Detail ID Failed") 'for debug
               Return New Result(False, "Get next Import Detail ID Failed", exception.StackTrace)

            End Try

         End Using

      End Using

      Console.WriteLine("Get next Import Detail ID succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function insert(importDetail As ImportDetailDTO) As Result

      Dim query As String = String.Empty
      query &= " INSERT INTO [ImportDetail] ([ID], [ImportID], [BookID], [ImportAmount], [CurrentAmount], [ImportPrice]) "
      query &= " VALUES (@ID, @ImportID, @BookID, @ImportAmount, @CurrentAmount, @ImportPrice) "

      Dim nextID = 0
      Dim result As Result

      result = getNextId(nextID)
      If (result.FlagResult = False) Then
         Return result
      End If
      importDetail.ID = nextID

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
               .Parameters.AddWithValue("@ID", importDetail.ID)
               .Parameters.AddWithValue("@ImportID", importDetail.ImportID)
               .Parameters.AddWithValue("@BookID", importDetail.BookID)
               .Parameters.AddWithValue("@ImportAmount", importDetail.ImportAmount)
               .Parameters.AddWithValue("@CurrentAmount", importDetail.CurrentAmount)
               .Parameters.AddWithValue("@ImportPrice", importDetail.ImportPrice)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()
            Catch exception As Exception
               conn.Close()

               Console.WriteLine("Insert Import Detail failed") 'for debug
               Return New Result(False, "Insert Import Detail failed", exception.StackTrace)
            End Try

         End Using

      End Using


      Console.WriteLine("Insert Import Detail succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function insertAll(importDetails As List(Of ImportDetailDTO)) As Result

      Dim query As String = String.Empty
      query &= " INSERT INTO [ImportDetail] ([ID], [ImportID], [BookID], [ImportAmount], [CurrentAmount], [ImportPrice]) "
      query &= " VALUES (@ID, @ImportID, @BookID, @ImportAmount, @CurrentAmount, @ImportPrice) "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            Try
               For Each importDetail As ImportDetailDTO In importDetails
                  Dim nextID = 0
                  Dim result As Result

                  result = getNextId(nextID)
                  If (result.FlagResult = False) Then
                     Return result
                  End If
                  importDetail.ID = nextID

                  With comm
                     .Connection = conn
                     .CommandType = CommandType.Text
                     .CommandText = query
                     .Parameters.AddWithValue("@ID", importDetail.ID)
                     .Parameters.AddWithValue("@ImportID", importDetail.ImportID)
                     .Parameters.AddWithValue("@BookID", importDetail.BookID)
                     .Parameters.AddWithValue("@ImportAmount", importDetail.ImportAmount)
                     .Parameters.AddWithValue("@CurrentAmount", importDetail.CurrentAmount)
                     .Parameters.AddWithValue("@ImportPrice", importDetail.ImportPrice)
                  End With

                  conn.Open()
                  comm.ExecuteNonQuery()
               Next
            Catch exception As Exception
               conn.Close()

               Console.WriteLine("Insert Import Details failed") 'for debug
               Return New Result(False, "Insert Import Details failed", exception.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Insert Import Details succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function selectAll(ByRef importDetails As List(Of ImportDetailDTO))

      Dim query As String = String.Empty
      query &= " SELECT [ID], [ImportID], [BookID], [ImportAmount], [CurrentAmount], [ImportPrice] "
      query &= " FROM [ImportDetail] "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
            End With

            Try
               conn.Open()

               Dim importDetail As SqlDataReader
               importDetail = comm.ExecuteReader()

               If importDetail.HasRows = True Then
                  importDetails.Clear()
                  While importDetail.Read()
                     importDetails.Add(New ImportDetailDTO(importDetail("ID"), importDetail("ImportID"), importDetail("BookID"), importDetail("ImportAmount"), importDetail("CurrentAmount"), importDetail("ImportPrice")))
                  End While
               End If

            Catch ex As Exception
               conn.Close()

               Console.WriteLine("Get Import Details failed") 'for debug
               Return New Result(False, "Get Import Details failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Get Import Details succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function selectAll_ByImportID(importID As String, ByRef importDetails As List(Of ImportDetailDTO))

      Dim query As String = String.Empty
      query &= " SELECT [ID], [ImportID], [BookID], [ImportAmount], [CurrentAmount], [ImportPrice] "
      query &= " FROM [ImportDetail]"
      query &= " WHERE [ImportDetail].[ImportID] = @ImportID"

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
               .Parameters.AddWithValue("@ImportID", importID)
            End With

            Try
               conn.Open()

               Dim importDetail As SqlDataReader
               importDetail = comm.ExecuteReader()

               If importDetail.HasRows = True Then
                  importDetails.Clear()
                  While importDetail.Read()
                     importDetails.Add(New ImportDetailDTO(importDetail("ID"), importDetail("ImportID"), importDetail("BookID"), importDetail("ImportAmount"), importDetail("CurrentAmount"), importDetail("ImportPrice")))
                  End While
               End If

            Catch ex As Exception
               conn.Close()

               Console.WriteLine("Get Import Details failed") 'for debug
               Return New Result(False, "Get Import Details failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Get Import Details succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function selectAll_ByBookID(bookID As String, ByRef importDetails As List(Of ImportDetailDTO))


      Dim query As String = String.Empty
      query &= " SELECT [ID], [ImportID], [BookID], [ImportAmount], [CurrentAmount], [ImportPrice] "
      query &= " FROM [ImportDetail] "
      query &= " WHERE [ImportDetail].[BookID] = @BookID "

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

               Dim importDetail As SqlDataReader
               importDetail = comm.ExecuteReader()

               If importDetail.HasRows = True Then
                  importDetails.Clear()
                  While importDetail.Read()
                     importDetails.Add(New ImportDetailDTO(importDetail("ID"), importDetail("ImportID"), importDetail("BookID"), importDetail("ImportAmount"), importDetail("CurrentAmount"), importDetail("ImportPrice")))
                  End While
               End If

            Catch ex As Exception
               conn.Close()

               Console.WriteLine("Get Import Details failed") 'for debug
               Return New Result(False, "Get Import Details failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Get Import Details succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function update(importDetail As ImportDetailDTO) As Result

      Dim query As String = String.Empty
      query &= " UPDATE [ImportDetail] SET "
      query &= " [ImportID] = @ImportID "
      query &= " [BookID] = @BookID "
      query &= " [ImportAmount] = @ImportAmount "
      query &= " [CurrentAmount] = @CurrentAmount "
      query &= " [ImportPrice] = @ImportPrice "
      query &= " WHERE [ID] = @ID "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
               .Parameters.AddWithValue("@ID", importDetail.ID)
               .Parameters.AddWithValue("@ImportID", importDetail.ImportID)
               .Parameters.AddWithValue("@BookID", importDetail.BookID)
               .Parameters.AddWithValue("@ImportAmount", importDetail.ImportAmount)
               .Parameters.AddWithValue("@CurrentAmount", importDetail.CurrentAmount)
               .Parameters.AddWithValue("@ImportPrice", importDetail.ImportPrice)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()

            Catch ex As Exception
               Console.WriteLine(ex.StackTrace)
               conn.Close()

               Console.WriteLine("Update Import Detail failed")
               Return New Result(False, "Update Import Detail failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Update Import Detail succeed")
      Return New Result(True)
   End Function

   Public Function delete(importDetailID As String) As Result
      Dim query As String = String.Empty
      query &= " DELETE FROM [ImportDetail] "
      query &= " WHERE [ID] = @ID "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
               .Parameters.AddWithValue("@ID", importDetailID)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()

            Catch ex As Exception
               Console.WriteLine(ex.StackTrace)
               conn.Close()

               Console.WriteLine("Delete Import Detail failed")
               Return New Result(False, "Delete Import Detail failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Delete Import Detail succeed")
      Return New Result(True)
   End Function
End Class

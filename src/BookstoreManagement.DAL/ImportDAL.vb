Imports System.Configuration
Imports System.Data.SqlClient
Imports BookstoreManagement.DTO
Imports Utility

Public Class ImportDAL
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
      query &= " FROM [Import] "
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

               Console.WriteLine("Get next Import ID failed") 'for debug
               Return New Result(False, "Get next Import ID failed", exception.StackTrace)

            End Try

			End Using

		End Using

      Console.WriteLine("Get next Import ID succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function insert(import As ImportDTO) As Result

      Dim query As String = String.Empty
      query &= " INSERT INTO [Import] ([ID], [ImportDate]) "
      query &= " VALUES (@ID, @ImportDate) "

      Dim nextID = 0
      Dim result As Result

      result = getNextId(nextID)
      If (result.FlagResult = False) Then
         Return result
      End If
      import.ID = nextID

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query

               .Parameters.AddWithValue("@ID", import.ID)
               .Parameters.AddWithValue("@ImportDate", import.ImportDate)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()
            Catch exception As Exception
               conn.Close()

               Console.WriteLine("Insert Import failed") 'for debug
               Return New Result(False, "Insert Import failed", exception.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Insert Import succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function selectAll(ByRef _imports As List(Of ImportDTO)) As Result 'trùng keyword

      Dim query As String = String.Empty
      query &= " SELECT [ID], [ImportDate] "
      query &= " FROM [Import]"

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
            End With

            Try
               conn.Open()

               Dim import As SqlDataReader
               import = comm.ExecuteReader()

               If import.HasRows = True Then
                  _imports.Clear()
                  While import.Read()
                     _imports.Add(New ImportDTO(import("ID"), import("ImportDate")))
                  End While
               End If

            Catch ex As Exception
               conn.Close()

               Console.WriteLine("Get Imports failed") 'for debug
               Return New Result(False, "Get Imports failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Get Imports succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function selectAll_ByDate(importDate As DateTime, ByRef _imports As List(Of ImportDTO)) As Result

      Dim query As String = String.Empty
      query &= " SELECT [ID], [ImportDate] "
      query &= " FROM [Import]"
      query &= " WHERE [Import].[ImportDate] = @ImportDate"


      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
               .Parameters.AddWithValue("@ImportDate", importDate)
            End With

            Try
               conn.Open()

               Dim import As SqlDataReader
               import = comm.ExecuteReader()

               If import.HasRows = True Then
                  _imports.Clear()
                  While import.Read()
                     _imports.Add(New ImportDTO(import("ID"), import("ImportDate")))
                  End While
               End If

            Catch ex As Exception
               conn.Close()

               Console.WriteLine("Get Imports failed") 'for debug
               Return New Result(False, "Get Imports failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Get Imports succeed") 'for debug
      Return New Result(True)
   End Function

   Public Function update(importDTO As ImportDTO) As Result

      Dim query As String = String.Empty
      query &= " UPDATE [Import] SET "
      query &= " [ImportDate] = @ImportDate "
      query &= " WHERE [ID] = @ID "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
               .Parameters.AddWithValue("@ID", importDTO.ID)
               .Parameters.AddWithValue("@ImportDate", importDTO.ImportDate)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()

            Catch ex As Exception
               Console.WriteLine(ex.StackTrace)
               conn.Close()

               Console.WriteLine("Update Import failed")
               Return New Result(False, "Update Import failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Update Import succeed")
      Return New Result(True)
   End Function

   Public Function delete(importID As String) As Result

      Dim query As String = String.Empty
      query &= " DELETE FROM [Import] "
      query &= " WHERE [ID] = @ID "

      Using conn As New SqlConnection(connectionStr)

         Using comm As New SqlCommand()

            With comm
               .Connection = conn
               .CommandType = CommandType.Text
               .CommandText = query
               .Parameters.AddWithValue("@ID", importID)
            End With

            Try
               conn.Open()
               comm.ExecuteNonQuery()

            Catch ex As Exception
               Console.WriteLine(ex.StackTrace)
               conn.Close()

               Console.WriteLine("Delete Import failed")
               Return New Result(False, "Delete Import failed", ex.StackTrace)
            End Try

         End Using

      End Using

      Console.WriteLine("Delete Import succeed")
      Return New Result(True)
   End Function
End Class

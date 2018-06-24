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

		query &= "SELECT TOP 1 [ID]"
		query &= "FROM [Import]"
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

					nextId = idOnDB + 1 ' new ID = current ID + 1

				Catch exception As Exception
					conn.Close()

					nextId = 1
					Return New Result(False, "Get Next Reader ID Failed", exception.StackTrace)

				End Try

			End Using

		End Using

		Return New Result(True)
	End Function

	Public Function insertAll(importDetailDTOs As List(Of ImportDetailDTO)) As Result
		Dim query As String = String.Empty

		query &= "INSERT INTO [ImportDetail] ([ID], [ImportID], [BookID], [ImportAmount], [CurrentAmount], [ImportPrice])"
		query &= "VALUES (@ID, @ImportID, @BookID, @ImportAmount, @CurrentAmount, @ImportPrice)"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				Try
					For Each importDetail As ImportDetailDTO In importDetailDTOs
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
					Return New Result(False, "Add import detail failed", exception.StackTrace)
				End Try

			End Using

		End Using

		Return New Result(True)
	End Function

	Public Function update(importDetail As ImportDetailDTO) As Result
		Return New Result(True)
	End Function

	Public Function delete(importDetail As ImportDetailDTO) As Result
		Return New Result(True)
	End Function
End Class

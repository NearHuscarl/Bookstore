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

	Public Function getNextId(ByRef nextId As String) As Result
		Dim query As String = String.Empty

		query &= "SELECT TOP 1 [ID] "
		query &= "FROM [ImportDetail] "
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

					Dim importDetail As SqlDataReader
					Dim idOnDB As String

					importDetail = comm.ExecuteReader()
					idOnDB = Nothing

					If importDetail.HasRows = True Then
						While importDetail.Read()
							idOnDB = importDetail("ID")
						End While
					End If

					idOnDB.IncrementID("IMPORTDETAIL", "D8")
					nextId = idOnDB

				Catch exception As Exception

					Debug.WriteLine("Get next import detail ID failed")
					Return New Result(False, "Get next import detail ID failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get next import detail ID succeed")
		Return New Result(True)
	End Function

	Public Function insert(importDetail As ImportDetailDTO) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [ImportDetail] ([ID], [ImportID], [BookID], [ImportAmount], [ImportPrice]) "
		query &= "VALUES (@ID, @ImportID, @BookID, @ImportAmount, @ImportPrice)"

		Dim nextID = String.Empty
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
					.Parameters.AddWithValue("@ImportPrice", importDetail.ImportPrice)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()
				Catch exception As Exception

					Debug.WriteLine("Insert import detail failed")
					Return New Result(False, "Insert import detail failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert import detail succeed")
		Return New Result(True)
	End Function

	Public Function insertAll(importDetails As List(Of ImportDetailDTO)) As Result

		Dim query As String = String.Empty
		query &= "INSERT INTO [ImportDetail] ([ID], [ImportID], [BookID], [ImportAmount], [ImportPrice]) "
		query &= "VALUES (@ID, @ImportID, @BookID, @ImportAmount, @ImportPrice)"

		Using conn As New SqlConnection(connectionStr)

			Using comm As New SqlCommand()

				Try
					For Each importDetail As ImportDetailDTO In importDetails
						conn.Close()

						Dim nextID = String.Empty
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
							.Parameters.AddWithValue("@ImportPrice", importDetail.ImportPrice)
						End With

						conn.Open()
						comm.ExecuteNonQuery()
					Next
				Catch exception As Exception

					Debug.WriteLine("Insert import details failed")
					Return New Result(False, "Insert import details failed", exception.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Insert import details succeed")
		Return New Result(True)
	End Function

	Public Function selectAll(ByRef importDetails As List(Of ImportDetailDTO))

		Dim query As String = String.Empty
		query &= "SELECT [ID], [ImportID], [BookID], [ImportAmount], [ImportPrice] "
		query &= "FROM [ImportDetail]"

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
							importDetails.Add(New ImportDetailDTO(importDetail("ID"), importDetail("ImportID"), importDetail("BookID"), importDetail("ImportAmount"), importDetail("ImportPrice")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get import details failed")
					Return New Result(False, "Get import details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get import details succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByImport(importID As String, ByRef importDetails As List(Of ImportDetailDTO))

		Dim query As String = String.Empty
		query &= "SELECT [ID], [ImportID], [BookID], [ImportAmount], [ImportPrice] "
		query &= "FROM [ImportDetail] "
		query &= "WHERE [ImportDetail].[ImportID] = @ImportID"

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
							importDetails.Add(New ImportDetailDTO(importDetail("ID"), importDetail("ImportID"), importDetail("BookID"), importDetail("ImportAmount"), importDetail("ImportPrice")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get import details failed")
					Return New Result(False, "Get import details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get import details succeed")
		Return New Result(True)
	End Function

	Public Function selectAll_ByBookID(bookID As String, ByRef importDetails As List(Of ImportDetailDTO))


		Dim query As String = String.Empty
		query &= "SELECT [ID], [ImportID], [BookID], [ImportAmount], [ImportPrice] "
		query &= "FROM [ImportDetail] "
		query &= "WHERE [ImportDetail].[BookID] = @BookID"

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
							importDetails.Add(New ImportDetailDTO(importDetail("ID"), importDetail("ImportID"), importDetail("BookID"), importDetail("ImportAmount"), importDetail("ImportPrice")))
						End While
					End If

				Catch ex As Exception

					Debug.WriteLine("Get import details failed")
					Return New Result(False, "Get import details failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Get import details succeed")
		Return New Result(True)
	End Function

	Public Function update(importDetail As ImportDetailDTO) As Result

		Dim query As String = String.Empty
		query &= "UPDATE [ImportDetail] SET "
		query &= "[ImportID] = @ImportID, "
		query &= "[BookID] = @BookID, "
		query &= "[ImportAmount] = @ImportAmount, "
		query &= "[ImportPrice] = @ImportPrice"
		query &= " WHERE [ID] = @ID"

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
					.Parameters.AddWithValue("@ImportPrice", importDetail.ImportPrice)
				End With

				Try
					conn.Open()
					comm.ExecuteNonQuery()

				Catch ex As Exception

					Debug.WriteLine("Update import detail failed")
					Return New Result(False, "Update import detail failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Update import detail succeed")
		Return New Result(True)
	End Function

	Public Function delete(importDetailID As String) As Result
		Dim query As String = String.Empty
		query &= "DELETE FROM [ImportDetail] "
		query &= "WHERE [ID] = @ID"

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

					Debug.WriteLine("Delete import detail failed")
					Return New Result(False, "Delete import detail failed", ex.StackTrace)

				Finally
					conn.Close()
				End Try

			End Using

		End Using

		Debug.WriteLine("Delete import detail succeed")
		Return New Result(True)
	End Function
End Class

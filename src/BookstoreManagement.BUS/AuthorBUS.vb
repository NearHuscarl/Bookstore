Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class AuthorBUS
	Private authorDAL As AuthorDAL

	Public Sub New()
		authorDAL = New AuthorDAL()
	End Sub

	Public Sub New(connectionStr As String)
		authorDAL = New AuthorDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return authorDAL.getNextId(nextId)
	End Function

	Public Function insert(reader As AuthorDTO) As Result
		Return authorDAL.insert(reader)
	End Function

	Public Function selectAll(ByRef authors As List(Of AuthorDTO)) As Result
		Return authorDAL.selectAll(authors)
	End Function

	Public Function update(author As AuthorDTO) As Result
		Return authorDAL.update(author)
	End Function

	Public Function delete(AuthorID As String) As Result
		Return authorDAL.delete(AuthorID)
	End Function
End Class

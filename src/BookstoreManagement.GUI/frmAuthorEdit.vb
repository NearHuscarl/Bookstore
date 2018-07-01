Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports Utility



Public Class frmAuthorEdit
	Private authorBUS As AuthorBUS
	Private isModified As Boolean
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Public Sub New(author As AuthorDTO, isModified As Boolean)
		InitializeComponent()
		authorBUS = New AuthorBUS()
		Me.isModified = isModified
		Try
			If (isModified) Then
				txtID.Text = author.ID
				txtName.Text = author.Name
			Else
				Dim result As Result
				result = authorBUS.getNextId(author.ID)

				txtID.Text = author.ID
				txtName.Text = String.Empty
			End If
		Catch ex As Exception
			Debug.WriteLine(ex.StackTrace)
		End Try
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Dispose()
	End Sub

	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		Dim newAuthor = New AuthorDTO
		Try
			newAuthor.ID = txtID.Text
			newAuthor.Name = txtName.Text
			Dim result As Result
			If (isModified) Then
				result = authorBUS.update(newAuthor)
			Else
				result = authorBUS.insert(newAuthor)
			End If
		Catch ex As Exception
			Debug.WriteLine(ex.StackTrace)
		Finally
			Me.Dispose()
		End Try
	End Sub


End Class
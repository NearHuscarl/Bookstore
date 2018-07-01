Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports Utility


Public Class frmBookCategoryEdit
	Private bookCategoryBUS As BookCategoryBUS
	Private isModified As Boolean

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Public Sub New(bookCategory As BookCategoryDTO, isModified As Boolean)
		InitializeComponent()
		bookCategoryBUS = New BookCategoryBUS()
		Me.isModified = isModified
		Try
			If (isModified) Then
				txtID.Text = bookCategory.ID
				txtName.Text = bookCategory.Name
			Else
				Dim result As Result
				result = bookCategoryBUS.getNextId(bookCategory.ID)

				txtID.Text = bookCategory.ID
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
		Dim newBookCategory = New BookCategoryDTO
		Try
			newBookCategory.ID = txtID.Text
			newBookCategory.Name = txtName.Text
			Dim result As Result
			If (isModified) Then
				result = bookCategoryBUS.update(newBookCategory)
			Else
				result = bookCategoryBUS.insert(newBookCategory)
			End If
		Catch ex As Exception
			Debug.WriteLine(ex.StackTrace)
		Finally
			Me.Dispose()
		End Try
	End Sub

End Class
Imports System.ComponentModel
Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmAuthor

	Private authorBUS As AuthorBUS
	Private bookBUS As BookBUS
	Private selectedAuthor As AuthorDTO
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Protected Overrides Sub Finalize()
		MyBase.Finalize()
	End Sub

	Private Sub frmAuthor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		authorBUS = New AuthorBUS()
		bookBUS = New BookBUS()
		loadListAuthor()
	End Sub

	Private Sub loadListAuthor(Optional name As String = "")

		Dim listAuthor = New List(Of AuthorDTO)
		Dim result As Result
		name = txtAuthorName.Text

		If name = String.Empty Then
			result = authorBUS.selectAll(listAuthor)
			If (result.FlagResult = False) Then
				MetroMessageBox.Show(Me, "Cannot load author list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
		Else
			result = authorBUS.selectAll_BySearch(name, listAuthor)
			If (result.FlagResult = False) Then
				MetroMessageBox.Show(Me, "Cannot load author list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
		End If

		dgvAuthor.Columns.Clear()


		dgvAuthor.DataSource = Nothing
		dgvAuthor.DataSource = listAuthor
		dgvAuthor.Columns.Clear()
		dgvAuthor.Columns.Add(colAuthorID)
		dgvAuthor.Columns.Add(colAuthorName)

		If dgvAuthor.DisplayedRowCount(True) = 0 Then
			btnUpdate.Enabled = False
			btnDelete.Enabled = False
		Else
			btnUpdate.Enabled = True
			btnDelete.Enabled = True
		End If
	End Sub

	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		loadListAuthor(txtAuthorName.Text)
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		txtAuthorName.Text = String.Empty
		loadListAuthor(txtAuthorName.Text)
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim frmAuthorEdit = New frmAuthorEdit(selectedAuthor, False)
		AddHandler frmAuthorEdit.Disposed, AddressOf dispose_addon
		frmAuthorEdit.ShowDialog()
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim currentRowIndex As Integer = dgvAuthor.CurrentCellAddress.Y

		If (-1 < currentRowIndex And currentRowIndex < dgvAuthor.DisplayedRowCount(True)) Then
			Try
				Dim books = New List(Of BookDTO)
				bookBUS.selectAll_ByAuthor(selectedAuthor.ID, books)

				If books.Count > 0 Then
					MetroMessageBox.Show(Me, "Cannot delete Author, check Book for constraint", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If

				Dim result As Result
				result = authorBUS.delete(selectedAuthor.ID)

				If (result.FlagResult = True) Then
					loadListAuthor()

					If (currentRowIndex >= dgvAuthor.Rows.Count) Then
						currentRowIndex = currentRowIndex - 1
					End If

					If (currentRowIndex >= 0) Then
						dgvAuthor.Rows(currentRowIndex).Selected = True
					End If

					MetroMessageBox.Show(Me, "Delete author succeed", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If

			Catch ex As Exception

				Debug.WriteLine(ex.StackTrace)
			End Try
		End If
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim frmAuthorEdit = New frmAuthorEdit(selectedAuthor, True)
		AddHandler frmAuthorEdit.Disposed, AddressOf dispose_addon
		frmAuthorEdit.ShowDialog()
	End Sub

	Private Sub dgvAuthor_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAuthor.SelectionChanged
		Dim currentRowIndex As Integer = dgvAuthor.CurrentCellAddress.Y
		If (-1 < currentRowIndex And currentRowIndex < dgvAuthor.DisplayedRowCount(True)) Then
			Try
				Dim ID = dgvAuthor.Rows(currentRowIndex).Cells(0).Value.ToString
				authorBUS.select_ByID(ID, selectedAuthor)
			Catch ex As Exception
				Debug.WriteLine(ex.StackTrace)
			End Try
		End If
	End Sub

	Private Sub dispose_addon(sender As Object, e As EventArgs)
		loadListAuthor(txtAuthorName.Text)
	End Sub
End Class
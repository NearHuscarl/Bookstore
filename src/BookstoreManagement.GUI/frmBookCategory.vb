Imports System.ComponentModel
Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmBookCategory
	Private bookCategoryBUS As BookCategoryBUS
	Private bookBUS As BookBUS
	Private selectedBookCategory As BookCategoryDTO

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Protected Overrides Sub Finalize()
		MyBase.Finalize()
	End Sub

	Private Sub frmBookCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		bookCategoryBUS = New BookCategoryBUS()
		bookBUS = New BookBUS()
		loadListBookCategory()
	End Sub
	Private Sub loadListBookCategory(Optional name As String = "")

		Dim listBookCategory = New List(Of BookCategoryDTO)
		Dim result As Result
		name = txtBookCategoryName.Text

		If name = String.Empty Then
			result = bookCategoryBUS.selectAll(listBookCategory)
			If (result.FlagResult = False) Then
				MetroMessageBox.Show(Me, "Cannot load book category list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
		Else
			result = bookCategoryBUS.selectAll_BySearch(name, listBookCategory)
			If (result.FlagResult = False) Then
				MetroMessageBox.Show(Me, "Cannot load book category list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
		End If

		dgvBookCategory.Columns.Clear()


		dgvBookCategory.DataSource = Nothing
		dgvBookCategory.DataSource = listBookCategory
		dgvBookCategory.Columns.Clear()
		dgvBookCategory.Columns.Add(colBookCategoryID)
		dgvBookCategory.Columns.Add(colBookCategoryName)

		If dgvBookCategory.DisplayedRowCount(True) = 0 Then
			btnUpdate.Enabled = False
			btnDelete.Enabled = False
		Else
			btnUpdate.Enabled = True
			btnDelete.Enabled = True
		End If
	End Sub

	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		loadListBookCategory(txtBookCategoryName.Text)
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		txtBookCategoryName.Text = String.Empty
		loadListBookCategory(txtBookCategoryName.Text)
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim frmBookCategoryEdit = New frmBookCategoryEdit(selectedBookCategory, False)
		AddHandler frmBookCategoryEdit.Disposed, AddressOf dispose_addon
		frmBookCategoryEdit.ShowDialog()
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim currentRowIndex As Integer = dgvBookCategory.CurrentCellAddress.Y

		If (-1 < currentRowIndex And currentRowIndex < dgvBookCategory.DisplayedRowCount(True)) Then
			Try
				Dim books = New List(Of BookDTO)
				bookBUS.selectAll_ByBookCategory(selectedBookCategory.ID, books)

				If books.Count > 0 Then
					MetroMessageBox.Show(Me, "Cannot delete book category, check Book for constraint", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If

				Dim result As Result
				result = bookCategoryBUS.delete(selectedBookCategory.ID)

				If (result.FlagResult = True) Then
					loadListBookCategory()

					If (currentRowIndex >= dgvBookCategory.Rows.Count) Then
						currentRowIndex = currentRowIndex - 1
					End If

					If (currentRowIndex >= 0) Then
						dgvBookCategory.Rows(currentRowIndex).Selected = True
					End If

					MetroMessageBox.Show(Me, "Delete book category succeed", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If

			Catch ex As Exception

				Debug.WriteLine(ex.StackTrace)
			End Try
		End If
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim frmBookCategoryEdit = New frmBookCategoryEdit(selectedBookCategory, True)
		AddHandler frmBookCategoryEdit.Disposed, AddressOf dispose_addon
		frmBookCategoryEdit.ShowDialog()
	End Sub

	Private Sub dgvBookCategory_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBookCategory.SelectionChanged
		Dim currentRowIndex As Integer = dgvBookCategory.CurrentCellAddress.Y
		If (-1 < currentRowIndex And currentRowIndex < dgvBookCategory.DisplayedRowCount(True)) Then
			Try
				Dim ID = dgvBookCategory.Rows(currentRowIndex).Cells(0).Value.ToString
				bookCategoryBUS.select_ByID(ID, selectedBookCategory)
			Catch ex As Exception
				Debug.WriteLine(ex.StackTrace)
			End Try
		End If
	End Sub

	Private Sub dispose_addon(sender As Object, e As EventArgs)
		loadListBookCategory(txtBookCategoryName.Text)
	End Sub

End Class
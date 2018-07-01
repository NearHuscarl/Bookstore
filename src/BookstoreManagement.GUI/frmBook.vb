Imports System.ComponentModel
Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility


Public Class frmBook

	Private authorBUS As AuthorBUS
	Private bookCategoryBUS As BookCategoryBUS
	Private bookBUS As BookBUS
	Private importDetailBUS As ImportDetailBUS
	Private invoiceDetailBUS As InvoiceDetailBUS
	Private selectedBook As BookDTO

	Private Sub loadListAuthor()
		Dim authors As List(Of AuthorDTO) = New List(Of AuthorDTO)
		Dim result As Result

		result = authorBUS.selectAll(authors)

		authors = authors.OrderBy(Function(import) import.ID).ToList() 'Sort alphabetically

		If (result.FlagResult = True) Then
			colAuthorName.DataSource = authors
			colAuthorName.ValueMember = "ID"
			colAuthorName.DisplayMember = "Name"
		Else
			MetroMessageBox.Show(Me, "Cannot load authors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub loadListBookCategory()
		Dim bookCategories As List(Of BookCategoryDTO) = New List(Of BookCategoryDTO)
		Dim result As Result

		result = bookCategoryBUS.selectAll(bookCategories)

		bookCategories = bookCategories.OrderBy(Function(import) import.ID).ToList() 'Sort alphabetically

		If (result.FlagResult = True) Then
			colBookCategoryName.DataSource = bookCategories
			colBookCategoryName.ValueMember = "ID"
			colBookCategoryName.DisplayMember = "Name"
		Else
			MetroMessageBox.Show(Me, "Cannot load book categories", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub
	Private Sub loadListBook(Optional name As String = "")

		loadListAuthor()
		loadListBookCategory()

		Dim listBook = New List(Of BookDTO)
		Dim result As Result
		name = txtBookName.Text

		If name = String.Empty Then
			result = bookBUS.selectAll(listBook)
			If (result.FlagResult = False) Then
				MetroMessageBox.Show(Me, "Cannot load book list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
		Else
			result = bookBUS.selectAll_BySearch(name, listBook)
			If (result.FlagResult = False) Then
				MetroMessageBox.Show(Me, "Cannot load book list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
		End If

		dgvBook.Columns.Clear()

		dgvBook.DataSource = Nothing
		dgvBook.DataSource = listBook
		dgvBook.Columns.Clear()
		dgvBook.Columns.Add(colBookID)
		dgvBook.Columns.Add(colBookName)
		dgvBook.Columns.Add(colAuthorName)
		dgvBook.Columns.Add(colBookCategoryName)
		dgvBook.Columns.Add(colStock)
		dgvBook.Columns.Add(colPrice)

		If dgvBook.DisplayedRowCount(True) = 0 Then
			btnUpdate.Enabled = False
			btnDelete.Enabled = False
		Else
			btnUpdate.Enabled = True
			btnDelete.Enabled = True
		End If
	End Sub

	Private Sub frmBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		authorBUS = New AuthorBUS()
		bookCategoryBUS = New BookCategoryBUS()
		bookBUS = New BookBUS()
		importDetailBUS = New ImportDetailBUS()
		invoiceDetailBUS = New InvoiceDetailBUS()

		loadListBook()
	End Sub

	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		loadListBook(txtBookName.Text)
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		txtBookName.Text = String.Empty
		loadListBook(txtBookName.Text)
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim frmBookEdit = New frmBookEdit(selectedBook, False)
		AddHandler frmBookEdit.Disposed, AddressOf dispose_addon
		frmBookEdit.ShowDialog()
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim currentRowIndex As Integer = dgvBook.CurrentCellAddress.Y

		If (-1 < currentRowIndex And currentRowIndex < dgvBook.DisplayedRowCount(True)) Then
			Try
				Dim importDetails = New List(Of ImportDetailDTO)
				importDetailBUS.selectAll_ByBook(selectedBook.ID, importDetails)
				Dim invoiceDetails = New List(Of InvoiceDetailDTO)
				invoiceDetailBUS.selectAll_ByBook(selectedBook.ID, invoiceDetails)

				If (importDetails.Count > 0 Or invoiceDetails.Count > 0) Then
					MetroMessageBox.Show(Me, "Cannot delete Book, check Import Detail and Invoice Detail for constraint", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If

				Dim result As Result
				result = bookBUS.delete(selectedBook.ID)

				If (result.FlagResult = True) Then
					loadListBook()

					If (currentRowIndex >= dgvBook.Rows.Count) Then
						currentRowIndex = currentRowIndex - 1
					End If

					If (currentRowIndex >= 0) Then
						dgvBook.Rows(currentRowIndex).Selected = True
					End If

					MetroMessageBox.Show(Me, "Delete book succeed", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If

			Catch ex As Exception

				Debug.WriteLine(ex.StackTrace)
			End Try
		End If
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim frmBookEdit = New frmBookEdit(selectedBook, True)
		AddHandler frmBookEdit.Disposed, AddressOf dispose_addon
		frmBookEdit.ShowDialog()
	End Sub

	Private Sub dgvBook_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBook.SelectionChanged
		Dim currentRowIndex As Integer = dgvBook.CurrentCellAddress.Y
		If (-1 < currentRowIndex And currentRowIndex < dgvBook.DisplayedRowCount(True)) Then
			Try
				Dim ID = dgvBook.Rows(currentRowIndex).Cells(0).Value.ToString
				bookBUS.select_ByID(ID, selectedBook)
			Catch ex As Exception
				Debug.WriteLine(ex.StackTrace)
			End Try
		End If
	End Sub

	Private Sub dispose_addon(sender As Object, e As EventArgs)
		loadListBook(txtBookName.Text)
	End Sub
End Class
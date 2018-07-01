Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility


Public Class frmBookEdit
	Private authorBUS As AuthorBUS
	Private bookCategoryBUS As BookCategoryBUS
	Private bookBUS As BookBUS
	Private isModified As Boolean

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Public Sub New(book As BookDTO, isModified As Boolean)
		InitializeComponent()
		bookBUS = New BookBUS()
		authorBUS = New AuthorBUS()
		bookCategoryBUS = New BookCategoryBUS()
		loadListAuthor()
		loadListBookCategory()
		Me.isModified = isModified
		Try
			If (isModified) Then
				txtID.Text = book.ID
				txtName.Text = book.Name
				cbAuthor.SelectedValue = book.AuthorID
				cbCategory.SelectedValue = book.BookCategoryID
				txtStock.Text = book.Stock
				txtPrice.Text = book.Price
			Else
				Dim result As Result
				result = bookBUS.getNextId(book.ID)

				txtID.Text = book.ID
				txtName.Text = String.Empty
				cbAuthor.SelectedIndex = 0
				cbCategory.SelectedIndex = 0
				txtStock.Text = 0
				txtPrice.Text = 0
			End If
		Catch ex As Exception
			Debug.WriteLine(ex.StackTrace)
		End Try
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Dispose()
	End Sub

	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		Dim newBook = New BookDTO
		Try
			newBook.ID = txtID.Text
			newBook.Name = txtName.Text
			newBook.AuthorID = cbAuthor.SelectedValue
			newBook.BookCategoryID = cbCategory.SelectedValue
			newBook.Stock = txtStock.Text
			newBook.Price = txtPrice.Text

			Dim result As Result
			If (isModified) Then
				result = bookBUS.update(newBook)
			Else
				result = bookBUS.insert(newBook)
			End If
		Catch ex As Exception
			Debug.WriteLine(ex.StackTrace)
		Finally
			Me.Dispose()
		End Try
	End Sub

	Private Sub loadListAuthor()
		Dim authors As List(Of AuthorDTO) = New List(Of AuthorDTO)
		Dim result As Result

		result = authorBUS.selectAll(authors)

		authors = authors.OrderBy(Function(author) author.ID).ToList()
		If (result.FlagResult = True) Then
			cbAuthor.DataSource = authors
			cbAuthor.ValueMember = "ID"
			cbAuthor.DisplayMember = "Name"
		Else
			MetroMessageBox.Show(Me, "Cannot load authors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub loadListBookCategory()
		Dim bookCategories As List(Of BookCategoryDTO) = New List(Of BookCategoryDTO)
		Dim result As Result

		result = bookCategoryBUS.selectAll(bookCategories)

		bookCategories = bookCategories.OrderBy(Function(category) category.ID).ToList()
		If (result.FlagResult = True) Then
			cbCategory.DataSource = bookCategories
			cbCategory.ValueMember = "ID"
			cbCategory.DisplayMember = "Name"
		Else
			MetroMessageBox.Show(Me, "Cannot load book categories", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Public Sub dispose_addon(sender As Object, e As EventArgs)
		loadListAuthor()
		loadListBookCategory()
	End Sub

	Private Sub btnAddAuthor_Click(sender As Object, e As EventArgs) Handles btnAddAuthor.Click
		Dim authorDTO = New AuthorDTO
		Dim frmAuthorEdit = New frmAuthorEdit(authorDTO, False)
		AddHandler frmAuthorEdit.Disposed, AddressOf dispose_addon
		frmAuthorEdit.ShowDialog()
	End Sub

	Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
		Dim bookCategoryDTO = New BookCategoryDTO
		Dim frmBookCategoryEdit = New frmBookCategoryEdit(bookCategoryDTO, False)
		AddHandler frmBookCategoryEdit.Disposed, AddressOf dispose_addon
		frmBookCategoryEdit.ShowDialog()
	End Sub
End Class
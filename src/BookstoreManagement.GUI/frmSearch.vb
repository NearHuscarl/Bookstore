Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmSearch
	Private bookBUS As BookBUS
	Private categoryBUS As BookCategoryBUS
	Private authorBUS As AuthorBUS

	Private books As List(Of BookDTO)
	Private categories As List(Of BookCategoryDTO)
	Private authors As List(Of AuthorDTO)

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		bookBUS = New BookBUS()
		categoryBUS = New BookCategoryBUS()
		authorBUS = New AuthorBUS()

		LoadBooks()
		LoadCategories()
		LoadAuthors()
		InitAmountCombobox()
	End Sub

	Private Sub InitAmountCombobox()
		cbbAmount.DataSource = New List(Of String) From
		{
			"Any",
			"0 - 10",
			"10 - 100",
			"100 - 500",
			"500 - 1000",
			"Over 1000"
		}
	End Sub

	Private Sub LoadBooks()
		books = New List(Of BookDTO)
		Dim result = bookBUS.selectAll(books)
		books = books.OrderBy(Function(b) b.ID).ToList() 'Sort alphabetically

		If (result.FlagResult = False) Then
			MetroMessageBox.Show(Me, "Cannot load books", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub LoadCategories()
		categories = New List(Of BookCategoryDTO)
		Dim result = categoryBUS.selectAll(categories)
		categories = categories.OrderBy(Function(c) c.ID).ToList() 'Sort alphabetically
		categories.Insert(0, New BookCategoryDTO("All", "All")) 'Dummy category represent All option in combobox

		If (result.FlagResult = False) Then
			MetroMessageBox.Show(Me, "Cannot load categories", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		Else
			cbbCategory.DataSource = categories
			cbbCategory.ValueMember = "ID"
			cbbCategory.DisplayMember = "Name"
		End If
	End Sub

	Private Sub LoadAuthors()
		authors = New List(Of AuthorDTO)
		Dim result = authorBUS.selectAll(authors)
		authors = authors.OrderBy(Function(a) a.ID).ToList() 'Sort alphabetically

		If (result.FlagResult = False) Then
			MetroMessageBox.Show(Me, "Cannot load authors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub SetBookFromCellsIndex(index As Integer, value As BookDTO)
		dgvSearchResults.Rows(index).Cells("colBook").Value = value.Name

		Dim category = categories.Where(Function(c) c.ID = value.BookCategoryID).Select(Function(c) c.Name).First()
		dgvSearchResults.Rows(index).Cells("colCategory").Value = category

		Dim author = authors.Where(Function(a) a.ID = value.AuthorID).Select(Function(a) a.Name).First()
		dgvSearchResults.Rows(index).Cells("colAuthor").Value = author

		dgvSearchResults.Rows(index).Cells("colAmount").Value = value.Stock
	End Sub

	Private Sub LoadSearchResults(searchResults As List(Of BookDTO))
		dgvSearchResults.Rows.Clear() 'Remove old data
		dgvSearchResults.Refresh()

		For Each result As BookDTO In searchResults
			Dim currentIndex = dgvSearchResults.Rows.Add()
			SetBookFromCellsIndex(currentIndex, result)
		Next
	End Sub

	Private Function FilterByName(books As List(Of BookDTO), name As String) As List(Of BookDTO)
		If (name.Trim() = String.Empty) Then
			Return books
		End If

		Return books.Where(Function(b) b.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList()
	End Function

	Private Function FilterByCategory(books As List(Of BookDTO), category As String) As List(Of BookDTO)
		If (category = "All") Then
			Return books
		End If

		Dim categoryIDs = categories.Where(Function(c) c.Name.Contains(category, StringComparison.OrdinalIgnoreCase)).Select(Function(a) a.ID).ToList()
		Dim results = New List(Of BookDTO)

		For Each book As BookDTO In books
			For Each categoryID As String In categoryIDs
				If (book.BookCategoryID = categoryID) Then
					results.Add(book)
					Exit For
				End If
			Next
		Next

		Return results
	End Function

	Private Function FilterByAuthor(books As List(Of BookDTO), author As String) As List(Of BookDTO)
		If (author.Trim() = String.Empty) Then
			Return books
		End If

		Dim authorIDs = authors.Where(Function(a) a.Name.Contains(author, StringComparison.OrdinalIgnoreCase)).Select(Function(a) a.ID).ToList()
		Dim results = New List(Of BookDTO)

		For Each book As BookDTO In books
			For Each authorID As String In authorIDs
				If (book.AuthorID = authorID) Then
					results.Add(book)
					Exit For
				End If
			Next
		Next

		Return results
	End Function

	Private Function FilterByAmount(books As List(Of BookDTO), minAmount As Integer, maxAmount As Integer) As List(Of BookDTO)
		If (minAmount = Nothing And maxAmount = Nothing) Then
			Return books
		End If

		If (minAmount < 0 Or (minAmount >= maxAmount)) Then
			Throw New ArgumentOutOfRangeException("What could go wrong?")
		End If

		If (maxAmount = Nothing) Then
			Return books.Where(Function(b) b.Stock >= minAmount).ToList()
		Else
			Return books.Where(Function(b) b.Stock >= minAmount And b.Stock <= maxAmount).ToList()
		End If
	End Function

	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		Dim bookName = txtBookName.Text
		Dim category = cbbCategory.Text
		Dim author = txtAuthor.Text
		Dim minAmount As Integer
		Dim maxAmount As Integer

		If (cbbAmount.Text.StartsWith("Over")) Then 'Over 1000 option
			minAmount = cbbAmount.Text.Substring("Over".Length).Trim()
			maxAmount = Nothing
		ElseIf (cbbAmount.Text.StartsWith("Any")) Then
			minAmount = Nothing
			maxAmount = Nothing
		Else
			Dim amounts = cbbAmount.Text.Split("-".ToCharArray()).Select(Function(n) n.Trim()).ToList()
			minAmount = amounts(0)
			maxAmount = amounts(1)
		End If

		Dim searchResults = New List(Of BookDTO)

		searchResults = FilterByName(books, bookName)
		searchResults = FilterByCategory(searchResults, category)
		searchResults = FilterByAuthor(searchResults, author)
		searchResults = FilterByAmount(searchResults, minAmount, maxAmount)

		LoadSearchResults(searchResults)
	End Sub
End Class

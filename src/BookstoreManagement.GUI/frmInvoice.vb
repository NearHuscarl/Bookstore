Imports System.ComponentModel
Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmInvoice
	Private isInvoiceLoading As Boolean
	Private isInvoiceDetailLoading As Boolean

	Private invoiceBUS As InvoiceBUS
	Private invoiceDetailBUS As InvoiceDetailBUS
	Private bookBUS As BookBUS
	Private categoryBUS As BookCategoryBUS
	Private customerBUS As CustomerBUS

	''' <summary>
	''' If selected invoice ID = nextInvoiceID, enable add button, otherwise disable it
	''' </summary>
	Private nextInvoiceID As String
	Private nextInvoiceDetailID As String

	''' <summary>
	''' List of InvoiceDetailDTO that has changed since last add/update
	''' </summary>
	Private invoiceDetailsToUpdate As List(Of InvoiceDetailDTO) = New List(Of InvoiceDetailDTO)
	Private categories As List(Of BookCategoryDTO)

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		invoiceBUS = New InvoiceBUS()
		invoiceDetailBUS = New InvoiceDetailBUS()
		bookBUS = New BookBUS()
		categoryBUS = New BookCategoryBUS()
		customerBUS = New CustomerBUS()

		LoadBooks()
		LoadCategories()
		LoadCustomers()

		LoadInvoice()
	End Sub

	Private Sub LoadInvoice()
		isInvoiceLoading = True

		dgvInvoice.Rows.Clear() 'Remove old data
		dgvInvoice.Refresh()

		Dim invoices As List(Of InvoiceDTO) = New List(Of InvoiceDTO)
		Dim result As Result

		result = invoiceBUS.selectAll(invoices)

		If (result.FlagResult = True) Then ' Add next Invoice ID
			result = invoiceBUS.getNextId(nextInvoiceID)

			If (result.FlagResult = True) Then
				invoices.Add(New InvoiceDTO(nextInvoiceID, "", Date.Now))
				invoices = invoices.OrderByDescending(Function(invoice) invoice.ID).ToList()

				For Each invoice As InvoiceDTO In invoices
					Dim currentIndex = dgvInvoice.Rows.Add()
					SetInvoiceFromCellsIndex(currentIndex, invoice)
				Next
			Else
				MetroMessageBox.Show(Me, "Cannot get next ID of invoice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Console.WriteLine(result.SystemMessage)
			End If
		Else
			MetroMessageBox.Show(Me, "Cannot load invoice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		LoadInvoiceDetailsFromSelectedInvoice()
		isInvoiceLoading = False
	End Sub

	Private Sub LoadInvoiceDetail(invoiceID As String)
		isInvoiceDetailLoading = True

		dgvInvoiceDetail.Rows.Clear() 'Remove old data
		dgvInvoiceDetail.Refresh()

		Dim invoiceDetails As List(Of InvoiceDetailDTO) = New List(Of InvoiceDetailDTO)
		Dim result As Result = New Result(True)

		If (invoiceID = nextInvoiceID) Then
			result = invoiceDetailBUS.getNextId(nextInvoiceDetailID)

			If (result.FlagResult = True) Then
				invoiceDetails.Add(New InvoiceDetailDTO(nextInvoiceDetailID, nextInvoiceID, Nothing, Nothing, Nothing))
			Else
				MetroMessageBox.Show(Me, "Cannot get next Invoice Detail ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Console.WriteLine(result.SystemMessage)
			End If
		Else
			result = invoiceDetailBUS.selectAll_ByInvoice(invoiceID, invoiceDetails)
		End If

		If (result.FlagResult = True) Then
			For Each invoiceDetail As InvoiceDetailDTO In invoiceDetails
				Dim currentIndex = dgvInvoiceDetail.Rows.Add()
				SetInvoiceDetailFromCellsIndex(currentIndex, invoiceDetail)
			Next
		Else
			MetroMessageBox.Show(Me, "Cannot load Invoice Detail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		isInvoiceDetailLoading = False
	End Sub

	Private Sub LoadBooks()
		Dim books As List(Of BookDTO) = New List(Of BookDTO)
		Dim result = bookBUS.selectAll(books)
		books = books.OrderBy(Function(invoice) invoice.ID).ToList() 'Sort alphabetically

		If (result.FlagResult = True) Then
			colBookID.DataSource = books
			colBookID.ValueMember = "ID"
			colBookID.DisplayMember = "Name"
		Else
			MetroMessageBox.Show(Me, "Cannot load books", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub LoadCategories()
		categories = New List(Of BookCategoryDTO)
		Dim result = categoryBUS.selectAll(categories)
		categories = categories.OrderBy(Function(invoice) invoice.ID).ToList() 'Sort alphabetically

		If (result.FlagResult = False) Then
			MetroMessageBox.Show(Me, "Cannot load book categories", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub LoadCustomers()
		Dim customers As List(Of CustomerDTO) = New List(Of CustomerDTO)
		Dim result As Result

		result = customerBUS.selectAll(customers)

		customers = customers.OrderBy(Function(invoice) invoice.ID).ToList() 'Sort alphabetically

		If (result.FlagResult = True) Then
			colCustomer.DataSource = customers
			colCustomer.ValueMember = "ID"
			colCustomer.DisplayMember = "Name"
		Else
			MetroMessageBox.Show(Me, "Cannot load customers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Property SelectedInvoice() As InvoiceDTO
		Get
			If (dgvInvoice.CurrentRow IsNot Nothing) Then
				Return GetInvoiceFromCellsIndex(dgvInvoice.CurrentRow.Index)
			End If
			Return Nothing
		End Get

		Set(ByVal Value As InvoiceDTO)
			SetInvoiceFromCellsIndex(dgvInvoice.CurrentRow.Index, Value)
		End Set
	End Property

	Property SelectedInvoiceDetail() As InvoiceDetailDTO
		Get
			If (dgvInvoiceDetail.CurrentRow IsNot Nothing) Then
				Return GetInvoiceDetailFromCellsIndex(dgvInvoiceDetail.CurrentRow.Index)
			End If
			Return Nothing
		End Get

		Set(ByVal Value As InvoiceDetailDTO)
			SetInvoiceDetailFromCellsIndex(dgvInvoiceDetail.CurrentRow.Index, Value)
		End Set
	End Property

	Private Function GetInvoiceDetailFromCellsIndex(index As Integer) As InvoiceDetailDTO
		Dim invoiceDetail As InvoiceDetailDTO = New InvoiceDetailDTO()
		Dim selectedCells = dgvInvoiceDetail.Rows(index).Cells
		Dim selectedInvoiceCells = dgvInvoice.Rows(dgvInvoice.CurrentRow.Index).Cells

		invoiceDetail.ID = selectedCells("colInvoiceDetailID").Value
		invoiceDetail.InvoiceID = selectedInvoiceCells("colInvoiceID").Value
		invoiceDetail.BookID = selectedCells("colBookID").Value

		Try
			Dim amount = Convert.ToInt32(selectedCells("colAmount").Value)

			If (amount < 0) Then
				Throw New ArgumentException
			End If

			invoiceDetail.Amount = amount
		Catch ex As FormatException
			selectedCells("colAmount").Value = 0

			MetroMessageBox.Show(Me, "Invoice amount field must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(ex.StackTrace)
			Return Nothing
		Catch ex As ArgumentException
			selectedCells("colAmount").Value = 0

			MetroMessageBox.Show(Me, "Invoice amount out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(ex.StackTrace)
			Return Nothing
		End Try

		Try
			Dim price = Convert.ToInt32(selectedCells("colPrice").Value)

			If (price < 0) Then
				Throw New ArgumentException
			End If

			invoiceDetail.SalesPrice = price
		Catch ex As FormatException
			selectedCells("colPrice").Value = 0

			MetroMessageBox.Show(Me, "Invoice price field must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(ex.StackTrace)
			Return Nothing
		Catch ex As ArgumentException
			selectedCells("colPrice").Value = 0

			MetroMessageBox.Show(Me, "Invoice price out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(ex.StackTrace)
			Return Nothing
		End Try

		Return invoiceDetail
	End Function

	Private Sub UpdateCategoryFromCellsIndex(index As Integer)
		Dim bookID = dgvInvoiceDetail.Rows(index).Cells("colBookID").Value
		Dim book = DirectCast(colBookID.DataSource, List(Of BookDTO)).
			Where(Function(b) b.ID = bookID).FirstOrDefault()

		If (book IsNot Nothing) Then
			Dim category = categories.
				Where(Function(c) c.ID = book.BookCategoryID).
				Select(Function(c) c.Name).FirstOrDefault()

			dgvInvoiceDetail.Rows(index).Cells("colCategory").Value = category
		End If
	End Sub

	Private Sub UpdatePriceFromCellsIndex(index As Integer)
		Dim bookID = dgvInvoiceDetail.Rows(index).Cells("colBookID").Value
		Dim book = DirectCast(colBookID.DataSource, List(Of BookDTO)).
			Where(Function(b) b.ID = bookID).FirstOrDefault()

		If (book IsNot Nothing) Then
			dgvInvoiceDetail.Rows(index).Cells("colPrice").Value = book.Price
		End If
	End Sub

	Private Sub SetInvoiceDetailFromCellsIndex(index As Integer, value As InvoiceDetailDTO)
		dgvInvoiceDetail.Rows(index).Cells("colInvoiceDetailID").Value = value.ID
		dgvInvoiceDetail.Rows(index).Cells("colBookID").Value = value.BookID
		UpdateCategoryFromCellsIndex(index)
		dgvInvoiceDetail.Rows(index).Cells("colAmount").Value = value.Amount

		If (value.SalesPrice = Nothing) Then
			UpdatePriceFromCellsIndex(index)
		Else
			dgvInvoiceDetail.Rows(index).Cells("colPrice").Value = value.SalesPrice
		End If
	End Sub

	Private Function GetInvoiceFromCellsIndex(index As Integer) As InvoiceDTO
		Dim invoice As InvoiceDTO = New InvoiceDTO()
		Dim selectedCells = dgvInvoice.Rows(index).Cells
		Dim dateString = selectedCells("colDate").Value

		invoice.ID = selectedCells("colInvoiceID").Value
		invoice.CustomerID = selectedCells("colCustomer").Value

		If (dateString <> Nothing) Then
			invoice.InvoiceDate = Date.ParseExact(
				String.Format("{0:MM/dd/yyyy HH:mm:ss}", dateString),
				New String() {"MM/dd/yyyy HH:mm:ss", "MM/d/yyyy HH:mm:ss", "M/dd/yyyy HH:mm:ss", "M/d/yyyy HH:mm:ss"},
				Globalization.CultureInfo.InvariantCulture,
				Globalization.DateTimeStyles.None)
		End If

		Return invoice
	End Function

	Private Sub SetInvoiceFromCellsIndex(index As Integer, value As InvoiceDTO)
		dgvInvoice.Rows(index).Cells("colInvoiceID").Value = value.ID
		dgvInvoice.Rows(index).Cells("colCustomer").Value = value.CustomerID
		dgvInvoice.Rows(index).Cells("colDate").Value = String.Format("{0:MM/dd/yyyy HH:mm:ss}", value.InvoiceDate)
	End Sub

	Public Function GetErrorMessage(title As String, result As Result) As String
		Dim errorMessage As String = ""

		errorMessage &= title
		errorMessage &= Environment.NewLine
		errorMessage &= Environment.NewLine
		errorMessage &= result.ApplicationMessage

		Return errorMessage
	End Function

	Private Sub LoadInvoiceDetailsFromSelectedInvoice()
		If (SelectedInvoice Is Nothing) Then
			Return
		End If

		Dim selectedInvoiceID = SelectedInvoice.ID

		If (selectedInvoiceID Is Nothing) Then
			Return
		End If

		btnAdd.Enabled = False
		btnUpdate.Enabled = False

		LoadInvoiceDetail(selectedInvoiceID)
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim invoice = SelectedInvoice
		Dim result As Result

		result = invoiceBUS.insert(invoice)

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, "Invoice is added", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MetroMessageBox.Show(Me, GetErrorMessage("Failed to add invoice", result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
			Return
		End If

		Dim invoiceDetails = New List(Of InvoiceDetailDTO)

		For Each row As DataGridViewRow In dgvInvoiceDetail.Rows
			If (row.IsNewRow) Then
				Exit For
			End If

			Dim invoiceDetail = GetInvoiceDetailFromCellsIndex(row.Index)
			If (invoiceDetail Is Nothing) Then
				Return
			End If
			invoiceDetails.Add(invoiceDetail)
		Next

		result = invoiceDetailBUS.insertAll(invoiceDetails)

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, "Invoice detail is added", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
			btnAdd.Enabled = False 'Make sure to disable before loading
			LoadInvoice() ' Reload invoice to reflect new changes and add nextId
		Else
			If (invoice.ID = nextInvoiceID) Then
				invoiceBUS.delete(invoice.ID)
			End If

			MetroMessageBox.Show(Me, GetErrorMessage("Failed to add invoice detail", result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim result As Result

		For Each invoiceDetail As InvoiceDetailDTO In invoiceDetailsToUpdate
			result = invoiceDetailBUS.update(invoiceDetail)

			If (result.FlagResult = False) Then
				MetroMessageBox.Show(Me, GetErrorMessage("Failed to update invoice detail", result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Console.WriteLine(result.SystemMessage)
				Return
			End If
		Next

		MetroMessageBox.Show(Me, "Invoice details is updated", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		LoadInvoiceDetailsFromSelectedInvoice()
		invoiceDetailsToUpdate.Clear()
		btnUpdate.Enabled = False
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim selectedInvoiceDetailID = SelectedInvoiceDetail.ID
		Dim result As Result

		result = invoiceDetailBUS.delete(selectedInvoiceDetailID)

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, String.Format("Invoice detail {0} is deleted", selectedInvoiceDetailID),
										"Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MetroMessageBox.Show(Me, String.Format("Failed to delete invoice detail {0}", selectedInvoiceDetailID),
										"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
			Return
		End If

		LoadInvoiceDetailsFromSelectedInvoice()
	End Sub

	Private Sub UpdateTotalPrice()
		Dim total = 0
		For Each row As DataGridViewRow In dgvInvoiceDetail.Rows
			If (row.IsNewRow) Then
				Exit For
			End If

			Dim invoiceDetail = GetInvoiceDetailFromCellsIndex(row.Index)
			total += invoiceDetail.SalesPrice * invoiceDetail.Amount
		Next

		txtTotal.Text = total.ToString("N0")
	End Sub

	Private isChangingInvoiceSelection As Boolean = False
	Private lastInvoiceSelectionIndex As Integer
	Private Sub dgvInvoice_SelectionChanged(sender As Object, e As EventArgs) Handles dgvInvoice.SelectionChanged
		If (isChangingInvoiceSelection) Then
			Return
		End If

		If (btnUpdate.Enabled Or btnAdd.Enabled) Then 'Detect change in InvoiceDetail. warn to override
			isChangingInvoiceSelection = True

			Dim dialogResult = MetroMessageBox.Show(Me, "All changed in Invoice Detail will be overwrite. Do you want to switch?",
										"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

			If (dialogResult = DialogResult.Yes) Then
				If (btnUpdate.Enabled) Then
					invoiceDetailsToUpdate.Clear()
				End If
				LoadInvoiceDetailsFromSelectedInvoice()
			Else
				dgvInvoice.Rows(lastInvoiceSelectionIndex).Selected = True 'Trigger recursion
			End If
		Else
			LoadInvoiceDetailsFromSelectedInvoice()
		End If

		UpdateTotalPrice()

		If (SelectedInvoiceDetail IsNot Nothing) Then
			If (SelectedInvoice.ID = nextInvoiceID) Then 'Cannot change customer in invoice once added
				colCustomer.ReadOnly = False
			Else
				colCustomer.ReadOnly = True
			End If

			If (SelectedInvoiceDetail.ID = nextInvoiceDetailID) Then
				dgvInvoiceDetail.AllowUserToAddRows = True
			Else
				dgvInvoiceDetail.AllowUserToAddRows = False
			End If
		End If

		lastInvoiceSelectionIndex = dgvInvoice.CurrentCell.RowIndex
		isChangingInvoiceSelection = False
	End Sub

	Private Sub dgvInvoiceDetail_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoiceDetail.CellValueChanged
		If (e.RowIndex = -1 Or isInvoiceDetailLoading) Then
			Return
		End If

		Dim changedInvoiceDetail = GetInvoiceDetailFromCellsIndex(e.RowIndex)
		If (changedInvoiceDetail Is Nothing) Then
			Return
		End If

		If (changedInvoiceDetail.ID = Nothing) Then
			nextInvoiceDetailID.IncrementID("INVOICEDETAIL", "D4")
			changedInvoiceDetail.ID = nextInvoiceDetailID
			SelectedInvoiceDetail = changedInvoiceDetail
			Return
		End If

		invoiceDetailsToUpdate.AddOrReplace(changedInvoiceDetail, InvoiceDetailComparer.Instance)

		If (dgvInvoiceDetail.Columns(e.ColumnIndex).Name = "colBookID") Then ' Update book category along with book ID
			UpdateCategoryFromCellsIndex(e.RowIndex)
			UpdatePriceFromCellsIndex(e.RowIndex)
		End If

		UpdateTotalPrice()

		If (SelectedInvoice IsNot Nothing) Then
			If (SelectedInvoice.ID Is nextInvoiceID) Then
				btnAdd.Enabled = True
			Else
				btnUpdate.Enabled = True
			End If
		End If
	End Sub

	Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
		If (btnAdd.Enabled Or btnUpdate.Enabled) Then
			Dim dialogResult = MetroMessageBox.Show(Me, "All changed in Import Detail will be overwrite. Do you want to exit?",
							"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

			If (dialogResult = DialogResult.Yes) Then
				MyBase.OnFormClosing(e)
			Else
				e.Cancel = True
			End If
		End If
	End Sub
End Class

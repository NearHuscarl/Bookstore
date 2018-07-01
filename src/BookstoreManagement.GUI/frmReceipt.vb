Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmReceipt
	Private isReceiptLoading As Boolean

	Private receiptBUS As ReceiptBUS
	Private customerBUS As CustomerBUS

	''' <summary>
	''' If selected receipt ID = nextReceiptID, enable add button, otherwise disable it
	''' </summary>
	Private nextReceiptID As String

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		receiptBUS = New ReceiptBUS()
		customerBUS = New CustomerBUS()

		LoadCustomers()
		LoadReceipt()
	End Sub

	Private Sub LoadCustomers()
		Dim customers As List(Of CustomerDTO) = New List(Of CustomerDTO)
		Dim result As Result

		result = customerBUS.selectAll(customers)

		customers = customers.OrderBy(Function(c) c.ID).ToList() 'Sort alphabetically

		If (result.FlagResult = True) Then
			colCustomerID.DataSource = customers
			colCustomerID.ValueMember = "ID"
			colCustomerID.DisplayMember = "Name"
		Else
			MetroMessageBox.Show(Me, "Cannot load customers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub LoadReceipt()
		isReceiptLoading = True

		dgvReceipt.Rows.Clear() 'Remove old data
		dgvReceipt.Refresh()

		Dim receipts As List(Of ReceiptDTO) = New List(Of ReceiptDTO)
		Dim result As Result = New Result(True)

		result = receiptBUS.selectALL(receipts)

		If (result.FlagResult = True) Then
			result = receiptBUS.getNextId(nextReceiptID)

			If (result.FlagResult = True) Then
				receipts.Add(New ReceiptDTO(nextReceiptID, Nothing, Date.Now, Nothing))
				receipts = receipts.OrderByDescending(Function(r) r.ID).ToList()

				For Each receipt As ReceiptDTO In receipts
					Dim currentIndex = dgvReceipt.Rows.Add()
					SetReceiptFromCellsIndex(currentIndex, receipt)
				Next
			Else
				MetroMessageBox.Show(Me, "Cannot get next ID of receipt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Console.WriteLine(result.SystemMessage)
			End If
		Else
			MetroMessageBox.Show(Me, "Cannot load Receipt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		isReceiptLoading = False
	End Sub

	Property SelectedReceipt() As ReceiptDTO
		Get
			If (dgvReceipt.CurrentRow IsNot Nothing) Then
				Return GetReceiptFromCellsIndex(dgvReceipt.CurrentRow.Index)
			End If
			Return Nothing
		End Get

		Set(ByVal Value As ReceiptDTO)
			SetReceiptFromCellsIndex(dgvReceipt.CurrentRow.Index, Value)
		End Set
	End Property

	Private Function GetReceiptFromCellsIndex(index As Integer) As ReceiptDTO
		Dim receipt As ReceiptDTO = New ReceiptDTO()
		Dim selectedCells = dgvReceipt.Rows(index).Cells

		receipt.ID = selectedCells("colReceiptID").Value
		receipt.CustomerID = selectedCells("colCustomerID").Value

		Dim dateString = selectedCells("colDate").Value
		If (dateString <> Nothing) Then
			receipt.CollectedDate = Date.ParseExact(
				String.Format("{0:MM/dd/yyyy HH:mm:ss}", dateString),
				New String() {"MM/dd/yyyy HH:mm:ss", "MM/d/yyyy HH:mm:ss", "M/dd/yyyy HH:mm:ss", "M/d/yyyy HH:mm:ss"},
				Globalization.CultureInfo.InvariantCulture,
				Globalization.DateTimeStyles.None)
		End If

		Try
			Dim amount = Convert.ToInt32(selectedCells("colAmount").Value)

			If (amount < 0) Then
				Throw New ArgumentException
			End If

			receipt.CollectedAmount = amount
		Catch ex As FormatException
			selectedCells("colAmount").Value = 0

			MetroMessageBox.Show(Me, "Receipt amount field must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(ex.StackTrace)
			Return Nothing
		Catch ex As ArgumentException
			selectedCells("colAmount").Value = 0

			MetroMessageBox.Show(Me, "Receipt amount out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(ex.StackTrace)
			Return Nothing
		End Try

		Return receipt
	End Function

	Private Sub SetReceiptFromCellsIndex(index As Integer, value As ReceiptDTO)
		dgvReceipt.Rows(index).Cells("colReceiptID").Value = value.ID
		dgvReceipt.Rows(index).Cells("colCustomerID").Value = value.CustomerID
		dgvReceipt.Rows(index).Cells("colDate").Value = String.Format("{0:MM/dd/yyyy HH:mm:ss}", value.CollectedDate)
		dgvReceipt.Rows(index).Cells("colAmount").Value = value.CollectedAmount
	End Sub

	Public Function GetErrorMessage(title As String, result As Result) As String
		Dim errorMessage As String = ""

		errorMessage &= title
		errorMessage &= Environment.NewLine
		errorMessage &= Environment.NewLine
		errorMessage &= result.ApplicationMessage

		Return errorMessage
	End Function

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim receipt = SelectedReceipt
		Dim result As Result

		result = receiptBUS.insert(receipt)

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, "Receipt is added", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
			btnAdd.Enabled = False 'Make sure to disable before loading
			LoadReceipt()
		Else
			MetroMessageBox.Show(Me, GetErrorMessage("Failed to add receipt", result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)

			If (receipt.ID = nextReceiptID) Then
				receiptBUS.delete(receipt.ID)
			End If
			Return
		End If
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim result As Result
		Dim receipt = SelectedReceipt
		result = receiptBUS.update(receipt)

		If (result.FlagResult = False) Then
			MetroMessageBox.Show(Me, GetErrorMessage("Failed to update receipt", result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
			Return
		End If

		MetroMessageBox.Show(Me, "Receipt is updated", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		btnUpdate.Enabled = False
		LoadReceipt()
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim selectedReceiptID = SelectedReceipt.ID
		Dim result As Result

		result = receiptBUS.delete(selectedReceiptID)

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, String.Format("Receipt {0} is deleted", selectedReceiptID),
										"Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MetroMessageBox.Show(Me, String.Format("Failed to delete receipt {0}", selectedReceiptID),
										"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
			Return
		End If

		LoadReceipt()
	End Sub

	Private isChangingReceiptSelection As Boolean = False
	Private lastReceiptSelectionIndex As Integer
	Private Sub dgvReceipt_SelectionChanged(sender As Object, e As EventArgs) Handles dgvReceipt.SelectionChanged
		If (isChangingReceiptSelection) Then
			Return
		End If

		If (btnUpdate.Enabled Or btnAdd.Enabled) Then 'Detect change in receipt. warn to override
			isChangingReceiptSelection = True

			Dim dialogResult = MetroMessageBox.Show(Me, "All changed in Receipt will be overwrite. Do you want to switch?",
										"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

			If (dialogResult = DialogResult.Yes) Then
				btnAdd.Enabled = False
				btnUpdate.Enabled = False
			Else
				dgvReceipt.Rows(lastReceiptSelectionIndex).Selected = True 'Trigger recursion
			End If
		End If

		UpdateCustomer(SelectedReceipt.CustomerID)

		If (SelectedReceipt.ID <> Nothing) Then
			If (SelectedReceipt.ID = nextReceiptID) Then
				colCustomerID.ReadOnly = False
				dgvReceipt.AllowUserToAddRows = True
			Else
				colCustomerID.ReadOnly = True
				dgvReceipt.AllowUserToAddRows = False
			End If
		End If

		lastReceiptSelectionIndex = dgvReceipt.CurrentCell.RowIndex
		isChangingReceiptSelection = False
	End Sub

	Private Sub UpdateCustomer(customerID As String)
		If (customerID = Nothing) Then
			Return
		End If

		Dim customer As CustomerDTO
		Dim result = customerBUS.select_ByID(customerID, customer)

		If (result.FlagResult = True) Then
			txtName.Text = customer.Name
			txtAddress.Text = customer.Address
			txtPhoneNumber.Text = customer.PhoneNumber
			txtEmail.Text = customer.Email
		Else
			MetroMessageBox.Show(Me, "Cannot get customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub dgvReceipt_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReceipt.CellValueChanged
		If (e.RowIndex = -1 Or isReceiptLoading) Then
			Return
		End If

		Dim changedReceipt = GetReceiptFromCellsIndex(e.RowIndex)
		If (changedReceipt Is Nothing) Then
			Return
		End If

		If (changedReceipt.ID = Nothing) Then
			nextReceiptID.IncrementID("RECEIPT", "D4")
			changedReceipt.ID = nextReceiptID
			SelectedReceipt = changedReceipt
			Return
		End If

		If (dgvReceipt.Columns(e.ColumnIndex).Name = "colCustomerID") Then
			UpdateCustomer(SelectedReceipt.CustomerID)
		End If

		If (SelectedReceipt IsNot Nothing) Then
			If (SelectedReceipt.ID Is nextReceiptID) Then
				btnAdd.Enabled = True
			Else
				btnUpdate.Enabled = True
			End If
		End If
	End Sub

	Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
		If (btnAdd.Enabled Or btnUpdate.Enabled) Then
			Dim dialogResult = MetroMessageBox.Show(Me, "All changed in Receipt will be overwrite. Do you want to exit?",
							"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

			If (dialogResult = DialogResult.Yes) Then
				MyBase.OnFormClosing(e)
			Else
				e.Cancel = True
			End If
		End If
	End Sub
End Class

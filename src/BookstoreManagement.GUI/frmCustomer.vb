Imports System.ComponentModel
Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmCustomer
	Private customerBUS As CustomerBUS
	Private invoiceBUS As InvoiceBUS
	Private receiptBUS As ReceiptBUS
	Private selectedCustomer As CustomerDTO
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub
	Protected Overrides Sub Finalize()
		MyBase.Finalize()
	End Sub
	Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		customerBUS = New CustomerBUS()
		invoiceBUS = New InvoiceBUS()
		receiptBUS = New ReceiptBUS()
		loadListCustomer()
	End Sub
	Private Sub loadListCustomer(Optional name As String = "")

		Dim listCustomer = New List(Of CustomerDTO)
		Dim result As Result
		name = txtCustomerName.Text

		If name = String.Empty Then
			result = customerBUS.selectAll(listCustomer)
			If (result.FlagResult = False) Then
				MetroMessageBox.Show(Me, "Cannot load customer list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
		Else
			result = customerBUS.selectAll_BySearch(name, listCustomer)
			If (result.FlagResult = False) Then
				MetroMessageBox.Show(Me, "Cannot load customer list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If
		End If

		dgvCustomer.Columns.Clear()


		dgvCustomer.DataSource = Nothing
		dgvCustomer.DataSource = listCustomer
		dgvCustomer.Columns.Clear()
		dgvCustomer.Columns.Add(colID)
		dgvCustomer.Columns.Add(colName)
		dgvCustomer.Columns.Add(colAddress)
		dgvCustomer.Columns.Add(colEmail)
		dgvCustomer.Columns.Add(colPhoneNumber)
		dgvCustomer.Columns.Add(colCurrentDebt)


		If dgvCustomer.DisplayedRowCount(True) = 0 Then
			btnUpdate.Enabled = False
			btnDelete.Enabled = False
		Else
			btnUpdate.Enabled = True
			btnDelete.Enabled = True
		End If
	End Sub
	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		loadListCustomer(txtCustomerName.Text)
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		txtCustomerName.Text = String.Empty
		loadListCustomer(txtCustomerName.Text)
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim frmCustomerEdit = New frmCustomerEdit(selectedCustomer, False)
		AddHandler frmCustomerEdit.Disposed, AddressOf dispose_addon
		frmCustomerEdit.ShowDialog()
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim currentRowIndex As Integer = dgvCustomer.CurrentCellAddress.Y

		If (-1 < currentRowIndex And currentRowIndex < dgvCustomer.DisplayedRowCount(True)) Then
			Try
				Dim invoices = New List(Of InvoiceDTO)
				invoiceBUS.selectAll_ByCustomer(selectedCustomer.ID, invoices)
				Dim receipts = New List(Of ReceiptDTO)
				receiptBUS.selectAll_ByCustomer(selectedCustomer.ID, receipts)

				If (invoices.Count > 0 Or receipts.Count > 0) Then
					MetroMessageBox.Show(Me, "Cannot delete Customer, check Invoice and Receipt for constraint", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If

				Dim result As Result
				result = customerBUS.delete(selectedCustomer.ID)

				If (result.FlagResult = True) Then
					loadListCustomer()

					If (currentRowIndex >= dgvCustomer.Rows.Count) Then
						currentRowIndex = currentRowIndex - 1
					End If

					If (currentRowIndex >= 0) Then
						dgvCustomer.Rows(currentRowIndex).Selected = True
					End If

					MetroMessageBox.Show(Me, "Delete customer succeed", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End If

			Catch ex As Exception

				Debug.WriteLine(ex.StackTrace)
			End Try
		End If
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim frmCustomerEdit = New frmCustomerEdit(selectedCustomer, True)
		AddHandler frmCustomerEdit.Disposed, AddressOf dispose_addon
		frmCustomerEdit.ShowDialog()
	End Sub

	Private Sub dgvCustomer_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCustomer.SelectionChanged
		Dim currentRowIndex As Integer = dgvCustomer.CurrentCellAddress.Y
		If (-1 < currentRowIndex And currentRowIndex < dgvCustomer.DisplayedRowCount(True)) Then
			Try
				Dim ID = dgvCustomer.Rows(currentRowIndex).Cells(0).Value.ToString
				customerBUS.select_ByID(ID, selectedCustomer)
			Catch ex As Exception
				Debug.WriteLine(ex.StackTrace)
			End Try
		End If
	End Sub

	Private Sub dispose_addon(sender As Object, e As EventArgs)
		loadListCustomer(txtCustomerName.Text)
	End Sub
End Class
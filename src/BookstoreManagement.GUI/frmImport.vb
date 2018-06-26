Imports System.ComponentModel
Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmImport
	Private isImportLoading As Boolean
	Private isImportDetailLoading As Boolean

	Private importBUS As ImportBUS
	Private importDetailBUS As ImportDetailBUS
	Private bookBUS As BookBUS

	''' <summary>
	''' If selected import ID = nextImportID, enable add button, otherwise enable update button
	''' </summary>
	Private nextImportID As String

	''' <summary>
	''' List of ImportDetailDTO that has changed since last add/update
	''' </summary>
	Private importDetailsToUpdate As List(Of ImportDetailDTO) = New List(Of ImportDetailDTO)

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		importBUS = New ImportBUS()
		importDetailBUS = New ImportDetailBUS()
		bookBUS = New BookBUS()

		LoadImport()
	End Sub

	Private Sub LoadImport()
		isImportLoading = True

		Dim _imports As List(Of ImportDTO) = New List(Of ImportDTO)
		Dim result As Result

		result = importBUS.selectALL(_imports)

		If (result.FlagResult = True) Then ' Add next Import ID
			result = importBUS.getNextId(nextImportID)

			If (result.FlagResult = True) Then
				_imports.Add(New ImportDTO(nextImportID, Date.Now.ToShortDateString()))

				'TODO: Remove the lambda after do the trimming part in db
				_imports = _imports.OrderByDescending(Function(import) import.ID).ToList()

				For Each _import As ImportDTO In _imports
					Dim currentIndex = dgvImport.Rows.Add()

					dgvImport.Rows(currentIndex).Cells("colImportID").Value = _import.ID
					dgvImport.Rows(currentIndex).Cells("colImportDate").Value = _import.ImportDate.ToShortDateString()
				Next
			Else
				MessageBox.Show("Cannot get next ID of import", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Console.WriteLine(result.SystemMessage)
			End If
		Else
			MessageBox.Show("Cannot load import", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		isImportLoading = False
	End Sub

	Private Sub LoadImportDetail(importID As String)
		isImportDetailLoading = True

		Dim importDetails As List(Of ImportDetailDTO) = New List(Of ImportDetailDTO)
		Dim result As Result

		result = importDetailBUS.selectAll_ByImport(importID, importDetails)

		If (result.FlagResult = False) Then
			importDetails.Add(New ImportDetailDTO(0, 0, Nothing, Nothing, Nothing))
		End If

		LoadBooks()

		For Each importDetail As ImportDetailDTO In importDetails
			Dim currentIndex = dgvImportDetail.Rows.Add()

			dgvImportDetail.Rows(currentIndex).Cells("colImportDetailID").Value = importDetail.ID
			dgvImportDetail.Rows(currentIndex).Cells("colBookID").Value = importDetail.BookID
			dgvImportDetail.Rows(currentIndex).Cells("colImportAmount").Value = importDetail.ImportAmount
			'dgvImportDetail.Rows(currentIndex).Cells("colCurrentAmount").Value = importDetail.CurrentAmount
			dgvImportDetail.Rows(currentIndex).Cells("colImportPrice").Value = importDetail.ImportPrice
		Next

		isImportDetailLoading = False
	End Sub

	Private Sub LoadBooks()
		isImportLoading = True

		Dim books As List(Of BookDTO) = New List(Of BookDTO)
		Dim result As Result

		result = bookBUS.selectAll(books)

		'TODO: Remove the lambda after do the trimming part in db
		books = books.OrderByDescending(Function(import) import.ID).Select(
		Function(import)
			import.ID = import.ID.Trim()
			Return import
		End Function).ToList()

		If (result.FlagResult = True) Then
			colBookID.DataSource = books
			colBookID.ValueMember = "ID"
			colBookID.DisplayMember = "Name"
		Else
			MessageBox.Show("Cannot load books", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		isImportLoading = False
	End Sub

	Private Function GetImportDetailFromCells(cells As DataGridViewCellCollection) As ImportDetailDTO
		Dim importDetail As ImportDetailDTO = New ImportDetailDTO()

		importDetail.ID = cells("colImportDetailID").Value
		importDetail.BookID = cells("colBookID").Value
		importDetail.ImportAmount = cells("colImportAmount").Value
		'importDetail.CurrentAmount = cells("colCurrentAmount").Value
		importDetail.ImportPrice = cells("colImportPrice").Value

		Return importDetail
	End Function

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim importDTO = New ImportDTO()
		Dim importDetails = New List(Of ImportDetailDTO)

		'txtImportID.Text = dgvImportDetail.Rows(0).Cells("ImportID").Value

		For Each row As DataGridViewRow In dgvImportDetail.Rows
			If (row.IsNewRow) Then
				Exit For
			End If

			Dim importDetail As ImportDetailDTO = GetImportDetailFromCells(row.Cells)
			importDetails.Add(importDetail)
		Next

		Dim result As Result

		'importDTO.DateImport = dtpReceivedDate.Value
		result = importBUS.insert(importDTO)

		If (result.FlagResult = True) Then
			MessageBox.Show("Import is added", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MessageBox.Show("Failed to add import", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		result = importDetailBUS.insertAll(importDetails)

		If (result.FlagResult = True) Then
			MessageBox.Show("Import detail is added", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MessageBox.Show("Failed to add import detail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		LoadImport() ' Reload import to reflect new changes and add nextId
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim importDetails = New List(Of ImportDetailDTO)

		'txtImportID.Text = dgvImportDetail.Rows(0).Cells("ImportID").Value

		For Each row As DataGridViewRow In dgvImportDetail.Rows
			If (row.IsNewRow) Then
				Exit For
			End If

			Dim importDetail As ImportDetailDTO = GetImportDetailFromCells(row.Cells)
			importDetails.Add(importDetail)
		Next

		Dim result As Result

		For Each importDetail As ImportDetailDTO In importDetailsToUpdate
			result = importDetailBUS.update(importDetail)

			If (result.FlagResult = True) Then
				MessageBox.Show("Import detail is updated", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				MessageBox.Show("Failed to update import detail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Console.WriteLine(result.SystemMessage)
				Exit For
			End If
		Next

		LoadImportDetailsFromSelectedImport()
		importDetailsToUpdate.Clear()

		btnUpdate.Enabled = False
	End Sub

	Private isChangingImportSelection As Boolean = False
	Private lastImportSelectionIndex As Integer
	Private Sub dgvImport_SelectionChanged(sender As Object, e As EventArgs) Handles dgvImport.SelectionChanged
		If (isChangingImportSelection) Then
			Return
		End If

		If (btnUpdate.Enabled) Then 'Detect change in ImportDetail. warn to override
			isChangingImportSelection = True

			Dim dialogResult = MetroMessageBox.Show(Me, "All changed in Import Detail will be overwrite. Do you want to switch?",
										"MetroMessagebox", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

			If (dialogResult = DialogResult.Yes) Then
				LoadImportDetailsFromSelectedImport()
			Else
				dgvImport.Rows(lastImportSelectionIndex).Selected = True
			End If
		Else
			LoadImportDetailsFromSelectedImport()
		End If

		lastImportSelectionIndex = dgvImport.CurrentCell.RowIndex
		isChangingImportSelection = False
	End Sub

	Private Sub LoadImportDetailsFromSelectedImport()
		Dim selectedImportID = dgvImport.Rows(dgvImport.CurrentRow.Index).Cells("colImportID").Value

		If (selectedImportID Is Nothing) Then
			Return
		End If

		If (selectedImportID = nextImportID) Then
			btnAdd.Enabled = True
		Else
			btnAdd.Enabled = False
		End If
		btnUpdate.Enabled = False

		dgvImportDetail.Rows.Clear()
		dgvImportDetail.Refresh()

		LoadImportDetail(selectedImportID)
	End Sub

	Private Sub dgvImportDetail_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImportDetail.CellValueChanged
		If (e.RowIndex = -1 Or isImportDetailLoading) Then
			Return
		End If

		Dim changedImportDetail = GetImportDetailFromCells(dgvImportDetail.Rows(e.RowIndex).Cells)
		Dim duplicatedItems = importDetailsToUpdate.
			Where(Function(detail) detail.ID = changedImportDetail.ID)

		If (duplicatedItems.Count = 0) Then
			importDetailsToUpdate.Add(changedImportDetail)
		Else
			Dim oldIndex = importDetailsToUpdate.IndexOf(duplicatedItems.First())
			importDetailsToUpdate(oldIndex) = changedImportDetail
		End If

		btnUpdate.Enabled = True
	End Sub
End Class

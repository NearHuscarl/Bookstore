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
	''' If selected import ID = nextImportID, enable add button, otherwise disable it
	''' </summary>
	Private nextImportID As String
	Private nextImportDetailID As String

	''' <summary>
	''' List of ImportDetailDTO that has changed since last add/update
	''' </summary>
	Private importDetailsToUpdate As List(Of ImportDetailDTO) = New List(Of ImportDetailDTO)

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		importBUS = New ImportBUS()
		importDetailBUS = New ImportDetailBUS()
		bookBUS = New BookBUS()

		LoadImport()
	End Sub

	Private Sub LoadImport()
		isImportLoading = True

		dgvImport.Rows.Clear() 'Remove old data
		dgvImport.Refresh()

		Dim _imports As List(Of ImportDTO) = New List(Of ImportDTO)
		Dim result As Result

		result = importBUS.selectAll(_imports)

		If (result.FlagResult = True) Then ' Add next Import ID
			result = importBUS.getNextId(nextImportID)

			If (result.FlagResult = True) Then
				_imports.Add(New ImportDTO(nextImportID, Date.Now.ToShortDateString()))
				_imports = _imports.OrderByDescending(Function(import) import.ID).ToList()

				For Each _import As ImportDTO In _imports
					Dim currentIndex = dgvImport.Rows.Add()
					SetImportFromCellsIndex(currentIndex, _import)
				Next
			Else
				MetroMessageBox.Show(Me, "Cannot get next ID of import", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Console.WriteLine(result.SystemMessage)
			End If
		Else
			MetroMessageBox.Show(Me, "Cannot load import", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		LoadImportDetailsFromSelectedImport()
		isImportLoading = False
	End Sub

	Private Sub LoadImportDetail(importID As String)
		isImportDetailLoading = True

		dgvImportDetail.Rows.Clear() 'Remove old data
		dgvImportDetail.Refresh()

		Dim importDetails As List(Of ImportDetailDTO) = New List(Of ImportDetailDTO)
		Dim result As Result = New Result(True)

		If (importID = nextImportID) Then
			result = importDetailBUS.getNextId(nextImportDetailID)

			If (result.FlagResult = True) Then
				importDetails.Add(New ImportDetailDTO(nextImportDetailID, nextImportID, Nothing, Nothing, Nothing))
			Else
				MetroMessageBox.Show(Me, "Cannot get next Import Detail ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Console.WriteLine(result.SystemMessage)
			End If
		Else
			result = importDetailBUS.selectAll_ByImport(importID, importDetails)
		End If

		If (result.FlagResult = True) Then
			LoadBooks()

			For Each importDetail As ImportDetailDTO In importDetails
				Dim currentIndex = dgvImportDetail.Rows.Add()

				dgvImportDetail.Rows(currentIndex).Cells("colImportDetailID").Value = importDetail.ID
				dgvImportDetail.Rows(currentIndex).Cells("colBookID").Value = importDetail.BookID
				dgvImportDetail.Rows(currentIndex).Cells("colImportAmount").Value = importDetail.ImportAmount
				dgvImportDetail.Rows(currentIndex).Cells("colImportPrice").Value = importDetail.ImportPrice
			Next
		Else
			MetroMessageBox.Show(Me, "Cannot load Import Detail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		isImportDetailLoading = False
	End Sub

	Private Sub LoadBooks()
		isImportLoading = True

		Dim books As List(Of BookDTO) = New List(Of BookDTO)
		Dim result As Result

		result = bookBUS.selectAll(books)

		books = books.OrderBy(Function(import) import.ID).ToList() 'Sort alphabetically

		If (result.FlagResult = True) Then
			colBookID.DataSource = books
			colBookID.ValueMember = "ID"
			colBookID.DisplayMember = "Name"
		Else
			MetroMessageBox.Show(Me, "Cannot load books", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		isImportLoading = False
	End Sub

	Property SelectedImport() As ImportDTO
		Get
			If (dgvImport.CurrentRow IsNot Nothing) Then
				Return GetImportFromCellsIndex(dgvImport.CurrentRow.Index)
			End If
			Return Nothing
		End Get

		Set(ByVal Value As ImportDTO)
			SetImportFromCellsIndex(dgvImport.CurrentRow.Index, Value)
		End Set
	End Property

	Property SelectedImportDetail() As ImportDetailDTO
		Get
			If (dgvImportDetail.CurrentRow IsNot Nothing) Then
				Return GetImportDetailFromCellsIndex(dgvImportDetail.CurrentRow.Index)
			End If
			Return Nothing
		End Get

		Set(ByVal Value As ImportDetailDTO)
			SetImportDetailFromCellsIndex(dgvImportDetail.CurrentRow.Index, Value)
		End Set
	End Property

	Private Function GetImportDetailFromCellsIndex(index As Integer) As ImportDetailDTO
		Dim importDetail As ImportDetailDTO = New ImportDetailDTO()
		Dim selectedCells = dgvImportDetail.Rows(index).Cells
		Dim selectedImportCells = dgvImport.Rows(dgvImport.CurrentRow.Index).Cells

		importDetail.ID = selectedCells("colImportDetailID").Value
		importDetail.ImportID = selectedImportCells("colImportID").Value
		importDetail.BookID = selectedCells("colBookID").Value

		Try
			Dim importAmount = Convert.ToInt32(selectedCells("colImportAmount").Value)
			importDetail.ImportAmount = importAmount
		Catch ex As FormatException
			importDetail.ImportAmount = 0
			selectedCells("colImportAmount").Value = importDetail.ImportAmount

			MetroMessageBox.Show(Me, "Import amount field must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(ex.StackTrace)
		End Try

		Try
			Dim importPrice = Convert.ToInt32(selectedCells("colImportPrice").Value)
			importDetail.ImportPrice = importPrice
		Catch ex As FormatException
			importDetail.ImportPrice = 0
			selectedCells("colImportPrice").Value = importDetail.ImportPrice

			MetroMessageBox.Show(Me, "Import price field must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(ex.StackTrace)
		End Try

		Return importDetail
	End Function

	Private Sub SetImportDetailFromCellsIndex(index As Integer, value As ImportDetailDTO)
		dgvImportDetail.Rows(index).Cells("colImportDetailID").Value = value.ID
		dgvImportDetail.Rows(index).Cells("colBookID").Value = value.BookID
		dgvImportDetail.Rows(index).Cells("colImportAmount").Value = value.ImportAmount
		dgvImportDetail.Rows(index).Cells("colImportPrice").Value = value.ImportPrice
	End Sub

	Private Function GetImportFromCellsIndex(index As Integer) As ImportDTO
		Dim import As ImportDTO = New ImportDTO()
		Dim selectedCells = dgvImport.Rows(index).Cells
		Dim dateString = selectedCells("colImportDate").Value

		import.ID = selectedCells("colImportID").Value

		If (dateString <> Nothing) Then
			import.ImportDate = Date.ParseExact(
				dateString,
				New String() {"MM/dd/yyyy", "MM/d/yyyy", "M/dd/yyyy", "M/d/yyyy"},
				Globalization.CultureInfo.InvariantCulture,
				Globalization.DateTimeStyles.None)
		End If

		Return import
	End Function

	Private Sub SetImportFromCellsIndex(index As Integer, value As ImportDTO)
		dgvImport.Rows(index).Cells("colImportID").Value = value.ID
		dgvImport.Rows(index).Cells("colImportDate").Value = value.ImportDate
	End Sub

	Private Sub LoadImportDetailsFromSelectedImport()
		If (SelectedImport Is Nothing) Then
			Return
		End If

		Dim selectedImportID = SelectedImport.ID

		If (selectedImportID Is Nothing) Then
			Return
		End If

		If (selectedImportID = nextImportID) Then
			btnAdd.Enabled = True
		Else
			btnAdd.Enabled = False
		End If
		btnUpdate.Enabled = False

		LoadImportDetail(selectedImportID)
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim import = SelectedImport
		Dim result As Result

		result = importBUS.insert(import)

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, "Import is added", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MetroMessageBox.Show(Me, "Failed to add import", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		Dim importDetails = New List(Of ImportDetailDTO)

		For Each row As DataGridViewRow In dgvImportDetail.Rows
			If (row.IsNewRow) Then
				Exit For
			End If

			Dim importDetail = GetImportDetailFromCellsIndex(row.Index)
			importDetails.Add(importDetail)
		Next

		result = importDetailBUS.insertAll(importDetails)

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, "Import detail is added", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			If (import.ID = nextImportID) Then
				importBUS.delete(import.ID)
			End If

			Dim errorMessage As String = ""

			errorMessage &= "Failed to add import detail"
			errorMessage &= Environment.NewLine
			errorMessage &= Environment.NewLine
			errorMessage &= result.ApplicationMessage

			MetroMessageBox.Show(Me, errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		LoadImport() ' Reload import to reflect new changes and add nextId
	End Sub

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim importDetails = New List(Of ImportDetailDTO)

		For Each row As DataGridViewRow In dgvImportDetail.Rows
			If (row.IsNewRow) Then
				Exit For
			End If

			Dim importDetail As ImportDetailDTO = GetImportDetailFromCellsIndex(row.Index)
			importDetails.Add(importDetail)
		Next

		Dim result As Result

		For Each importDetail As ImportDetailDTO In importDetailsToUpdate
			result = importDetailBUS.update(importDetail)

			If (result.FlagResult = True) Then
				MetroMessageBox.Show(Me, "Import detail is updated", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				MetroMessageBox.Show(Me, "Failed to update import detail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Console.WriteLine(result.SystemMessage)
				Exit For
			End If
		Next

		LoadImportDetailsFromSelectedImport()
		importDetailsToUpdate.Clear()

		btnUpdate.Enabled = False
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim selectedImportDetailID = SelectedImportDetail.ID
		Dim result As Result

		result = importDetailBUS.delete(selectedImportDetailID)

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, String.Format("Import detail {0} is deleted", selectedImportDetailID),
										"Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MetroMessageBox.Show(Me, String.Format("Failed to delete import detail {0}", selectedImportDetailID),
										"Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		LoadImportDetailsFromSelectedImport()
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
				dgvImport.Rows(lastImportSelectionIndex).Selected = True 'Trigger recursion
			End If
		Else
			LoadImportDetailsFromSelectedImport()
		End If

		lastImportSelectionIndex = dgvImport.CurrentCell.RowIndex
		isChangingImportSelection = False
	End Sub

	Private Sub dgvImportDetail_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvImportDetail.CellValueChanged
		If (e.RowIndex = -1 Or isImportDetailLoading) Then
			Return
		End If

		Dim changedImportDetail = GetImportDetailFromCellsIndex(e.RowIndex)

		If (changedImportDetail.ID = Nothing) Then
			nextImportDetailID.IncrementID("IMPORTDETAIL", "D4")
			changedImportDetail.ID = nextImportDetailID
			SelectedImportDetail = changedImportDetail
			Return
		End If

		Dim duplicatedItems = importDetailsToUpdate.
			Where(Function(detail) detail.ID = changedImportDetail.ID)

		If (duplicatedItems.Count = 0) Then
			importDetailsToUpdate.Add(changedImportDetail)
		Else
			Dim oldIndex = importDetailsToUpdate.IndexOf(duplicatedItems.First())
			importDetailsToUpdate(oldIndex) = changedImportDetail
		End If

		If (SelectedImport IsNot Nothing And SelectedImport.ID IsNot nextImportID) Then
			btnUpdate.Enabled = True
		End If
	End Sub
End Class

Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports Utility

Public Class frmImport
	Private importBUS As ImportBUS
	Private importDetailBUS As ImportDetailBUS

	Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		importBUS = New ImportBUS()
		importDetailBUS = New ImportDetailBUS()
		ShowNextID()
	End Sub

	Private Sub ShowNextID()
		Dim nextId As Integer
		Dim result As Result

		result = importDetailBUS.getNextId(nextId)

		If (result.FlagResult = True) Then
			dgvImport.Rows.Add({0, nextId.ToString(), Nothing, Nothing, Nothing, Nothing})
		Else
			MessageBox.Show("Cannot get the next ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim importDTO = New ImportDTO()
		Dim importDetailDTOs = New List(Of ImportDetailDTO)

		For Each row As DataGridViewRow In dgvImport.Rows
			If (row.IsNewRow) Then
				Exit For
			End If

			Dim importDetailDTO As ImportDetailDTO = New ImportDetailDTO()

			importDetailDTO.ID = row.Cells("ID").Value
			importDetailDTO.ImportID = row.Cells("ImportID").Value
			importDetailDTO.BookID = row.Cells("BookID").Value
			importDetailDTO.ImportAmount = row.Cells("ImportAmount").Value
			importDetailDTO.CurrentAmount = row.Cells("CurrentAmount").Value
			importDetailDTO.ImportPrice = row.Cells("ImportPrice").Value

			importDetailDTOs.Add(importDetailDTO)
		Next

		Dim result As Result

		importDTO.DateImport = dtpReceivedDate.Value
		result = importBUS.insert(importDTO)

		If (result.FlagResult = True) Then
			MessageBox.Show("Import is added", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MessageBox.Show("Failed to add import", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If

		result = importDetailBUS.insertAll(importDetailDTOs)

		If (result.FlagResult = True) Then
			MessageBox.Show("Import detail is added", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MessageBox.Show("Failed to add import detail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		dgvImport.Rows.Clear()
		dgvImport.Refresh()

		ShowNextID()
	End Sub
End Class

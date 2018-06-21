Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports Utility

Public Class frmImport
	Private bookImportBUS As BookImportBUS

	Private Sub frmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		bookImportBUS = New BookImportBUS()
		ShowNextID()
	End Sub

	Private Sub ShowNextID()
		Dim nextId As Integer
		Dim result As Result

		result = bookImportBUS.getNextId(nextId)

		If (result.FlagResult = True) Then
			dgvImport.Rows.Add({nextId.ToString(), Nothing, Nothing, Nothing, Nothing, Nothing})
		Else
			MessageBox.Show("Cannot get the next reader ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Dim receipt = New ReceiptDTO()

		For Each row As DataGridViewRow In dgvImport.Rows
			If (row.IsNewRow) Then
				Exit For
			End If

			Dim importInfo As ImportDTO = New ImportDTO()

			importInfo.ID = row.Cells("colID").Value
			importInfo.Name = row.Cells("colName").Value
			importInfo.Category = row.Cells("colCategory").Value
			importInfo.Author = row.Cells("colAuthor").Value
			importInfo.ImportAmount = row.Cells("colAmount").Value
			importInfo.ImportPrice = row.Cells("colPrice").Value

			receipt.BookImports.Add(importInfo)
		Next

		Dim result As Result

		receipt.ReceivedDate = dtpReceivedDate.Value
		result = bookImportBUS.insert(receipt)

		If (result.FlagResult = True) Then
			MessageBox.Show("Books added to import list", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MessageBox.Show("Books added failed failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		dgvImport.Rows.Clear()
		dgvImport.Refresh()

		ShowNextID()
	End Sub
End Class

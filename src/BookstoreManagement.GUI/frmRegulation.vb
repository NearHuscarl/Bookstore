Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmRegulation
	Private parameterBUS As ParameterBUS

	Private Sub frmRegulation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		parameterBUS = New ParameterBUS()

		LoadParameters()
	End Sub

	Private Sub LoadParameters()
		Dim parameters As ParameterDTO
		Dim result = parameterBUS.selectAll(parameters)

		If (result.FlagResult = True) Then
			ckbUseRegulation.Checked = parameters.UseRegulation
			txtMinImportAmount.Text = parameters.MinImportAmount
			txtMaxStockBeforeImport.Text = parameters.MaxStockBeforeImport
			txtMaxDebt.Text = parameters.MaxDebt.ToString("N0")
			txtMinStockAfterSales.Text = parameters.MinStockAfterSales
			UpdateTextBoxStates()
		Else
			MetroMessageBox.Show(Me, "Cannot load regulation options", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Function SaveParameters() As Result
		Dim parameters = New ParameterDTO()

		parameters.UseRegulation = ckbUseRegulation.Checked
		parameters.MinImportAmount = txtMinImportAmount.Text
		parameters.MaxStockBeforeImport = txtMaxStockBeforeImport.Text
		parameters.MaxDebt = txtMaxDebt.Text
		parameters.MinStockAfterSales = txtMinStockAfterSales.Text

		Return parameterBUS.update(parameters)
	End Function

	Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
		Dim result = SaveParameters()

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, "Regulation is updated", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MetroMessageBox.Show(Me, "Cannot update regulation options", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(Result.SystemMessage)
		End If
	End Sub

	Private Sub UpdateTextBoxStates()
		If (ckbUseRegulation.Checked) Then
			txtMinImportAmount.Enabled = True
			txtMaxStockBeforeImport.Enabled = True
			txtMaxDebt.Enabled = True
			txtMinStockAfterSales.Enabled = True
		Else
			txtMinImportAmount.Enabled = False
			txtMaxStockBeforeImport.Enabled = False
			txtMaxDebt.Enabled = False
			txtMinStockAfterSales.Enabled = False
		End If
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		Dim result = SaveParameters()

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, "Regulation is updated", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Me.Close()
		Else
			MetroMessageBox.Show(Me, "Cannot update regulation options", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub ckbUseRegulation_Click(sender As Object, e As EventArgs) Handles ckbUseRegulation.Click
		UpdateTextBoxStates()
	End Sub
End Class

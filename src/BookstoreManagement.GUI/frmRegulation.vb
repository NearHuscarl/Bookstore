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

	Public Function GetErrorMessage(title As String, result As Result) As String
		Dim errorMessage As String = ""

		errorMessage &= title
		errorMessage &= Environment.NewLine
		errorMessage &= Environment.NewLine
		errorMessage &= result.ApplicationMessage

		Return errorMessage
	End Function

	Private Function SaveParameters() As Result
		Dim parameters = New ParameterDTO()

		parameters.UseRegulation = ckbUseRegulation.Checked

		Try
			parameters.MinImportAmount = Convert.ToInt32(txtMinImportAmount.Text)
		Catch ex As FormatException
			txtMinImportAmount.Text = 0
			Return New Result(False, "Minimum Import Amount must be a number", "")
		End Try

		Try
			parameters.MaxStockBeforeImport = Convert.ToInt32(txtMaxStockBeforeImport.Text)
		Catch ex As FormatException
			txtMaxStockBeforeImport.Text = 0
			Return New Result(False, "Maximum Stock Before Import must be a number", "")
		End Try

		Try
			parameters.MaxDebt = Convert.ToInt32(txtMaxDebt.Text)
		Catch ex As FormatException
			txtMaxDebt.Text = 0
			Return New Result(False, "Maximum Debt must be a number", "")
		End Try

		Try
			parameters.MinStockAfterSales = Convert.ToInt32(txtMinStockAfterSales.Text)
		Catch ex As FormatException
			txtMinStockAfterSales.Text = 0
			Return New Result(False, "Minimum Stock After Sales must be a number", "")
		End Try

		Return parameterBUS.update(parameters)
	End Function

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

	Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
		Dim result = SaveParameters()

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, GetErrorMessage("Update options successfully", result), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
		Else
			MetroMessageBox.Show(Me, GetErrorMessage("Update options failed", result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(Result.SystemMessage)
		End If
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		Dim result = SaveParameters()

		If (result.FlagResult = True) Then
			MetroMessageBox.Show(Me, GetErrorMessage("Update options successfully", result), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Me.Close()
		Else
			MetroMessageBox.Show(Me, GetErrorMessage("Update options failed", result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub ckbUseRegulation_Click(sender As Object, e As EventArgs) Handles ckbUseRegulation.Click
		UpdateTextBoxStates()
	End Sub
End Class

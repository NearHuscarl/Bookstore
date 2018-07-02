Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmDebtReport
	Private customerBUS As CustomerBUS
	Private debtReportBUS As DebtReportBUS

	Private Sub LoadCustomers()
		Dim customers As List(Of CustomerDTO) = New List(Of CustomerDTO)
		Dim result As Result

		result = customerBUS.selectAll(customers)

		customers = customers.OrderBy(Function(import) import.ID).ToList() 'Sort alphabetically

		If (result.FlagResult = True) Then
			colCustomerName.DataSource = customers
			colCustomerName.ValueMember = "ID"
			colCustomerName.DisplayMember = "Name"
		Else
			MetroMessageBox.Show(Me, "Cannot load customers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub frmDebtReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		customerBUS = New CustomerBUS()
		debtReportBUS = New DebtReportBUS()

		lblID.Visible = False
		txtID.Visible = False
		btnExport.Visible = False
		LoadCustomers()
	End Sub

	Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
		Dim debtReportDetails = debtReportBUS.GetDebtReports(dtpReportDate.Value)

		dgvReport.Columns.Clear()

		dgvReport.DataSource = Nothing
		dgvReport.DataSource = debtReportDetails

		dgvReport.Columns.Clear()
		dgvReport.Columns.Add(colID)
		dgvReport.Columns.Add(colCustomerName)
		dgvReport.Columns.Add(colOpeningDebt)
		dgvReport.Columns.Add(colNewDebt)
		dgvReport.Columns.Add(colClosingDebt)
	End Sub
End Class
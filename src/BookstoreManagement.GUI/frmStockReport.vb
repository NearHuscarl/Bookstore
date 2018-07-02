Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmStockReport
	Private bookBUS As BookBUS
	Private stockReportBUS As StockReportBUS

	Private Sub LoadBooks()
		Dim books As List(Of BookDTO) = New List(Of BookDTO)
		Dim result As Result

		result = bookBUS.selectAll(books)

		books = books.OrderBy(Function(import) import.ID).ToList() 'Sort alphabetically

		If (result.FlagResult = True) Then
			colBookName.DataSource = books
			colBookName.ValueMember = "ID"
			colBookName.DisplayMember = "Name"
		Else
			MetroMessageBox.Show(Me, "Cannot load books", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub frmStockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		bookBUS = New BookBUS()
		stockReportBUS = New StockReportBUS()

		lblID.Visible = False
		txtID.Visible = False
		btnReport.Visible = False

		LoadBooks()
	End Sub

	Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
		Dim stockReportDetails = stockReportBUS.GetStockReports(dtpReportDate.Value)

		dgvReport.Columns.Clear()

		dgvReport.DataSource = Nothing
		dgvReport.DataSource = stockReportDetails

		dgvReport.Columns.Clear()
		dgvReport.Columns.Add(colID)
		dgvReport.Columns.Add(colBookName)
		dgvReport.Columns.Add(colOpeningStock)
		dgvReport.Columns.Add(colNewStock)
		dgvReport.Columns.Add(colClosingStock)
	End Sub
End Class
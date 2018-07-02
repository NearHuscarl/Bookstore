Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmDebtReport
	Private customerBUS As CustomerBUS
	Private invoiceBUS As InvoiceBUS
	Private invoiceDetailBUS As InvoiceDetailBUS
	Private receiptBUS As ReceiptBUS
	Private debtReportBUS As DebtReportBUS
	Private debtReportDTO As DebtReportDTO
	Private debtReportDetailsDTO As List(Of DebtReportDetailDTO)

	Private Sub getNextID(debtReportDTO As DebtReportDTO)
		debtReportBUS.getNextId(debtReportDTO.ID)
	End Sub

	Private Sub calDebtReport()
		Dim tempCustomerIDList = New List(Of String)
		debtReportDetailsDTO.Clear()

		'opening
		Dim invoicesDTO = New List(Of InvoiceDTO)
		invoiceBUS.selectAll_ByBeforeDate(dtpReportDate.Value, invoicesDTO)

		For Each invoiceDTO As InvoiceDTO In invoicesDTO
			Dim invoiceDetailsDTO = New List(Of InvoiceDetailDTO)
			invoiceDetailBUS.selectAll_ByInvoice(invoiceDTO.ID, invoiceDetailsDTO)

			If (Not tempCustomerIDList.Contains(invoiceDTO.CustomerID)) Then
				tempCustomerIDList.Add(invoiceDTO.CustomerID)
				debtReportDetailsDTO.Add(New DebtReportDetailDTO("", debtReportDTO.ID, invoiceDTO.CustomerID, 0, 0, 0))
			End If
			Dim tempSum As Integer = 0

			For Each invoiceDetailDTO As InvoiceDetailDTO In invoiceDetailsDTO
				tempSum += (invoiceDetailDTO.SalesPrice * invoiceDetailDTO.Amount)
			Next

			For Each debtReportDetailDTO As DebtReportDetailDTO In debtReportDetailsDTO
				If (debtReportDetailDTO.CustomerID = invoiceDTO.CustomerID) Then
					debtReportDetailDTO.OpeningDebt += tempSum
				End If
			Next
		Next

		Dim receiptsDTO = New List(Of ReceiptDTO)
		receiptBUS.selectAll_ByBeforeDate(dtpReportDate.Value, receiptsDTO)

		For Each receiptDTO As ReceiptDTO In receiptsDTO
			For Each debtReportDetailDTO As DebtReportDetailDTO In debtReportDetailsDTO
				If (debtReportDetailDTO.CustomerID = receiptDTO.CustomerID) Then
					debtReportDetailDTO.OpeningDebt -= receiptDTO.CollectedAmount
				End If
			Next
		Next

		'closing
		invoicesDTO = New List(Of InvoiceDTO)
		invoiceBUS.selectAll_ByBeforeDate(dtpReportDate.Value.AddMonths(1), invoicesDTO)

		For Each invoiceDTO As InvoiceDTO In invoicesDTO
			Dim invoiceDetailsDTO = New List(Of InvoiceDetailDTO)
			invoiceDetailBUS.selectAll_ByInvoice(invoiceDTO.ID, invoiceDetailsDTO)

			If (Not tempCustomerIDList.Contains(invoiceDTO.CustomerID)) Then
				tempCustomerIDList.Add(invoiceDTO.CustomerID)
				debtReportDetailsDTO.Add(New DebtReportDetailDTO("", debtReportDTO.ID, invoiceDTO.CustomerID, 0, 0, 0))
			End If
			Dim tempSum As Integer = 0

			For Each invoiceDetailDTO As InvoiceDetailDTO In invoiceDetailsDTO
				tempSum += (invoiceDetailDTO.SalesPrice * invoiceDetailDTO.Amount)
			Next

			For Each debtReportDetailDTO As DebtReportDetailDTO In debtReportDetailsDTO
				If (debtReportDetailDTO.CustomerID = invoiceDTO.CustomerID) Then
					debtReportDetailDTO.ClosingDebt += tempSum
				End If
			Next
		Next

		receiptsDTO = New List(Of ReceiptDTO)
		receiptBUS.selectAll_ByBeforeDate(dtpReportDate.Value.AddMonths(1), receiptsDTO)

		For Each receiptDTO As ReceiptDTO In receiptsDTO
			For Each debtReportDetailDTO As DebtReportDetailDTO In debtReportDetailsDTO
				If (debtReportDetailDTO.CustomerID = receiptDTO.CustomerID) Then
					debtReportDetailDTO.ClosingDebt -= receiptDTO.CollectedAmount
				End If
			Next
		Next

		'new
		For Each debtReportDetailDTO As DebtReportDetailDTO In debtReportDetailsDTO
			debtReportDetailDTO.NewDebt = debtReportDetailDTO.ClosingDebt - debtReportDetailDTO.OpeningDebt
		Next
	End Sub

	Private Sub loadListCustomer()
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
		customerBUS = New CustomerBUS
		invoiceBUS = New InvoiceBUS
		invoiceDetailBUS = New InvoiceDetailBUS
		receiptBUS = New ReceiptBUS
		debtReportBUS = New DebtReportBUS
		debtReportDTO = New DebtReportDTO
		debtReportDetailsDTO = New List(Of DebtReportDetailDTO)
		lblID.Visible = False
		txtID.Visible = False
		btnExport.Visible = False
		loadListCustomer()
	End Sub

	Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
		calDebtReport()
		dgvReport.Columns.Clear()


		dgvReport.DataSource = Nothing
		dgvReport.DataSource = debtReportDetailsDTO

		dgvReport.Columns.Clear()
		dgvReport.Columns.Add(colID)
		dgvReport.Columns.Add(colCustomerName)
		dgvReport.Columns.Add(colOpeningDebt)
		dgvReport.Columns.Add(colNewDebt)
		dgvReport.Columns.Add(colClosingDebt)

	End Sub
End Class
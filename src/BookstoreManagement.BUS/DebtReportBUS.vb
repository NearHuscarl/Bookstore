Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class DebtReportBUS
	Private debtReportDAL As DebtReportDAL

	Private invoiceBUS As InvoiceBUS
	Private invoiceDetailBUS As InvoiceDetailBUS
	Private receiptBUS As ReceiptBUS

	Public Sub New()
		debtReportDAL = New DebtReportDAL()

		InitBUS()
	End Sub

	Public Sub New(connectionStr As String)
		debtReportDAL = New DebtReportDAL(connectionStr)

		InitBUS()
	End Sub

	Private Sub InitBUS()
		invoiceBUS = New InvoiceBUS
		invoiceDetailBUS = New InvoiceDetailBUS
		receiptBUS = New ReceiptBUS
	End Sub

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return debtReportDAL.getNextId(nextId)
	End Function

	Public Function insert(debtReport As DebtReportDTO) As Result
		Return debtReportDAL.insert(debtReport)
	End Function

	Public Function select_ByID(debtReportID As String, ByRef debtReport As DebtReportDTO) As Result
		Return debtReportDAL.select_ByID(debtReportID, debtReport)
	End Function

	Public Function selectAll(ByRef debtReports As List(Of DebtReportDTO)) As Result
		Return debtReportDAL.selectAll(debtReports)
	End Function

	Public Function selectAll_ByDate(dateReport As DateTime, ByRef debtReports As List(Of DebtReportDTO)) As Result
		Return debtReportDAL.selectAll_ByDate(dateReport, debtReports)
	End Function

	Public Function update(debtReport As DebtReportDTO) As Result
		Return debtReportDAL.update(debtReport)
	End Function

	Public Function delete(debtReportID As String) As Result
		Return debtReportDAL.delete(debtReportID)
	End Function

	Public Function GetDebtReports(dateReported As Date) As List(Of DebtReportDetailDTO)
		Dim tempCustomerIDs = New List(Of String)
		Dim debtReport = New DebtReportDTO()
		Dim debtReportDetails = New List(Of DebtReportDetailDTO)

		'opening
		Dim invoices = New List(Of InvoiceDTO)
		invoiceBUS.selectAll_ByBeforeDate(dateReported, invoices)

		For Each invoice As InvoiceDTO In invoices
			Dim invoiceDetails = New List(Of InvoiceDetailDTO)
			invoiceDetailBUS.selectAll_ByInvoice(invoice.ID, invoiceDetails)

			If (Not tempCustomerIDs.Contains(invoice.CustomerID)) Then
				tempCustomerIDs.Add(invoice.CustomerID)
				debtReportDetails.Add(New DebtReportDetailDTO("", debtReport.ID, invoice.CustomerID, 0, 0, 0))
			End If

			Dim tempSum As Integer = 0

			For Each invoiceDetail As InvoiceDetailDTO In invoiceDetails
				tempSum += (invoiceDetail.SalesPrice * invoiceDetail.Amount)
			Next

			For Each debtReportDetail As DebtReportDetailDTO In debtReportDetails
				If (debtReportDetail.CustomerID = invoice.CustomerID) Then
					debtReportDetail.OpeningDebt += tempSum
				End If
			Next
		Next

		Dim receipts = New List(Of ReceiptDTO)
		receiptBUS.selectAll_ByBeforeDate(dateReported, receipts)

		For Each receipt As ReceiptDTO In receipts
			For Each debtReportDetail As DebtReportDetailDTO In debtReportDetails
				If (debtReportDetail.CustomerID = receipt.CustomerID) Then
					debtReportDetail.OpeningDebt -= receipt.CollectedAmount
				End If
			Next
		Next

		'closing
		invoices = New List(Of InvoiceDTO)
		invoiceBUS.selectAll_ByBeforeDate(dateReported.AddMonths(1), invoices)

		For Each invoice As InvoiceDTO In invoices
			Dim invoiceDetails = New List(Of InvoiceDetailDTO)
			invoiceDetailBUS.selectAll_ByInvoice(invoice.ID, invoiceDetails)

			If (Not tempCustomerIDs.Contains(invoice.CustomerID)) Then
				tempCustomerIDs.Add(invoice.CustomerID)
				debtReportDetails.Add(New DebtReportDetailDTO("", debtReport.ID, invoice.CustomerID, 0, 0, 0))
			End If
			Dim tempSum As Integer = 0

			For Each invoiceDetail As InvoiceDetailDTO In invoiceDetails
				tempSum += (invoiceDetail.SalesPrice * invoiceDetail.Amount)
			Next

			For Each debtReportDetail As DebtReportDetailDTO In debtReportDetails
				If (debtReportDetail.CustomerID = invoice.CustomerID) Then
					debtReportDetail.ClosingDebt += tempSum
				End If
			Next
		Next

		receipts = New List(Of ReceiptDTO)
		receiptBUS.selectAll_ByBeforeDate(dateReported.AddMonths(1), receipts)

		For Each receipt As ReceiptDTO In receipts
			For Each debtReportDetail As DebtReportDetailDTO In debtReportDetails
				If (debtReportDetail.CustomerID = receipt.CustomerID) Then
					debtReportDetail.ClosingDebt -= receipt.CollectedAmount
				End If
			Next
		Next

		'new
		For Each debtReportDetail As DebtReportDetailDTO In debtReportDetails
			debtReportDetail.NewDebt = debtReportDetail.ClosingDebt - debtReportDetail.OpeningDebt
		Next

		Return debtReportDetails
	End Function
End Class

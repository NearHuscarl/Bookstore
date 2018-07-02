Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class StockReportBUS
	Private stockReportDAL As StockReportDAL
	Private invoiceBUS As InvoiceBUS
	Private invoiceDetailBUS As InvoiceDetailBUS
	Private importBUS As ImportBUS
	Private importDetailBUS As ImportDetailBUS

	Public Sub New()
		stockReportDAL = New StockReportDAL()
		InitBUS()
	End Sub

	Public Sub New(connectionStr As String)
		stockReportDAL = New StockReportDAL(connectionStr)
		InitBUS()
	End Sub

	Private Sub InitBUS()
		invoiceBUS = New InvoiceBUS()
		invoiceDetailBUS = New InvoiceDetailBUS()
		importBUS = New ImportBUS()
		importDetailBUS = New ImportDetailBUS()
	End Sub

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return stockReportDAL.getNextId(nextId)
	End Function

	Public Function insert(stockReport As StockReportDTO) As Result
		Return stockReportDAL.insert(stockReport)
	End Function

	Public Function select_ByID(stockReportID As String, ByRef stockReport As StockReportDTO) As Result
		Return stockReportDAL.select_ByID(stockReportID, stockReport)
	End Function

	Public Function selectAll(ByRef stockReports As List(Of StockReportDTO)) As Result
		Return stockReportDAL.selectAll(stockReports)
	End Function

	Public Function selectAll_ByDate(dateReported As DateTime, ByRef stockReports As List(Of StockReportDTO)) As Result
		Return stockReportDAL.selectAll_ByDate(dateReported, stockReports)
	End Function

	Public Function update(stockReport As StockReportDTO) As Result
		Return stockReportDAL.update(stockReport)
	End Function

	Public Function delete(stockReportID As String) As Result
		Return stockReportDAL.delete(stockReportID)
	End Function

	Public Function GetStockReports(dateReported As Date) As List(Of StockReportDetailDTO)
		Dim tempBookIDs = New List(Of String)
		Dim stockReport = New StockReportDTO()
		Dim stockReportDetails = New List(Of StockReportDetailDTO)

		'opening
		Dim _imports = New List(Of ImportDTO)
		ImportBUS.selectAll_ByBeforeDate(dateReported, _imports)

		For Each _import As ImportDTO In _imports
			Dim importDetails = New List(Of ImportDetailDTO)
			ImportDetailBUS.selectAll_ByImport(_import.ID, importDetails)

			For Each importDetail As ImportDetailDTO In importDetails

				If (Not tempBookIDs.Contains(importDetail.BookID)) Then
					tempBookIDs.Add(importDetail.BookID)
					stockReportDetails.Add(New StockReportDetailDTO("", stockReport.ID, importDetail.BookID, 0, 0, 0))
				End If

				For Each stockReportDetail As StockReportDetailDTO In stockReportDetails
					If (stockReportDetail.BookID = importDetail.BookID) Then
						stockReportDetail.OpeningStock += importDetail.ImportAmount
					End If
				Next
			Next
		Next

		Dim invoices = New List(Of InvoiceDTO)
		invoiceBUS.selectAll_ByBeforeDate(dateReported, invoices)

		For Each invoice As InvoiceDTO In invoices
			Dim invoiceDetails = New List(Of InvoiceDetailDTO)
			InvoiceDetailBUS.selectAll_ByInvoice(invoice.ID, invoiceDetails)

			For Each invoiceDetail As InvoiceDetailDTO In invoiceDetails
				For Each stockReportDetail As StockReportDetailDTO In stockReportDetails
					If (stockReportDetail.BookID = invoiceDetail.BookID) Then
						stockReportDetail.OpeningStock -= invoiceDetail.Amount
					End If
				Next
			Next
		Next

		'closing
		_imports = New List(Of ImportDTO)
		ImportBUS.selectAll_ByBeforeDate(dateReported.AddMonths(1), _imports)

		For Each _import As ImportDTO In _imports
			Dim importDetails = New List(Of ImportDetailDTO)
			ImportDetailBUS.selectAll_ByImport(_import.ID, importDetails)

			For Each importDetail As ImportDetailDTO In importDetails

				If (Not tempBookIDs.Contains(importDetail.BookID)) Then
					tempBookIDs.Add(importDetail.BookID)
					stockReportDetails.Add(New StockReportDetailDTO("", stockReport.ID, importDetail.BookID, 0, 0, 0))
				End If

				For Each stockReportDetail As StockReportDetailDTO In stockReportDetails
					If (stockReportDetail.BookID = importDetail.BookID) Then
						stockReportDetail.ClosingStock += importDetail.ImportAmount
					End If
				Next
			Next
		Next

		invoices = New List(Of InvoiceDTO)
		InvoiceBUS.selectAll_ByBeforeDate(dateReported.AddMonths(1), invoices)

		For Each invoice As InvoiceDTO In invoices
			Dim invoiceDetails = New List(Of InvoiceDetailDTO)
			InvoiceDetailBUS.selectAll_ByInvoice(invoice.ID, invoiceDetails)

			For Each invoiceDetail As InvoiceDetailDTO In invoiceDetails
				For Each stockReportDetail As StockReportDetailDTO In stockReportDetails
					If (stockReportDetail.BookID = invoiceDetail.BookID) Then
						stockReportDetail.ClosingStock -= invoiceDetail.Amount
					End If
				Next
			Next
		Next

		'new
		For Each stockReportDetail As StockReportDetailDTO In stockReportDetails
			stockReportDetail.NewStock = stockReportDetail.ClosingStock - stockReportDetail.OpeningStock
		Next

		Return stockReportDetails
	End Function
End Class

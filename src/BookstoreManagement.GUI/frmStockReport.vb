Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility

Public Class frmStockReport
	Private bookBUS As BookBUS
	Private importBUS As ImportBUS
	Private importDetailBUS As ImportDetailBUS
	Private invoiceBUS As InvoiceBUS
	Private invoiceDetailBUS As InvoiceDetailBUS
	Private stockReportBUS As StockReportBUS
	Private stockReportDTO As StockReportDTO
	Private stockReportDetailsDTO As List(Of StockReportDetailDTO)


	Private Sub getNextID(stockReportDTO As StockReportDTO)
		stockReportBUS.getNextId(stockReportDTO.ID)
	End Sub

	Private Sub calStockReport()
		Dim tempBookIDList = New List(Of String)
		stockReportDetailsDTO.Clear()

		'opening
		Dim importsDTO = New List(Of ImportDTO)
		importBUS.selectAll_ByBeforeDate(dtpReportDate.Value, importsDTO)

		For Each importDTO As ImportDTO In importsDTO
			Dim importDetailsDTO = New List(Of ImportDetailDTO)
			importDetailBUS.selectAll_ByImport(importDTO.ID, importDetailsDTO)

			For Each importDetailDTO As ImportDetailDTO In importDetailsDTO

				If (Not tempBookIDList.Contains(importDetailDTO.BookID)) Then
					tempBookIDList.Add(importDetailDTO.BookID)
					stockReportDetailsDTO.Add(New StockReportDetailDTO("", stockReportDTO.ID, importDetailDTO.BookID, 0, 0, 0))
				End If

				For Each stockReportDetailDTO As StockReportDetailDTO In stockReportDetailsDTO
					If (stockReportDetailDTO.BookID = importDetailDTO.BookID) Then
						stockReportDetailDTO.OpeningStock += importDetailDTO.ImportAmount
					End If
				Next
			Next
		Next

		Dim invoicesDTO = New List(Of InvoiceDTO)
		invoiceBUS.selectAll_ByBeforeDate(dtpReportDate.Value, invoicesDTO)

		For Each invoiceDTO As InvoiceDTO In invoicesDTO
			Dim invoiceDetailsDTO = New List(Of InvoiceDetailDTO)
			invoiceDetailBUS.selectAll_ByInvoice(invoiceDTO.ID, invoiceDetailsDTO)

			For Each invoiceDetailDTO As InvoiceDetailDTO In invoiceDetailsDTO
				For Each stockReportDetailDTO As StockReportDetailDTO In stockReportDetailsDTO
					If (stockReportDetailDTO.BookID = invoiceDetailDTO.BookID) Then
						stockReportDetailDTO.OpeningStock -= invoiceDetailDTO.Amount
					End If
				Next
			Next
		Next

		'closing
		importsDTO = New List(Of ImportDTO)
		importBUS.selectAll_ByBeforeDate(dtpReportDate.Value.AddMonths(1), importsDTO)

		For Each importDTO As ImportDTO In importsDTO
			Dim importDetailsDTO = New List(Of ImportDetailDTO)
			importDetailBUS.selectAll_ByImport(importDTO.ID, importDetailsDTO)

			For Each importDetailDTO As ImportDetailDTO In importDetailsDTO

				If (Not tempBookIDList.Contains(importDetailDTO.BookID)) Then
					tempBookIDList.Add(importDetailDTO.BookID)
					stockReportDetailsDTO.Add(New StockReportDetailDTO("", stockReportDTO.ID, importDetailDTO.BookID, 0, 0, 0))
				End If

				For Each stockReportDetailDTO As StockReportDetailDTO In stockReportDetailsDTO
					If (stockReportDetailDTO.BookID = importDetailDTO.BookID) Then
						stockReportDetailDTO.ClosingStock += importDetailDTO.ImportAmount
					End If
				Next
			Next
		Next

		invoicesDTO = New List(Of InvoiceDTO)
		invoiceBUS.selectAll_ByBeforeDate(dtpReportDate.Value.AddMonths(1), invoicesDTO)

		For Each invoiceDTO As InvoiceDTO In invoicesDTO
			Dim invoiceDetailsDTO = New List(Of InvoiceDetailDTO)
			invoiceDetailBUS.selectAll_ByInvoice(invoiceDTO.ID, invoiceDetailsDTO)

			For Each invoiceDetailDTO As InvoiceDetailDTO In invoiceDetailsDTO
				For Each stockReportDetailDTO As StockReportDetailDTO In stockReportDetailsDTO
					If (stockReportDetailDTO.BookID = invoiceDetailDTO.BookID) Then
						stockReportDetailDTO.ClosingStock -= invoiceDetailDTO.Amount
					End If
				Next
			Next
		Next

		'new
		For Each stockReportDetailDTO As StockReportDetailDTO In stockReportDetailsDTO
			stockReportDetailDTO.NewStock = stockReportDetailDTO.ClosingStock - stockReportDetailDTO.OpeningStock
		Next
	End Sub



	Private Sub loadListBook()
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
		bookBUS = New BookBUS
		importBUS = New ImportBUS
		importDetailBUS = New ImportDetailBUS
		invoiceBUS = New InvoiceBUS
		invoiceDetailBUS = New InvoiceDetailBUS
		stockReportDTO = New StockReportDTO
		stockReportDetailsDTO = New List(Of StockReportDetailDTO)
		lblID.Visible = False
		txtID.Visible = False
		btnReport.Visible = False
		loadListBook()
	End Sub

	Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
		calStockReport()
		dgvReport.Columns.Clear()


		dgvReport.DataSource = Nothing
		dgvReport.DataSource = stockReportDetailsDTO

		dgvReport.Columns.Clear()
		dgvReport.Columns.Add(colID)
		dgvReport.Columns.Add(colBookName)
		dgvReport.Columns.Add(colOpeningStock)
		dgvReport.Columns.Add(colNewStock)
		dgvReport.Columns.Add(colClosingStock)

	End Sub
End Class
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
	Inherits MetroFramework.Forms.MetroForm

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.pnlMainMenu = New MetroFramework.Controls.MetroPanel()
		Me.tlAbout = New MetroFramework.Controls.MetroTile()
		Me.tlExit = New MetroFramework.Controls.MetroTile()
		Me.tlAuthor = New MetroFramework.Controls.MetroTile()
		Me.tlRegulation = New MetroFramework.Controls.MetroTile()
		Me.tlReceipt = New MetroFramework.Controls.MetroTile()
		Me.tlDebtReport = New MetroFramework.Controls.MetroTile()
		Me.tlStockReport = New MetroFramework.Controls.MetroTile()
		Me.tlSearch = New MetroFramework.Controls.MetroTile()
		Me.tlInvoice = New MetroFramework.Controls.MetroTile()
		Me.tlBookCategory = New MetroFramework.Controls.MetroTile()
		Me.tlCustomer = New MetroFramework.Controls.MetroTile()
		Me.tlBook = New MetroFramework.Controls.MetroTile()
		Me.tlImport = New MetroFramework.Controls.MetroTile()
      Me.pnlMainMenu.SuspendLayout()
      Me.SuspendLayout()
		'
		'pnlMainMenu
		'
		Me.pnlMainMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				Or System.Windows.Forms.AnchorStyles.Left) _
				Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlMainMenu.Controls.Add(Me.tlAbout)
		Me.pnlMainMenu.Controls.Add(Me.tlExit)
		Me.pnlMainMenu.Controls.Add(Me.tlAuthor)
		Me.pnlMainMenu.Controls.Add(Me.tlRegulation)
		Me.pnlMainMenu.Controls.Add(Me.tlReceipt)
		Me.pnlMainMenu.Controls.Add(Me.tlDebtReport)
		Me.pnlMainMenu.Controls.Add(Me.tlStockReport)
		Me.pnlMainMenu.Controls.Add(Me.tlSearch)
		Me.pnlMainMenu.Controls.Add(Me.tlInvoice)
		Me.pnlMainMenu.Controls.Add(Me.tlBookCategory)
		Me.pnlMainMenu.Controls.Add(Me.tlCustomer)
		Me.pnlMainMenu.Controls.Add(Me.tlBook)
		Me.pnlMainMenu.Controls.Add(Me.tlImport)
		Me.pnlMainMenu.HorizontalScrollbarBarColor = True
		Me.pnlMainMenu.HorizontalScrollbarHighlightOnWheel = False
		Me.pnlMainMenu.HorizontalScrollbarSize = 10
		Me.pnlMainMenu.Location = New System.Drawing.Point(23, 63)
		Me.pnlMainMenu.Name = "pnlMainMenu"
		Me.pnlMainMenu.Size = New System.Drawing.Size(787, 390)
		Me.pnlMainMenu.TabIndex = 0
		Me.pnlMainMenu.VerticalScrollbarBarColor = True
		Me.pnlMainMenu.VerticalScrollbarHighlightOnWheel = False
		Me.pnlMainMenu.VerticalScrollbarSize = 10
		'
		'tlAbout
		'
		Me.tlAbout.ActiveControl = Nothing
		Me.tlAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlAbout.Location = New System.Drawing.Point(605, 293)
		Me.tlAbout.Name = "tlAbout"
		Me.tlAbout.Size = New System.Drawing.Size(168, 83)
		Me.tlAbout.TabIndex = 14
		Me.tlAbout.Text = "About"
		Me.tlAbout.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.AboutIcon
		Me.tlAbout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlAbout.UseCustomBackColor = True
		Me.tlAbout.UseSelectable = True
		Me.tlAbout.UseTileImage = True
		'
		'tlExit
		'
		Me.tlExit.ActiveControl = Nothing
		Me.tlExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlExit.Location = New System.Drawing.Point(417, 291)
		Me.tlExit.Name = "tlExit"
		Me.tlExit.Size = New System.Drawing.Size(178, 85)
		Me.tlExit.TabIndex = 13
		Me.tlExit.Text = "Exit"
		Me.tlExit.TileImage = CType(resources.GetObject("tlExit.TileImage"), System.Drawing.Image)
		Me.tlExit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlExit.UseCustomBackColor = True
		Me.tlExit.UseSelectable = True
		Me.tlExit.UseTileImage = True
		'
		'tlAuthor
		'
		Me.tlAuthor.ActiveControl = Nothing
		Me.tlAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlAuthor.Location = New System.Drawing.Point(488, 10)
		Me.tlAuthor.Margin = New System.Windows.Forms.Padding(10)
		Me.tlAuthor.Name = "tlAuthor"
		Me.tlAuthor.Size = New System.Drawing.Size(107, 130)
		Me.tlAuthor.TabIndex = 6
		Me.tlAuthor.Text = "Author"
		Me.tlAuthor.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.Author
		Me.tlAuthor.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlAuthor.UseCustomBackColor = True
		Me.tlAuthor.UseSelectable = True
		Me.tlAuthor.UseTileImage = True
		'
		'tlRegulation
		'
		Me.tlRegulation.ActiveControl = Nothing
		Me.tlRegulation.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlRegulation.Location = New System.Drawing.Point(605, 150)
		Me.tlRegulation.Margin = New System.Windows.Forms.Padding(10)
		Me.tlRegulation.Name = "tlRegulation"
		Me.tlRegulation.Size = New System.Drawing.Size(168, 130)
		Me.tlRegulation.TabIndex = 12
		Me.tlRegulation.Text = "Regulation"
		Me.tlRegulation.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.Regulation
		Me.tlRegulation.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlRegulation.UseCustomBackColor = True
		Me.tlRegulation.UseSelectable = True
		Me.tlRegulation.UseTileImage = True
		'
		'tlReceipt
		'
		Me.tlReceipt.ActiveControl = Nothing
		Me.tlReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlReceipt.Location = New System.Drawing.Point(10, 150)
		Me.tlReceipt.Margin = New System.Windows.Forms.Padding(10)
		Me.tlReceipt.Name = "tlReceipt"
		Me.tlReceipt.Size = New System.Drawing.Size(125, 226)
		Me.tlReceipt.TabIndex = 11
		Me.tlReceipt.Text = "Receipt"
		Me.tlReceipt.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.Receipt
		Me.tlReceipt.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlReceipt.UseCustomBackColor = True
		Me.tlReceipt.UseSelectable = True
		Me.tlReceipt.UseTileImage = True
		'
		'tlDebtReport
		'
		Me.tlDebtReport.ActiveControl = Nothing
		Me.tlDebtReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlDebtReport.Location = New System.Drawing.Point(282, 150)
		Me.tlDebtReport.Margin = New System.Windows.Forms.Padding(10)
		Me.tlDebtReport.Name = "tlDebtReport"
		Me.tlDebtReport.Size = New System.Drawing.Size(125, 130)
		Me.tlDebtReport.TabIndex = 10
		Me.tlDebtReport.Text = "Debt Report"
		Me.tlDebtReport.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.DebtReport
		Me.tlDebtReport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlDebtReport.UseCustomBackColor = True
		Me.tlDebtReport.UseSelectable = True
		Me.tlDebtReport.UseTileImage = True
		'
		'tlStockReport
		'
		Me.tlStockReport.ActiveControl = Nothing
		Me.tlStockReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlStockReport.Location = New System.Drawing.Point(147, 150)
		Me.tlStockReport.Margin = New System.Windows.Forms.Padding(10)
		Me.tlStockReport.Name = "tlStockReport"
		Me.tlStockReport.Size = New System.Drawing.Size(125, 130)
		Me.tlStockReport.TabIndex = 9
		Me.tlStockReport.Text = "Stock Report"
		Me.tlStockReport.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.StockReport
		Me.tlStockReport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlStockReport.UseCustomBackColor = True
		Me.tlStockReport.UseSelectable = True
		Me.tlStockReport.UseTileImage = True
		'
		'tlSearch
		'
		Me.tlSearch.ActiveControl = Nothing
		Me.tlSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlSearch.Location = New System.Drawing.Point(605, 7)
		Me.tlSearch.Margin = New System.Windows.Forms.Padding(10)
		Me.tlSearch.Name = "tlSearch"
		Me.tlSearch.Size = New System.Drawing.Size(168, 133)
		Me.tlSearch.TabIndex = 8
		Me.tlSearch.Text = "Search"
		Me.tlSearch.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.Search
		Me.tlSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlSearch.UseCustomBackColor = True
		Me.tlSearch.UseSelectable = True
		Me.tlSearch.UseTileImage = True
		'
		'tlInvoice
		'
		Me.tlInvoice.ActiveControl = Nothing
		Me.tlInvoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlInvoice.Location = New System.Drawing.Point(147, 10)
		Me.tlInvoice.Margin = New System.Windows.Forms.Padding(10)
		Me.tlInvoice.Name = "tlInvoice"
		Me.tlInvoice.Size = New System.Drawing.Size(212, 130)
		Me.tlInvoice.TabIndex = 7
		Me.tlInvoice.Text = "Invoice"
		Me.tlInvoice.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.InvoiceIcon
		Me.tlInvoice.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlInvoice.UseCustomBackColor = True
		Me.tlInvoice.UseSelectable = True
		Me.tlInvoice.UseTileImage = True
		'
		'tlBookCategory
		'
		Me.tlBookCategory.ActiveControl = Nothing
		Me.tlBookCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlBookCategory.Location = New System.Drawing.Point(147, 291)
		Me.tlBookCategory.Margin = New System.Windows.Forms.Padding(10)
		Me.tlBookCategory.Name = "tlBookCategory"
		Me.tlBookCategory.Size = New System.Drawing.Size(260, 85)
		Me.tlBookCategory.TabIndex = 6
		Me.tlBookCategory.Text = "Category"
		Me.tlBookCategory.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.Cateogry
		Me.tlBookCategory.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlBookCategory.UseCustomBackColor = True
		Me.tlBookCategory.UseSelectable = True
		Me.tlBookCategory.UseTileImage = True
		'
		'tlCustomer
		'
		Me.tlCustomer.ActiveControl = Nothing
		Me.tlCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlCustomer.Location = New System.Drawing.Point(417, 150)
		Me.tlCustomer.Margin = New System.Windows.Forms.Padding(10)
		Me.tlCustomer.Name = "tlCustomer"
		Me.tlCustomer.Size = New System.Drawing.Size(178, 130)
		Me.tlCustomer.TabIndex = 6
		Me.tlCustomer.Text = "Customer"
		Me.tlCustomer.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.Customer
		Me.tlCustomer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlCustomer.UseCustomBackColor = True
		Me.tlCustomer.UseSelectable = True
		Me.tlCustomer.UseTileImage = True
		'
		'tlBook
		'
		Me.tlBook.ActiveControl = Nothing
		Me.tlBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlBook.Location = New System.Drawing.Point(369, 10)
		Me.tlBook.Margin = New System.Windows.Forms.Padding(10)
		Me.tlBook.Name = "tlBook"
		Me.tlBook.Size = New System.Drawing.Size(109, 130)
		Me.tlBook.TabIndex = 6
		Me.tlBook.Text = "Book"
		Me.tlBook.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.Book
		Me.tlBook.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlBook.UseCustomBackColor = True
		Me.tlBook.UseSelectable = True
		Me.tlBook.UseTileImage = True
		'
		'tlImport
		'
		Me.tlImport.ActiveControl = Nothing
		Me.tlImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlImport.Location = New System.Drawing.Point(10, 10)
		Me.tlImport.Margin = New System.Windows.Forms.Padding(10)
		Me.tlImport.Name = "tlImport"
		Me.tlImport.Size = New System.Drawing.Size(125, 130)
		Me.tlImport.TabIndex = 6
		Me.tlImport.Text = "Import"
		Me.tlImport.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.ImportIcon
		Me.tlImport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlImport.UseCustomBackColor = True
		Me.tlImport.UseSelectable = True
      Me.tlImport.UseTileImage = True
      '
      'frmMain
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(833, 476)
		Me.Controls.Add(Me.pnlMainMenu)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.Resizable = False
		Me.Text = "Main Menu"
		Me.TransparencyKey = System.Drawing.Color.Empty
		Me.pnlMainMenu.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pnlMainMenu As MetroFramework.Controls.MetroPanel
	Friend WithEvents tlReceipt As MetroFramework.Controls.MetroTile
	Friend WithEvents tlDebtReport As MetroFramework.Controls.MetroTile
	Friend WithEvents tlStockReport As MetroFramework.Controls.MetroTile
	Friend WithEvents tlSearch As MetroFramework.Controls.MetroTile
	Friend WithEvents tlInvoice As MetroFramework.Controls.MetroTile
	Friend WithEvents tlImport As MetroFramework.Controls.MetroTile
	Friend WithEvents tlRegulation As MetroFramework.Controls.MetroTile
	Friend WithEvents tlAuthor As MetroFramework.Controls.MetroTile
	Friend WithEvents tlBookCategory As MetroFramework.Controls.MetroTile
	Friend WithEvents tlCustomer As MetroFramework.Controls.MetroTile
	Friend WithEvents tlBook As MetroFramework.Controls.MetroTile
	Friend WithEvents tlExit As MetroFramework.Controls.MetroTile
	Friend WithEvents tlAbout As MetroFramework.Controls.MetroTile
End Class

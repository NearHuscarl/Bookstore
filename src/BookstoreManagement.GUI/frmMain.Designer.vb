<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
		Me.pnlMainMenu = New MetroFramework.Controls.MetroPanel()
		Me.tlRegulation = New MetroFramework.Controls.MetroTile()
		Me.tlReceipt = New MetroFramework.Controls.MetroTile()
		Me.tlDebtReport = New MetroFramework.Controls.MetroTile()
		Me.tlStockReport = New MetroFramework.Controls.MetroTile()
		Me.tlSearch = New MetroFramework.Controls.MetroTile()
		Me.tlInvoice = New MetroFramework.Controls.MetroTile()
		Me.tlImport = New MetroFramework.Controls.MetroTile()
		Me.pnlMainMenu.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnlMainMenu
		'
		Me.pnlMainMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				Or System.Windows.Forms.AnchorStyles.Left) _
				Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlMainMenu.Controls.Add(Me.tlRegulation)
		Me.pnlMainMenu.Controls.Add(Me.tlReceipt)
		Me.pnlMainMenu.Controls.Add(Me.tlDebtReport)
		Me.pnlMainMenu.Controls.Add(Me.tlStockReport)
		Me.pnlMainMenu.Controls.Add(Me.tlSearch)
		Me.pnlMainMenu.Controls.Add(Me.tlInvoice)
		Me.pnlMainMenu.Controls.Add(Me.tlImport)
		Me.pnlMainMenu.HorizontalScrollbarBarColor = True
		Me.pnlMainMenu.HorizontalScrollbarHighlightOnWheel = False
		Me.pnlMainMenu.HorizontalScrollbarSize = 10
		Me.pnlMainMenu.Location = New System.Drawing.Point(23, 63)
		Me.pnlMainMenu.Name = "pnlMainMenu"
		Me.pnlMainMenu.Size = New System.Drawing.Size(704, 314)
		Me.pnlMainMenu.TabIndex = 0
		Me.pnlMainMenu.VerticalScrollbarBarColor = True
		Me.pnlMainMenu.VerticalScrollbarHighlightOnWheel = False
		Me.pnlMainMenu.VerticalScrollbarSize = 10
		'
		'tlRegulation
		'
		Me.tlRegulation.ActiveControl = Nothing
		Me.tlRegulation.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlRegulation.Location = New System.Drawing.Point(517, 195)
		Me.tlRegulation.Margin = New System.Windows.Forms.Padding(10)
		Me.tlRegulation.Name = "tlRegulation"
		Me.tlRegulation.Size = New System.Drawing.Size(177, 109)
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
		Me.tlReceipt.Location = New System.Drawing.Point(10, 158)
		Me.tlReceipt.Margin = New System.Windows.Forms.Padding(10)
		Me.tlReceipt.Name = "tlReceipt"
		Me.tlReceipt.Size = New System.Drawing.Size(220, 146)
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
		Me.tlDebtReport.Location = New System.Drawing.Point(376, 158)
		Me.tlDebtReport.Margin = New System.Windows.Forms.Padding(10)
		Me.tlDebtReport.Name = "tlDebtReport"
		Me.tlDebtReport.Size = New System.Drawing.Size(132, 146)
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
		Me.tlStockReport.Location = New System.Drawing.Point(240, 158)
		Me.tlStockReport.Margin = New System.Windows.Forms.Padding(10)
		Me.tlStockReport.Name = "tlStockReport"
		Me.tlStockReport.Size = New System.Drawing.Size(125, 146)
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
		Me.tlSearch.Location = New System.Drawing.Point(517, 10)
		Me.tlSearch.Margin = New System.Windows.Forms.Padding(10)
		Me.tlSearch.Name = "tlSearch"
		Me.tlSearch.Size = New System.Drawing.Size(177, 177)
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
		Me.tlInvoice.Location = New System.Drawing.Point(240, 10)
		Me.tlInvoice.Margin = New System.Windows.Forms.Padding(10)
		Me.tlInvoice.Name = "tlInvoice"
		Me.tlInvoice.Size = New System.Drawing.Size(268, 138)
		Me.tlInvoice.TabIndex = 7
		Me.tlInvoice.Text = "Invoice"
		Me.tlInvoice.TileImage = Global.BookstoreManagement.GUI.My.Resources.Resources.InvoiceIcon
		Me.tlInvoice.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.tlInvoice.UseCustomBackColor = True
		Me.tlInvoice.UseSelectable = True
		Me.tlInvoice.UseTileImage = True
		'
		'tlImport
		'
		Me.tlImport.ActiveControl = Nothing
		Me.tlImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
		Me.tlImport.Location = New System.Drawing.Point(10, 10)
		Me.tlImport.Margin = New System.Windows.Forms.Padding(10)
		Me.tlImport.Name = "tlImport"
		Me.tlImport.Size = New System.Drawing.Size(220, 138)
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
		Me.ClientSize = New System.Drawing.Size(750, 400)
		Me.Controls.Add(Me.pnlMainMenu)
		Me.Name = "frmMain"
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
End Class

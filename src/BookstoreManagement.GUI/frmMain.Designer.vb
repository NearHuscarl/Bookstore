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
		Me.tlReceipt = New MetroFramework.Controls.MetroTile()
		Me.tlDeptReport = New MetroFramework.Controls.MetroTile()
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
		Me.pnlMainMenu.Controls.Add(Me.tlReceipt)
		Me.pnlMainMenu.Controls.Add(Me.tlDeptReport)
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
		'tlReceipt
		'
		Me.tlReceipt.ActiveControl = Nothing
		Me.tlReceipt.Location = New System.Drawing.Point(15, 166)
		Me.tlReceipt.Name = "tlReceipt"
		Me.tlReceipt.Size = New System.Drawing.Size(215, 132)
		Me.tlReceipt.TabIndex = 11
		Me.tlReceipt.Text = "Receipt"
		Me.tlReceipt.UseSelectable = True
		'
		'tlDeptReport
		'
		Me.tlDeptReport.ActiveControl = Nothing
		Me.tlDeptReport.Location = New System.Drawing.Point(474, 166)
		Me.tlDeptReport.Name = "tlDeptReport"
		Me.tlDeptReport.Size = New System.Drawing.Size(215, 132)
		Me.tlDeptReport.TabIndex = 10
		Me.tlDeptReport.Text = "Dept Report"
		Me.tlDeptReport.UseSelectable = True
		'
		'tlStockReport
		'
		Me.tlStockReport.ActiveControl = Nothing
		Me.tlStockReport.Location = New System.Drawing.Point(244, 166)
		Me.tlStockReport.Name = "tlStockReport"
		Me.tlStockReport.Size = New System.Drawing.Size(215, 132)
		Me.tlStockReport.TabIndex = 9
		Me.tlStockReport.Text = "Stock Report"
		Me.tlStockReport.UseSelectable = True
		'
		'tlSearch
		'
		Me.tlSearch.ActiveControl = Nothing
		Me.tlSearch.Location = New System.Drawing.Point(474, 16)
		Me.tlSearch.Name = "tlSearch"
		Me.tlSearch.Size = New System.Drawing.Size(215, 132)
		Me.tlSearch.TabIndex = 8
		Me.tlSearch.Text = "Search"
		Me.tlSearch.UseSelectable = True
		'
		'tlInvoice
		'
		Me.tlInvoice.ActiveControl = Nothing
		Me.tlInvoice.Location = New System.Drawing.Point(244, 16)
		Me.tlInvoice.Name = "tlInvoice"
		Me.tlInvoice.Size = New System.Drawing.Size(215, 132)
		Me.tlInvoice.TabIndex = 7
		Me.tlInvoice.Text = "Invoice"
		Me.tlInvoice.UseSelectable = True
		'
		'tlImport
		'
		Me.tlImport.ActiveControl = Nothing
		Me.tlImport.Location = New System.Drawing.Point(15, 16)
		Me.tlImport.Name = "tlImport"
		Me.tlImport.Size = New System.Drawing.Size(215, 132)
		Me.tlImport.TabIndex = 6
		Me.tlImport.Text = "Import"
		Me.tlImport.UseSelectable = True
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
	Friend WithEvents tlDeptReport As MetroFramework.Controls.MetroTile
	Friend WithEvents tlStockReport As MetroFramework.Controls.MetroTile
	Friend WithEvents tlSearch As MetroFramework.Controls.MetroTile
	Friend WithEvents tlInvoice As MetroFramework.Controls.MetroTile
	Friend WithEvents tlImport As MetroFramework.Controls.MetroTile
End Class

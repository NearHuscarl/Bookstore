<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockReport
	Inherits MetroFramework.Forms.MetroForm

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.lblID = New MetroFramework.Controls.MetroLabel()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.dtpReportDate = New MetroFramework.Controls.MetroDateTime()
		Me.btnViewReport = New MetroFramework.Controls.MetroButton()
		Me.btnReport = New MetroFramework.Controls.MetroButton()
		Me.dgvReport = New MetroFramework.Controls.MetroGrid()
		Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colBookName = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.colOpeningStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colNewStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colClosingStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(23, 73)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(66, 19)
		Me.lblID.TabIndex = 0
		Me.lblID.Text = "Report ID"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(95, 72)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(274, 20)
		Me.txtID.TabIndex = 1
		'
		'dtpReportDate
		'
		Me.dtpReportDate.CustomFormat = "MMMM yyyy"
		Me.dtpReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpReportDate.Location = New System.Drawing.Point(375, 63)
		Me.dtpReportDate.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
		Me.dtpReportDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
		Me.dtpReportDate.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtpReportDate.Name = "dtpReportDate"
		Me.dtpReportDate.Size = New System.Drawing.Size(240, 29)
		Me.dtpReportDate.TabIndex = 2
		'
		'btnViewReport
		'
		Me.btnViewReport.Location = New System.Drawing.Point(621, 69)
		Me.btnViewReport.Name = "btnViewReport"
		Me.btnViewReport.Size = New System.Drawing.Size(75, 23)
		Me.btnViewReport.TabIndex = 3
		Me.btnViewReport.Text = "View Report"
		Me.btnViewReport.UseSelectable = True
		'
		'btnReport
		'
		Me.btnReport.Location = New System.Drawing.Point(702, 69)
		Me.btnReport.Name = "btnReport"
		Me.btnReport.Size = New System.Drawing.Size(75, 23)
		Me.btnReport.TabIndex = 3
		Me.btnReport.Text = "Export"
		Me.btnReport.UseSelectable = True
		'
		'dgvReport
		'
		Me.dgvReport.AllowUserToAddRows = False
		Me.dgvReport.AllowUserToDeleteRows = False
		Me.dgvReport.AllowUserToResizeRows = False
		Me.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colBookName, Me.colOpeningStock, Me.colNewStock, Me.colClosingStock})
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvReport.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvReport.EnableHeadersVisualStyles = False
		Me.dgvReport.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvReport.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvReport.Location = New System.Drawing.Point(23, 98)
		Me.dgvReport.Name = "dgvReport"
		Me.dgvReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvReport.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvReport.Size = New System.Drawing.Size(754, 329)
		Me.dgvReport.TabIndex = 4
		'
		'colID
		'
		Me.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colID.DataPropertyName = "ID"
		Me.colID.FillWeight = 10.0!
		Me.colID.HeaderText = "ID"
		Me.colID.Name = "colID"
		Me.colID.ReadOnly = True
		'
		'colBookName
		'
		Me.colBookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colBookName.DataPropertyName = "BookID"
		Me.colBookName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.colBookName.FillWeight = 30.0!
		Me.colBookName.HeaderText = "Book"
		Me.colBookName.Name = "colBookName"
		Me.colBookName.ReadOnly = True
		Me.colBookName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colBookName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'colOpeningStock
		'
		Me.colOpeningStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colOpeningStock.DataPropertyName = "OpeningStock"
		Me.colOpeningStock.FillWeight = 20.0!
		Me.colOpeningStock.HeaderText = "Opening Stock"
		Me.colOpeningStock.Name = "colOpeningStock"
		Me.colOpeningStock.ReadOnly = True
		'
		'colNewStock
		'
		Me.colNewStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colNewStock.DataPropertyName = "NewStock"
		Me.colNewStock.FillWeight = 20.0!
		Me.colNewStock.HeaderText = "New Stock"
		Me.colNewStock.Name = "colNewStock"
		Me.colNewStock.ReadOnly = True
		'
		'colClosingStock
		'
		Me.colClosingStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colClosingStock.DataPropertyName = "ClosingStock"
		Me.colClosingStock.FillWeight = 20.0!
		Me.colClosingStock.HeaderText = "Closing Stock"
		Me.colClosingStock.Name = "colClosingStock"
		Me.colClosingStock.ReadOnly = True
		'
		'frmStockReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.dgvReport)
		Me.Controls.Add(Me.btnReport)
		Me.Controls.Add(Me.btnViewReport)
		Me.Controls.Add(Me.dtpReportDate)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.lblID)
		Me.Name = "frmStockReport"
		Me.Text = "Stock Report"
		CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblID As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtID As TextBox
	Friend WithEvents dtpReportDate As MetroFramework.Controls.MetroDateTime
	Friend WithEvents btnViewReport As MetroFramework.Controls.MetroButton
	Friend WithEvents btnReport As MetroFramework.Controls.MetroButton
	Friend WithEvents dgvReport As MetroFramework.Controls.MetroGrid
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colBookName As DataGridViewComboBoxColumn
	Friend WithEvents colOpeningStock As DataGridViewTextBoxColumn
	Friend WithEvents colNewStock As DataGridViewTextBoxColumn
	Friend WithEvents colClosingStock As DataGridViewTextBoxColumn
End Class

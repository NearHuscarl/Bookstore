<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebtReport
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
		Me.dtpReportDate = New MetroFramework.Controls.MetroDateTime()
		Me.btnExport = New MetroFramework.Controls.MetroButton()
		Me.btnViewReport = New MetroFramework.Controls.MetroButton()
		Me.dgvReport = New MetroFramework.Controls.MetroGrid()
		Me.lblID = New MetroFramework.Controls.MetroLabel()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colCustomerName = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.colOpeningDebt = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colNewDebt = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colClosingDebt = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
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
		'btnExport
		'
		Me.btnExport.Location = New System.Drawing.Point(702, 69)
		Me.btnExport.Name = "btnExport"
		Me.btnExport.Size = New System.Drawing.Size(75, 23)
		Me.btnExport.TabIndex = 3
		Me.btnExport.Text = "Export"
		Me.btnExport.UseSelectable = True
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
		Me.dgvReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colCustomerName, Me.colOpeningDebt, Me.colNewDebt, Me.colClosingDebt})
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
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(23, 73)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(66, 19)
		Me.lblID.TabIndex = 5
		Me.lblID.Text = "Report ID"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(95, 72)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(274, 20)
		Me.txtID.TabIndex = 6
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
		'colCustomerName
		'
		Me.colCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colCustomerName.DataPropertyName = "CustomerID"
		Me.colCustomerName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.colCustomerName.FillWeight = 30.0!
		Me.colCustomerName.HeaderText = "Customer"
		Me.colCustomerName.Name = "colCustomerName"
		Me.colCustomerName.ReadOnly = True
		Me.colCustomerName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colCustomerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'colOpeningDebt
		'
		Me.colOpeningDebt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colOpeningDebt.DataPropertyName = "OpeningDebt"
		Me.colOpeningDebt.FillWeight = 20.0!
		Me.colOpeningDebt.HeaderText = "Opening Debt"
		Me.colOpeningDebt.Name = "colOpeningDebt"
		Me.colOpeningDebt.ReadOnly = True
		'
		'colNewDebt
		'
		Me.colNewDebt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colNewDebt.DataPropertyName = "NewDebt"
		Me.colNewDebt.FillWeight = 20.0!
		Me.colNewDebt.HeaderText = "New Debt"
		Me.colNewDebt.Name = "colNewDebt"
		Me.colNewDebt.ReadOnly = True
		'
		'colClosingDebt
		'
		Me.colClosingDebt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colClosingDebt.DataPropertyName = "ClosingDebt"
		Me.colClosingDebt.FillWeight = 20.0!
		Me.colClosingDebt.HeaderText = "ClosingDebt"
		Me.colClosingDebt.Name = "colClosingDebt"
		Me.colClosingDebt.ReadOnly = True
		'
		'frmDebtReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.lblID)
		Me.Controls.Add(Me.dgvReport)
		Me.Controls.Add(Me.btnViewReport)
		Me.Controls.Add(Me.btnExport)
		Me.Controls.Add(Me.dtpReportDate)
		Me.Name = "frmDebtReport"
		Me.Text = "Debt Report"
		CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dtpReportDate As MetroFramework.Controls.MetroDateTime
	Friend WithEvents btnExport As MetroFramework.Controls.MetroButton
	Friend WithEvents btnViewReport As MetroFramework.Controls.MetroButton
	Friend WithEvents dgvReport As MetroFramework.Controls.MetroGrid
	Friend WithEvents lblID As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtID As TextBox
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colCustomerName As DataGridViewComboBoxColumn
	Friend WithEvents colOpeningDebt As DataGridViewTextBoxColumn
	Friend WithEvents colNewDebt As DataGridViewTextBoxColumn
	Friend WithEvents colClosingDebt As DataGridViewTextBoxColumn
End Class

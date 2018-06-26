<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImport
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
		Me.components = New System.ComponentModel.Container()
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.btnAdd = New MetroFramework.Controls.MetroButton()
		Me.btnClear = New MetroFramework.Controls.MetroButton()
		Me.dgvImportDetail = New MetroFramework.Controls.MetroGrid()
		Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.dgvImport = New MetroFramework.Controls.MetroGrid()
		Me.lblImportDetail = New MetroFramework.Controls.MetroLabel()
		Me.lblImport = New MetroFramework.Controls.MetroLabel()
		Me.btnUpdate = New MetroFramework.Controls.MetroButton()
		Me.btnDelete = New MetroFramework.Controls.MetroButton()
		Me.colImportID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colImportDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colImportDetailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colBookID = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.colImportAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colCurrentAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colImportPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.dgvImportDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(189, 365)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 5
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseSelectable = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(555, 365)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 6
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseSelectable = True
		'
		'dgvImportDetail
		'
		Me.dgvImportDetail.AllowUserToResizeRows = False
		Me.dgvImportDetail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvImportDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvImportDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvImportDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvImportDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
		Me.dgvImportDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvImportDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colImportDetailID, Me.colBookID, Me.colImportAmount, Me.colCurrentAmount, Me.colImportPrice})
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvImportDetail.DefaultCellStyle = DataGridViewCellStyle8
		Me.dgvImportDetail.EnableHeadersVisualStyles = False
		Me.dgvImportDetail.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvImportDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvImportDetail.Location = New System.Drawing.Point(291, 145)
		Me.dgvImportDetail.Name = "dgvImportDetail"
		Me.dgvImportDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvImportDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
		Me.dgvImportDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvImportDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvImportDetail.Size = New System.Drawing.Size(499, 185)
		Me.dgvImportDetail.TabIndex = 9
		'
		'BookBindingSource
		'
		Me.BookBindingSource.DataSource = GetType(System.Collections.Generic.List(Of String))
		'
		'dgvImport
		'
		Me.dgvImport.AllowUserToResizeRows = False
		Me.dgvImport.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvImport.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvImport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvImport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvImport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
		Me.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvImport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colImportID, Me.colImportDate})
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvImport.DefaultCellStyle = DataGridViewCellStyle11
		Me.dgvImport.EnableHeadersVisualStyles = False
		Me.dgvImport.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvImport.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvImport.Location = New System.Drawing.Point(23, 145)
		Me.dgvImport.MultiSelect = False
		Me.dgvImport.Name = "dgvImport"
		Me.dgvImport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvImport.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
		Me.dgvImport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvImport.Size = New System.Drawing.Size(262, 185)
		Me.dgvImport.TabIndex = 14
		'
		'lblImportDetail
		'
		Me.lblImportDetail.AutoSize = True
		Me.lblImportDetail.Location = New System.Drawing.Point(291, 101)
		Me.lblImportDetail.Name = "lblImportDetail"
		Me.lblImportDetail.Size = New System.Drawing.Size(87, 19)
		Me.lblImportDetail.TabIndex = 8
		Me.lblImportDetail.Text = "Import Detail"
		'
		'lblImport
		'
		Me.lblImport.AutoSize = True
		Me.lblImport.Location = New System.Drawing.Point(23, 101)
		Me.lblImport.Name = "lblImport"
		Me.lblImport.Size = New System.Drawing.Size(50, 19)
		Me.lblImport.TabIndex = 11
		Me.lblImport.Text = "Import"
		'
		'btnUpdate
		'
		Me.btnUpdate.Enabled = False
		Me.btnUpdate.Location = New System.Drawing.Point(311, 365)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 15
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseSelectable = True
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(433, 365)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 16
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseSelectable = True
		'
		'colImportID
		'
		Me.colImportID.DataPropertyName = "ID"
		Me.colImportID.FillWeight = 39.61353!
		Me.colImportID.HeaderText = "ID"
		Me.colImportID.Name = "colImportID"
		Me.colImportID.ReadOnly = True
		Me.colImportID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colImportID.Width = 110
		'
		'colImportDate
		'
		Me.colImportDate.DataPropertyName = "ImportDate"
		Me.colImportDate.FillWeight = 160.3865!
		Me.colImportDate.HeaderText = "Import Date"
		Me.colImportDate.Name = "colImportDate"
		Me.colImportDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		'
		'colImportDetailID
		'
		Me.colImportDetailID.FillWeight = 123.8739!
		Me.colImportDetailID.HeaderText = "ID"
		Me.colImportDetailID.Name = "colImportDetailID"
		Me.colImportDetailID.ReadOnly = True
		Me.colImportDetailID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colImportDetailID.Width = 110
		'
		'colBookID
		'
		Me.colBookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colBookID.DataSource = Me.BookBindingSource
		Me.colBookID.FillWeight = 172.2907!
		Me.colBookID.HeaderText = "Book"
		Me.colBookID.Name = "colBookID"
		Me.colBookID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colBookID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'colImportAmount
		'
		Me.colImportAmount.FillWeight = 60.14212!
		Me.colImportAmount.HeaderText = "Import Amount"
		Me.colImportAmount.Name = "colImportAmount"
		Me.colImportAmount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colImportAmount.Width = 53
		'
		'colCurrentAmount
		'
		Me.colCurrentAmount.FillWeight = 68.3132!
		Me.colCurrentAmount.HeaderText = "Current Amount"
		Me.colCurrentAmount.Name = "colCurrentAmount"
		Me.colCurrentAmount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colCurrentAmount.Width = 61
		'
		'colImportPrice
		'
		Me.colImportPrice.FillWeight = 75.38008!
		Me.colImportPrice.HeaderText = "Import Price"
		Me.colImportPrice.Name = "colImportPrice"
		Me.colImportPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colImportPrice.Width = 67
		'
		'frmImport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(818, 437)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.dgvImport)
		Me.Controls.Add(Me.lblImport)
		Me.Controls.Add(Me.dgvImportDetail)
		Me.Controls.Add(Me.lblImportDetail)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnAdd)
		Me.Name = "frmImport"
		Me.ShowIcon = False
		Me.Text = "Import Book"
		CType(Me.dgvImportDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
	Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
	Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ReceivedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents dgvImportDetail As MetroFramework.Controls.MetroGrid
	Friend WithEvents dgvImport As MetroFramework.Controls.MetroGrid
	Friend WithEvents DateImportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents lblImportDetail As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblImport As MetroFramework.Controls.MetroLabel
	Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
	Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
	Friend WithEvents BookBindingSource As BindingSource
	Friend WithEvents colImportID As DataGridViewTextBoxColumn
	Friend WithEvents colImportDate As DataGridViewTextBoxColumn
	Friend WithEvents colImportDetailID As DataGridViewTextBoxColumn
	Friend WithEvents colBookID As DataGridViewComboBoxColumn
	Friend WithEvents colImportAmount As DataGridViewTextBoxColumn
	Friend WithEvents colCurrentAmount As DataGridViewTextBoxColumn
	Friend WithEvents colImportPrice As DataGridViewTextBoxColumn
End Class

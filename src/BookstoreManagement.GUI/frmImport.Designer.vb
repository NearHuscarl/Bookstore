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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.btnAdd = New MetroFramework.Controls.MetroButton()
		Me.btnClear = New MetroFramework.Controls.MetroButton()
		Me.dtpReceivedDate = New MetroFramework.Controls.MetroDateTime()
		Me.lblReceivedDate = New MetroFramework.Controls.MetroLabel()
		Me.dgvImport = New MetroFramework.Controls.MetroGrid()
		Me.ImportDetailDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ImportIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ImportAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CurrentAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ImportPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImportDetailDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(191, 325)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 5
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseSelectable = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(418, 325)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 6
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseSelectable = True
		'
		'dtpReceivedDate
		'
		Me.dtpReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpReceivedDate.Location = New System.Drawing.Point(349, 63)
		Me.dtpReceivedDate.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtpReceivedDate.Name = "dtpReceivedDate"
		Me.dtpReceivedDate.Size = New System.Drawing.Size(96, 29)
		Me.dtpReceivedDate.TabIndex = 7
		'
		'lblReceivedDate
		'
		Me.lblReceivedDate.AutoSize = True
		Me.lblReceivedDate.Location = New System.Drawing.Point(245, 69)
		Me.lblReceivedDate.Name = "lblReceivedDate"
		Me.lblReceivedDate.Size = New System.Drawing.Size(92, 19)
		Me.lblReceivedDate.TabIndex = 8
		Me.lblReceivedDate.Text = "Received Date"
		'
		'dgvImport
		'
		Me.dgvImport.AllowUserToResizeRows = False
		Me.dgvImport.AutoGenerateColumns = False
		Me.dgvImport.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvImport.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvImport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvImport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvImport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvImport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.ImportIDDataGridViewTextBoxColumn, Me.BookIDDataGridViewTextBoxColumn, Me.ImportAmountDataGridViewTextBoxColumn, Me.CurrentAmountDataGridViewTextBoxColumn, Me.ImportPriceDataGridViewTextBoxColumn})
		Me.dgvImport.DataSource = Me.ImportDetailDTOBindingSource
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvImport.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvImport.EnableHeadersVisualStyles = False
		Me.dgvImport.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvImport.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvImport.Location = New System.Drawing.Point(43, 112)
		Me.dgvImport.Name = "dgvImport"
		Me.dgvImport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvImport.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvImport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvImport.Size = New System.Drawing.Size(632, 150)
		Me.dgvImport.TabIndex = 9
		'
		'ImportDetailDTOBindingSource
		'
		Me.ImportDetailDTOBindingSource.DataSource = GetType(BookstoreManagement.DTO.ImportDetailDTO)
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
		Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.Width = 50
		'
		'ImportIDDataGridViewTextBoxColumn
		'
		Me.ImportIDDataGridViewTextBoxColumn.DataPropertyName = "ImportID"
		Me.ImportIDDataGridViewTextBoxColumn.HeaderText = "Import ID"
		Me.ImportIDDataGridViewTextBoxColumn.Name = "ImportIDDataGridViewTextBoxColumn"
		'
		'BookIDDataGridViewTextBoxColumn
		'
		Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID"
		Me.BookIDDataGridViewTextBoxColumn.HeaderText = "Book ID"
		Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
		'
		'ImportAmountDataGridViewTextBoxColumn
		'
		Me.ImportAmountDataGridViewTextBoxColumn.DataPropertyName = "ImportAmount"
		Me.ImportAmountDataGridViewTextBoxColumn.HeaderText = "Import Amount"
		Me.ImportAmountDataGridViewTextBoxColumn.Name = "ImportAmountDataGridViewTextBoxColumn"
		Me.ImportAmountDataGridViewTextBoxColumn.Width = 120
		'
		'CurrentAmountDataGridViewTextBoxColumn
		'
		Me.CurrentAmountDataGridViewTextBoxColumn.DataPropertyName = "CurrentAmount"
		Me.CurrentAmountDataGridViewTextBoxColumn.HeaderText = "Current Amount"
		Me.CurrentAmountDataGridViewTextBoxColumn.Name = "CurrentAmountDataGridViewTextBoxColumn"
		Me.CurrentAmountDataGridViewTextBoxColumn.Width = 120
		'
		'ImportPriceDataGridViewTextBoxColumn
		'
		Me.ImportPriceDataGridViewTextBoxColumn.DataPropertyName = "ImportPrice"
		Me.ImportPriceDataGridViewTextBoxColumn.HeaderText = "Import Price"
		Me.ImportPriceDataGridViewTextBoxColumn.Name = "ImportPriceDataGridViewTextBoxColumn"
		'
		'frmImport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(724, 384)
		Me.Controls.Add(Me.dgvImport)
		Me.Controls.Add(Me.lblReceivedDate)
		Me.Controls.Add(Me.dtpReceivedDate)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnAdd)
		Me.Name = "frmImport"
		Me.ShowIcon = False
		Me.Text = "Import Book"
		CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImportDetailDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
	Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
	Friend WithEvents dtpReceivedDate As MetroFramework.Controls.MetroDateTime
	Friend WithEvents lblReceivedDate As MetroFramework.Controls.MetroLabel
	Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ReceivedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents dgvImport As MetroFramework.Controls.MetroGrid
	Friend WithEvents ImportDetailDTOBindingSource As BindingSource
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents ImportIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ImportAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CurrentAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ImportPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

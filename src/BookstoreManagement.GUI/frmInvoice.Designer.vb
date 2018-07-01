<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvoice
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
		Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.btnAdd = New MetroFramework.Controls.MetroButton()
		Me.dgvInvoiceDetail = New MetroFramework.Controls.MetroGrid()
		Me.colInvoiceDetailID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colBookID = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.ColCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgvInvoice = New MetroFramework.Controls.MetroGrid()
		Me.colInvoiceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colCustomer = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.lblDetail = New MetroFramework.Controls.MetroLabel()
		Me.lblGeneral = New MetroFramework.Controls.MetroLabel()
		Me.btnUpdate = New MetroFramework.Controls.MetroButton()
		Me.btnDelete = New MetroFramework.Controls.MetroButton()
		Me.txtTotal = New MetroFramework.Controls.MetroTextBox()
		Me.lblTotal = New MetroFramework.Controls.MetroLabel()
		CType(Me.dgvInvoiceDetail, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnAdd
		'
		Me.btnAdd.Enabled = False
		Me.btnAdd.Location = New System.Drawing.Point(250, 372)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 5
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseSelectable = True
		'
		'dgvInvoiceDetail
		'
		Me.dgvInvoiceDetail.AllowUserToResizeRows = False
		Me.dgvInvoiceDetail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvInvoiceDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvInvoiceDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvInvoiceDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvInvoiceDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
		Me.dgvInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInvoiceDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInvoiceDetailID, Me.colBookID, Me.ColCategory, Me.colAmount, Me.colPrice})
		DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvInvoiceDetail.DefaultCellStyle = DataGridViewCellStyle8
		Me.dgvInvoiceDetail.EnableHeadersVisualStyles = False
		Me.dgvInvoiceDetail.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvInvoiceDetail.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvInvoiceDetail.Location = New System.Drawing.Point(78, 199)
		Me.dgvInvoiceDetail.Name = "dgvInvoiceDetail"
		Me.dgvInvoiceDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvInvoiceDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
		Me.dgvInvoiceDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvInvoiceDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgvInvoiceDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvInvoiceDetail.Size = New System.Drawing.Size(668, 125)
		Me.dgvInvoiceDetail.TabIndex = 9
		'
		'colInvoiceDetailID
		'
		Me.colInvoiceDetailID.FillWeight = 123.8739!
		Me.colInvoiceDetailID.HeaderText = "ID"
		Me.colInvoiceDetailID.Name = "colInvoiceDetailID"
		Me.colInvoiceDetailID.ReadOnly = True
		Me.colInvoiceDetailID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colInvoiceDetailID.Width = 110
		'
		'colBookID
		'
		Me.colBookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colBookID.FillWeight = 172.2907!
		Me.colBookID.HeaderText = "Book"
		Me.colBookID.Name = "colBookID"
		Me.colBookID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colBookID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'ColCategory
		'
		Me.ColCategory.HeaderText = "Category"
		Me.ColCategory.Name = "ColCategory"
		Me.ColCategory.ReadOnly = True
		Me.ColCategory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ColCategory.Width = 150
		'
		'colAmount
		'
		Me.colAmount.FillWeight = 60.14212!
		Me.colAmount.HeaderText = "Amount"
		Me.colAmount.Name = "colAmount"
		Me.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colAmount.Width = 115
		'
		'colPrice
		'
		Me.colPrice.FillWeight = 75.38008!
		Me.colPrice.HeaderText = "Price"
		Me.colPrice.Name = "colPrice"
		Me.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		'
		'dgvInvoice
		'
		Me.dgvInvoice.AllowUserToResizeRows = False
		Me.dgvInvoice.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvInvoice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
		Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInvoiceID, Me.colCustomer, Me.colDate})
		DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvInvoice.DefaultCellStyle = DataGridViewCellStyle11
		Me.dgvInvoice.EnableHeadersVisualStyles = False
		Me.dgvInvoice.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvInvoice.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvInvoice.Location = New System.Drawing.Point(78, 89)
		Me.dgvInvoice.MultiSelect = False
		Me.dgvInvoice.Name = "dgvInvoice"
		Me.dgvInvoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvInvoice.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
		Me.dgvInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvInvoice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvInvoice.Size = New System.Drawing.Size(465, 81)
		Me.dgvInvoice.TabIndex = 14
		'
		'colInvoiceID
		'
		Me.colInvoiceID.DataPropertyName = "ID"
		Me.colInvoiceID.FillWeight = 39.61353!
		Me.colInvoiceID.HeaderText = "ID"
		Me.colInvoiceID.Name = "colInvoiceID"
		Me.colInvoiceID.ReadOnly = True
		Me.colInvoiceID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colInvoiceID.Width = 110
		'
		'colCustomer
		'
		Me.colCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colCustomer.HeaderText = "Customer"
		Me.colCustomer.Name = "colCustomer"
		Me.colCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'colDate
		'
		Me.colDate.DataPropertyName = "ImportDate"
		Me.colDate.FillWeight = 160.3865!
		Me.colDate.HeaderText = "Date"
		Me.colDate.Name = "colDate"
		Me.colDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colDate.Width = 150
		'
		'lblDetail
		'
		Me.lblDetail.AutoSize = True
		Me.lblDetail.Location = New System.Drawing.Point(78, 177)
		Me.lblDetail.Name = "lblDetail"
		Me.lblDetail.Size = New System.Drawing.Size(42, 19)
		Me.lblDetail.TabIndex = 8
		Me.lblDetail.Text = "Detail"
		'
		'lblGeneral
		'
		Me.lblGeneral.AutoSize = True
		Me.lblGeneral.Location = New System.Drawing.Point(78, 67)
		Me.lblGeneral.Name = "lblGeneral"
		Me.lblGeneral.Size = New System.Drawing.Size(54, 19)
		Me.lblGeneral.TabIndex = 11
		Me.lblGeneral.Text = "General"
		'
		'btnUpdate
		'
		Me.btnUpdate.Enabled = False
		Me.btnUpdate.Location = New System.Drawing.Point(372, 372)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 15
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseSelectable = True
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(494, 372)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 16
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseSelectable = True
		'
		'txtTotal
		'
		'
		'
		'
		Me.txtTotal.CustomButton.Image = Nothing
		Me.txtTotal.CustomButton.Location = New System.Drawing.Point(53, 1)
		Me.txtTotal.CustomButton.Name = ""
		Me.txtTotal.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtTotal.CustomButton.TabIndex = 1
		Me.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtTotal.CustomButton.UseSelectable = True
		Me.txtTotal.CustomButton.Visible = False
		Me.txtTotal.Enabled = False
		Me.txtTotal.Lines = New String(-1) {}
		Me.txtTotal.Location = New System.Drawing.Point(671, 330)
		Me.txtTotal.MaxLength = 32767
		Me.txtTotal.Name = "txtTotal"
		Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtTotal.ReadOnly = True
		Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTotal.SelectedText = ""
		Me.txtTotal.SelectionLength = 0
		Me.txtTotal.SelectionStart = 0
		Me.txtTotal.ShortcutsEnabled = True
		Me.txtTotal.Size = New System.Drawing.Size(75, 23)
		Me.txtTotal.TabIndex = 17
		Me.txtTotal.UseSelectable = True
		Me.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.Location = New System.Drawing.Point(625, 331)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(36, 19)
		Me.lblTotal.TabIndex = 18
		Me.lblTotal.Text = "Total"
		'
		'frmInvoice
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(818, 437)
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.txtTotal)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.dgvInvoice)
		Me.Controls.Add(Me.lblGeneral)
		Me.Controls.Add(Me.dgvInvoiceDetail)
		Me.Controls.Add(Me.lblDetail)
		Me.Controls.Add(Me.btnAdd)
		Me.Name = "frmInvoice"
		Me.ShowIcon = False
		Me.Text = "Invoice"
		CType(Me.dgvInvoiceDetail, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
	Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ReceivedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents dgvInvoiceDetail As MetroFramework.Controls.MetroGrid
	Friend WithEvents dgvInvoice As MetroFramework.Controls.MetroGrid
	Friend WithEvents DateImportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents lblDetail As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblGeneral As MetroFramework.Controls.MetroLabel
	Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
	Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
	Friend WithEvents colInvoiceID As DataGridViewTextBoxColumn
	Friend WithEvents colCustomer As DataGridViewComboBoxColumn
	Friend WithEvents colDate As DataGridViewTextBoxColumn
	Friend WithEvents colInvoiceDetailID As DataGridViewTextBoxColumn
	Friend WithEvents colBookID As DataGridViewComboBoxColumn
	Friend WithEvents ColCategory As DataGridViewTextBoxColumn
	Friend WithEvents colAmount As DataGridViewTextBoxColumn
	Friend WithEvents colPrice As DataGridViewTextBoxColumn
	Friend WithEvents txtTotal As MetroFramework.Controls.MetroTextBox
	Friend WithEvents lblTotal As MetroFramework.Controls.MetroLabel
End Class

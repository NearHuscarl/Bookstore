<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReceipt
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.btnUpdate = New MetroFramework.Controls.MetroButton()
		Me.btnAdd = New MetroFramework.Controls.MetroButton()
		Me.dgvReceipt = New MetroFramework.Controls.MetroGrid()
		Me.lblEmail = New MetroFramework.Controls.MetroLabel()
		Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
		Me.lblPhoneNumber = New MetroFramework.Controls.MetroLabel()
		Me.txtPhoneNumber = New MetroFramework.Controls.MetroTextBox()
		Me.lblAddress = New MetroFramework.Controls.MetroLabel()
		Me.txtAddress = New MetroFramework.Controls.MetroTextBox()
		Me.lblName = New MetroFramework.Controls.MetroLabel()
		Me.txtName = New MetroFramework.Controls.MetroTextBox()
		Me.btnDelete = New MetroFramework.Controls.MetroButton()
		Me.colReceiptID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colCustomerID = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.dgvReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnUpdate
		'
		Me.btnUpdate.Enabled = False
		Me.btnUpdate.Location = New System.Drawing.Point(372, 382)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 19
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseSelectable = True
		'
		'btnAdd
		'
		Me.btnAdd.Enabled = False
		Me.btnAdd.Location = New System.Drawing.Point(247, 382)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 20
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseSelectable = True
		'
		'dgvReceipt
		'
		Me.dgvReceipt.AllowUserToResizeRows = False
		Me.dgvReceipt.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvReceipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvReceipt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvReceipt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colReceiptID, Me.colCustomerID, Me.colDate, Me.colAmount})
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvReceipt.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvReceipt.EnableHeadersVisualStyles = False
		Me.dgvReceipt.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvReceipt.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvReceipt.Location = New System.Drawing.Point(141, 226)
		Me.dgvReceipt.MultiSelect = False
		Me.dgvReceipt.Name = "dgvReceipt"
		Me.dgvReceipt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvReceipt.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvReceipt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgvReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvReceipt.Size = New System.Drawing.Size(536, 133)
		Me.dgvReceipt.TabIndex = 29
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Location = New System.Drawing.Point(315, 180)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(41, 19)
		Me.lblEmail.TabIndex = 38
		Me.lblEmail.Text = "Email"
		'
		'txtEmail
		'
		'
		'
		'
		Me.txtEmail.CustomButton.Image = Nothing
		Me.txtEmail.CustomButton.Location = New System.Drawing.Point(158, 1)
		Me.txtEmail.CustomButton.Name = ""
		Me.txtEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtEmail.CustomButton.TabIndex = 1
		Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtEmail.CustomButton.UseSelectable = True
		Me.txtEmail.CustomButton.Visible = False
		Me.txtEmail.Enabled = False
		Me.txtEmail.Lines = New String(-1) {}
		Me.txtEmail.Location = New System.Drawing.Point(362, 180)
		Me.txtEmail.MaxLength = 32767
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEmail.SelectedText = ""
		Me.txtEmail.SelectionLength = 0
		Me.txtEmail.SelectionStart = 0
		Me.txtEmail.ShortcutsEnabled = True
		Me.txtEmail.Size = New System.Drawing.Size(180, 23)
		Me.txtEmail.TabIndex = 37
		Me.txtEmail.UseSelectable = True
		Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'lblPhoneNumber
		'
		Me.lblPhoneNumber.AutoSize = True
		Me.lblPhoneNumber.Location = New System.Drawing.Point(257, 140)
		Me.lblPhoneNumber.Name = "lblPhoneNumber"
		Me.lblPhoneNumber.Size = New System.Drawing.Size(99, 19)
		Me.lblPhoneNumber.TabIndex = 36
		Me.lblPhoneNumber.Text = "Phone Number"
		'
		'txtPhoneNumber
		'
		'
		'
		'
		Me.txtPhoneNumber.CustomButton.Image = Nothing
		Me.txtPhoneNumber.CustomButton.Location = New System.Drawing.Point(158, 1)
		Me.txtPhoneNumber.CustomButton.Name = ""
		Me.txtPhoneNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtPhoneNumber.CustomButton.TabIndex = 1
		Me.txtPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtPhoneNumber.CustomButton.UseSelectable = True
		Me.txtPhoneNumber.CustomButton.Visible = False
		Me.txtPhoneNumber.Enabled = False
		Me.txtPhoneNumber.Lines = New String(-1) {}
		Me.txtPhoneNumber.Location = New System.Drawing.Point(362, 140)
		Me.txtPhoneNumber.MaxLength = 32767
		Me.txtPhoneNumber.Name = "txtPhoneNumber"
		Me.txtPhoneNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPhoneNumber.SelectedText = ""
		Me.txtPhoneNumber.SelectionLength = 0
		Me.txtPhoneNumber.SelectionStart = 0
		Me.txtPhoneNumber.ShortcutsEnabled = True
		Me.txtPhoneNumber.Size = New System.Drawing.Size(180, 23)
		Me.txtPhoneNumber.TabIndex = 35
		Me.txtPhoneNumber.UseSelectable = True
		Me.txtPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtPhoneNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'lblAddress
		'
		Me.lblAddress.AutoSize = True
		Me.lblAddress.Location = New System.Drawing.Point(300, 100)
		Me.lblAddress.Name = "lblAddress"
		Me.lblAddress.Size = New System.Drawing.Size(56, 19)
		Me.lblAddress.TabIndex = 34
		Me.lblAddress.Text = "Address"
		'
		'txtAddress
		'
		'
		'
		'
		Me.txtAddress.CustomButton.Image = Nothing
		Me.txtAddress.CustomButton.Location = New System.Drawing.Point(158, 1)
		Me.txtAddress.CustomButton.Name = ""
		Me.txtAddress.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtAddress.CustomButton.TabIndex = 1
		Me.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtAddress.CustomButton.UseSelectable = True
		Me.txtAddress.CustomButton.Visible = False
		Me.txtAddress.Enabled = False
		Me.txtAddress.Lines = New String(-1) {}
		Me.txtAddress.Location = New System.Drawing.Point(362, 100)
		Me.txtAddress.MaxLength = 32767
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAddress.SelectedText = ""
		Me.txtAddress.SelectionLength = 0
		Me.txtAddress.SelectionStart = 0
		Me.txtAddress.ShortcutsEnabled = True
		Me.txtAddress.Size = New System.Drawing.Size(180, 23)
		Me.txtAddress.TabIndex = 33
		Me.txtAddress.UseSelectable = True
		Me.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(311, 60)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(45, 19)
		Me.lblName.TabIndex = 32
		Me.lblName.Text = "Name"
		'
		'txtName
		'
		'
		'
		'
		Me.txtName.CustomButton.Image = Nothing
		Me.txtName.CustomButton.Location = New System.Drawing.Point(157, 1)
		Me.txtName.CustomButton.Name = ""
		Me.txtName.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtName.CustomButton.TabIndex = 1
		Me.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtName.CustomButton.UseSelectable = True
		Me.txtName.CustomButton.Visible = False
		Me.txtName.Enabled = False
		Me.txtName.Lines = New String(-1) {}
		Me.txtName.Location = New System.Drawing.Point(362, 60)
		Me.txtName.MaxLength = 32767
		Me.txtName.Name = "txtName"
		Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtName.SelectedText = ""
		Me.txtName.SelectionLength = 0
		Me.txtName.SelectionStart = 0
		Me.txtName.ShortcutsEnabled = True
		Me.txtName.Size = New System.Drawing.Size(179, 23)
		Me.txtName.TabIndex = 31
		Me.txtName.UseSelectable = True
		Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'btnDelete
		'
		Me.btnDelete.Enabled = False
		Me.btnDelete.Location = New System.Drawing.Point(497, 382)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 39
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseSelectable = True
		'
		'colReceiptID
		'
		Me.colReceiptID.FillWeight = 123.8739!
		Me.colReceiptID.HeaderText = "ID"
		Me.colReceiptID.Name = "colReceiptID"
		Me.colReceiptID.ReadOnly = True
		Me.colReceiptID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colReceiptID.Width = 110
		'
		'colCustomerID
		'
		Me.colCustomerID.FillWeight = 172.2907!
		Me.colCustomerID.HeaderText = "Customer ID"
		Me.colCustomerID.Name = "colCustomerID"
		Me.colCustomerID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colCustomerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.colCustomerID.Width = 150
		'
		'colDate
		'
		Me.colDate.FillWeight = 75.38008!
		Me.colDate.HeaderText = "Date"
		Me.colDate.Name = "colDate"
		Me.colDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colDate.Width = 130
		'
		'colAmount
		'
		Me.colAmount.HeaderText = "Amount"
		Me.colAmount.Name = "colAmount"
		'
		'frmReceipt
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(818, 437)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.lblEmail)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.lblPhoneNumber)
		Me.Controls.Add(Me.txtPhoneNumber)
		Me.Controls.Add(Me.lblAddress)
		Me.Controls.Add(Me.txtAddress)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.dgvReceipt)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.btnUpdate)
		Me.Name = "frmReceipt"
		Me.ShowIcon = False
		Me.Text = "Receipt"
		CType(Me.dgvReceipt, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ReceivedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DateImportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
	Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
	Friend WithEvents dgvReceipt As MetroFramework.Controls.MetroGrid
	Friend WithEvents lblEmail As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
	Friend WithEvents lblPhoneNumber As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtPhoneNumber As MetroFramework.Controls.MetroTextBox
	Friend WithEvents lblAddress As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtAddress As MetroFramework.Controls.MetroTextBox
	Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
	Friend WithEvents colReceiptID As DataGridViewTextBoxColumn
	Friend WithEvents colCustomerID As DataGridViewComboBoxColumn
	Friend WithEvents colDate As DataGridViewTextBoxColumn
	Friend WithEvents colAmount As DataGridViewTextBoxColumn
End Class

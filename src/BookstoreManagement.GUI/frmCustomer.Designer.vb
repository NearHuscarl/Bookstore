<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
		Me.txtCustomerName = New System.Windows.Forms.TextBox()
		Me.btnClear = New MetroFramework.Controls.MetroButton()
		Me.btnSearch = New MetroFramework.Controls.MetroButton()
		Me.dgvCustomer = New MetroFramework.Controls.MetroGrid()
		Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colPhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colCurrentDebt = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnDelete = New MetroFramework.Controls.MetroButton()
		Me.btnAdd = New MetroFramework.Controls.MetroButton()
		Me.btnUpdate = New MetroFramework.Controls.MetroButton()
		CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtCustomerName
		'
		Me.txtCustomerName.Location = New System.Drawing.Point(23, 63)
		Me.txtCustomerName.Name = "txtCustomerName"
		Me.txtCustomerName.Size = New System.Drawing.Size(592, 20)
		Me.txtCustomerName.TabIndex = 0
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(702, 60)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 1
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseSelectable = True
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(621, 60)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(75, 23)
		Me.btnSearch.TabIndex = 1
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseSelectable = True
		'
		'dgvCustomer
		'
		Me.dgvCustomer.AllowUserToAddRows = False
		Me.dgvCustomer.AllowUserToDeleteRows = False
		Me.dgvCustomer.AllowUserToResizeRows = False
		Me.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvCustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colAddress, Me.colEmail, Me.colPhoneNumber, Me.colCurrentDebt})
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvCustomer.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvCustomer.EnableHeadersVisualStyles = False
		Me.dgvCustomer.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvCustomer.Location = New System.Drawing.Point(23, 89)
		Me.dgvCustomer.Name = "dgvCustomer"
		Me.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvCustomer.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvCustomer.Size = New System.Drawing.Size(754, 309)
		Me.dgvCustomer.TabIndex = 2
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
		'colName
		'
		Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colName.DataPropertyName = "Name"
		Me.colName.FillWeight = 20.0!
		Me.colName.HeaderText = "Name"
		Me.colName.Name = "colName"
		Me.colName.ReadOnly = True
		'
		'colAddress
		'
		Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colAddress.DataPropertyName = "Address"
		Me.colAddress.FillWeight = 30.0!
		Me.colAddress.HeaderText = "Address"
		Me.colAddress.Name = "colAddress"
		Me.colAddress.ReadOnly = True
		'
		'colEmail
		'
		Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colEmail.DataPropertyName = "Email"
		Me.colEmail.FillWeight = 20.0!
		Me.colEmail.HeaderText = "Email"
		Me.colEmail.Name = "colEmail"
		Me.colEmail.ReadOnly = True
		'
		'colPhoneNumber
		'
		Me.colPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colPhoneNumber.DataPropertyName = "Phone"
		Me.colPhoneNumber.FillWeight = 10.0!
		Me.colPhoneNumber.HeaderText = "Phone"
		Me.colPhoneNumber.Name = "colPhoneNumber"
		Me.colPhoneNumber.ReadOnly = True
		'
		'colCurrentDebt
		'
		Me.colCurrentDebt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colCurrentDebt.DataPropertyName = "Debt"
		Me.colCurrentDebt.FillWeight = 10.0!
		Me.colCurrentDebt.HeaderText = "Debt"
		Me.colCurrentDebt.Name = "colCurrentDebt"
		Me.colCurrentDebt.ReadOnly = True
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(702, 404)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 3
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseSelectable = True
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(23, 404)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 3
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseSelectable = True
		'
		'btnUpdate
		'
		Me.btnUpdate.Location = New System.Drawing.Point(367, 404)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 3
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseSelectable = True
		'
		'frmCustomer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.dgvCustomer)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.txtCustomerName)
		Me.MaximizeBox = False
		Me.Name = "frmCustomer"
		Me.ShowIcon = False
		Me.Text = "Customer"
		CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtCustomerName As TextBox
	Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
	Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
	Friend WithEvents dgvCustomer As MetroFramework.Controls.MetroGrid
	Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
	Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
	Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colName As DataGridViewTextBoxColumn
	Friend WithEvents colAddress As DataGridViewTextBoxColumn
	Friend WithEvents colEmail As DataGridViewTextBoxColumn
	Friend WithEvents colPhoneNumber As DataGridViewTextBoxColumn
	Friend WithEvents colCurrentDebt As DataGridViewTextBoxColumn
End Class

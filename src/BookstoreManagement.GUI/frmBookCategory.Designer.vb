<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookCategory
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
		Me.txtBookCategoryName = New System.Windows.Forms.TextBox()
		Me.btnClear = New MetroFramework.Controls.MetroButton()
		Me.btnSearch = New MetroFramework.Controls.MetroButton()
		Me.btnDelete = New MetroFramework.Controls.MetroButton()
		Me.btnAdd = New MetroFramework.Controls.MetroButton()
		Me.btnUpdate = New MetroFramework.Controls.MetroButton()
		Me.dgvBookCategory = New MetroFramework.Controls.MetroGrid()
		Me.colBookCategoryID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colBookCategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.dgvBookCategory, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtBookCategoryName
		'
		Me.txtBookCategoryName.Location = New System.Drawing.Point(23, 63)
		Me.txtBookCategoryName.Name = "txtBookCategoryName"
		Me.txtBookCategoryName.Size = New System.Drawing.Size(592, 20)
		Me.txtBookCategoryName.TabIndex = 0
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
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(702, 404)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 1
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseSelectable = True
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(23, 404)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 1
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseSelectable = True
		'
		'btnUpdate
		'
		Me.btnUpdate.Location = New System.Drawing.Point(366, 404)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 1
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseSelectable = True
		'
		'dgvBookCategory
		'
		Me.dgvBookCategory.AllowUserToAddRows = False
		Me.dgvBookCategory.AllowUserToDeleteRows = False
		Me.dgvBookCategory.AllowUserToResizeRows = False
		Me.dgvBookCategory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvBookCategory.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvBookCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvBookCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvBookCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvBookCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvBookCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBookCategoryID, Me.colBookCategoryName})
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvBookCategory.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvBookCategory.EnableHeadersVisualStyles = False
		Me.dgvBookCategory.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvBookCategory.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvBookCategory.Location = New System.Drawing.Point(23, 89)
		Me.dgvBookCategory.Name = "dgvBookCategory"
		Me.dgvBookCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvBookCategory.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvBookCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvBookCategory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgvBookCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvBookCategory.Size = New System.Drawing.Size(754, 307)
		Me.dgvBookCategory.TabIndex = 2
		'
		'colBookCategoryID
		'
		Me.colBookCategoryID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colBookCategoryID.DataPropertyName = "ID"
		Me.colBookCategoryID.FillWeight = 25.0!
		Me.colBookCategoryID.HeaderText = "ID"
		Me.colBookCategoryID.Name = "colBookCategoryID"
		Me.colBookCategoryID.ReadOnly = True
		'
		'colBookCategoryName
		'
		Me.colBookCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colBookCategoryName.DataPropertyName = "Name"
		Me.colBookCategoryName.FillWeight = 75.0!
		Me.colBookCategoryName.HeaderText = "Name"
		Me.colBookCategoryName.Name = "colBookCategoryName"
		Me.colBookCategoryName.ReadOnly = True
		'
		'frmBookCategory
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.dgvBookCategory)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.txtBookCategoryName)
		Me.MaximizeBox = False
		Me.Name = "frmBookCategory"
		Me.Resizable = False
		Me.ShowIcon = False
		Me.Text = "Book Category"
		CType(Me.dgvBookCategory, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtBookCategoryName As TextBox
	Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
	Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
	Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
	Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
	Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
	Friend WithEvents dgvBookCategory As MetroFramework.Controls.MetroGrid
	Friend WithEvents colBookCategoryID As DataGridViewTextBoxColumn
	Friend WithEvents colBookCategoryName As DataGridViewTextBoxColumn
End Class

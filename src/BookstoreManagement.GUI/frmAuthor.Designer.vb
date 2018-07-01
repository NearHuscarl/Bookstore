<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuthor
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.txtAuthorName = New System.Windows.Forms.TextBox()
		Me.btnSearch = New MetroFramework.Controls.MetroButton()
		Me.btnClear = New MetroFramework.Controls.MetroButton()
		Me.btnAdd = New MetroFramework.Controls.MetroButton()
		Me.btnDelete = New MetroFramework.Controls.MetroButton()
		Me.btnUpdate = New MetroFramework.Controls.MetroButton()
		Me.dgvAuthor = New MetroFramework.Controls.MetroGrid()
		Me.colAuthorID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colAuthorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.dgvAuthor, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtAuthorName
		'
		Me.txtAuthorName.Location = New System.Drawing.Point(23, 63)
		Me.txtAuthorName.Name = "txtAuthorName"
		Me.txtAuthorName.Size = New System.Drawing.Size(592, 20)
		Me.txtAuthorName.TabIndex = 1
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(621, 60)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(75, 23)
		Me.btnSearch.TabIndex = 2
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseSelectable = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(702, 60)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 2
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseSelectable = True
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(23, 404)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 2
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseSelectable = True
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(702, 404)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 2
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseSelectable = True
		'
		'btnUpdate
		'
		Me.btnUpdate.Location = New System.Drawing.Point(367, 404)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 2
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseSelectable = True
		'
		'dgvAuthor
		'
		Me.dgvAuthor.AllowUserToAddRows = False
		Me.dgvAuthor.AllowUserToDeleteRows = False
		Me.dgvAuthor.AllowUserToResizeRows = False
		Me.dgvAuthor.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvAuthor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvAuthor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvAuthor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvAuthor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAuthorID, Me.colAuthorName})
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvAuthor.DefaultCellStyle = DataGridViewCellStyle5
		Me.dgvAuthor.EnableHeadersVisualStyles = False
		Me.dgvAuthor.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvAuthor.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvAuthor.Location = New System.Drawing.Point(23, 89)
		Me.dgvAuthor.Name = "dgvAuthor"
		Me.dgvAuthor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvAuthor.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
		Me.dgvAuthor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvAuthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvAuthor.Size = New System.Drawing.Size(754, 309)
		Me.dgvAuthor.TabIndex = 3
		'
		'colAuthorID
		'
		Me.colAuthorID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colAuthorID.DataPropertyName = "ID"
		Me.colAuthorID.FillWeight = 25.0!
		Me.colAuthorID.HeaderText = "ID"
		Me.colAuthorID.Name = "colAuthorID"
		Me.colAuthorID.ReadOnly = True
		Me.colAuthorID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colAuthorID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		'
		'colAuthorName
		'
		Me.colAuthorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colAuthorName.DataPropertyName = "Name"
		Me.colAuthorName.FillWeight = 75.0!
		Me.colAuthorName.HeaderText = "Name"
		Me.colAuthorName.Name = "colAuthorName"
		Me.colAuthorName.ReadOnly = True
		Me.colAuthorName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colAuthorName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		'
		'frmAuthor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.dgvAuthor)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.txtAuthorName)
		Me.MaximizeBox = False
		Me.Name = "frmAuthor"
		Me.Resizable = False
		Me.ShowIcon = False
		Me.Text = "Author"
		CType(Me.dgvAuthor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtAuthorName As TextBox
	Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
	Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
	Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
	Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
	Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
	Friend WithEvents dgvAuthor As MetroFramework.Controls.MetroGrid
	Friend WithEvents colAuthorID As DataGridViewTextBoxColumn
	Friend WithEvents colAuthorName As DataGridViewTextBoxColumn
End Class

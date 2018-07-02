<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBook
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

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.txtBookName = New System.Windows.Forms.TextBox()
		Me.btnSearch = New MetroFramework.Controls.MetroButton()
		Me.btnClear = New MetroFramework.Controls.MetroButton()
		Me.dgvBook = New MetroFramework.Controls.MetroGrid()
		Me.colBookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colBookName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colAuthorName = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.colBookCategoryName = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.colStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnAdd = New MetroFramework.Controls.MetroButton()
		Me.btnDelete = New MetroFramework.Controls.MetroButton()
		Me.btnUpdate = New MetroFramework.Controls.MetroButton()
		CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtBookName
		'
		Me.txtBookName.Location = New System.Drawing.Point(23, 63)
		Me.txtBookName.Name = "txtBookName"
		Me.txtBookName.Size = New System.Drawing.Size(592, 20)
		Me.txtBookName.TabIndex = 0
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
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(702, 60)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 1
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseSelectable = True
		'
		'dgvBook
		'
		Me.dgvBook.AllowUserToAddRows = False
		Me.dgvBook.AllowUserToDeleteRows = False
		Me.dgvBook.AllowUserToOrderColumns = True
		Me.dgvBook.AllowUserToResizeRows = False
		Me.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvBook.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBookID, Me.colBookName, Me.colAuthorName, Me.colBookCategoryName, Me.colStock, Me.colPrice})
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvBook.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvBook.EnableHeadersVisualStyles = False
		Me.dgvBook.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvBook.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvBook.Location = New System.Drawing.Point(24, 90)
		Me.dgvBook.Name = "dgvBook"
		Me.dgvBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvBook.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvBook.Size = New System.Drawing.Size(753, 308)
		Me.dgvBook.TabIndex = 2
		'
		'colBookID
		'
		Me.colBookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colBookID.DataPropertyName = "ID"
		Me.colBookID.FillWeight = 10.0!
		Me.colBookID.HeaderText = "ID"
		Me.colBookID.Name = "colBookID"
		Me.colBookID.ReadOnly = True
		'
		'colBookName
		'
		Me.colBookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colBookName.DataPropertyName = "Name"
		Me.colBookName.FillWeight = 40.0!
		Me.colBookName.HeaderText = "Name"
		Me.colBookName.Name = "colBookName"
		Me.colBookName.ReadOnly = True
		'
		'colAuthorName
		'
		Me.colAuthorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colAuthorName.DataPropertyName = "AuthorID"
		Me.colAuthorName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.colAuthorName.FillWeight = 15.0!
		Me.colAuthorName.HeaderText = "Author"
		Me.colAuthorName.Name = "colAuthorName"
		Me.colAuthorName.ReadOnly = True
		Me.colAuthorName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colAuthorName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'colBookCategoryName
		'
		Me.colBookCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colBookCategoryName.DataPropertyName = "BookCategoryID"
		Me.colBookCategoryName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.colBookCategoryName.FillWeight = 15.0!
		Me.colBookCategoryName.HeaderText = "Category"
		Me.colBookCategoryName.Name = "colBookCategoryName"
		Me.colBookCategoryName.ReadOnly = True
		Me.colBookCategoryName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colBookCategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'colStock
		'
		Me.colStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colStock.DataPropertyName = "Stock"
		Me.colStock.FillWeight = 10.0!
		Me.colStock.HeaderText = "Stock"
		Me.colStock.Name = "colStock"
		Me.colStock.ReadOnly = True
		'
		'colPrice
		'
		Me.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colPrice.DataPropertyName = "Price"
		Me.colPrice.FillWeight = 10.0!
		Me.colPrice.HeaderText = "Price"
		Me.colPrice.Name = "colPrice"
		Me.colPrice.ReadOnly = True
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
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(702, 404)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(75, 23)
		Me.btnDelete.TabIndex = 3
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseSelectable = True
		'
		'btnUpdate
		'
		Me.btnUpdate.Location = New System.Drawing.Point(366, 404)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
		Me.btnUpdate.TabIndex = 3
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseSelectable = True
		'
		'frmBook
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.dgvBook)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.txtBookName)
		Me.MaximizeBox = False
		Me.Name = "frmBook"
		Me.Resizable = False
		Me.ShowIcon = False
		Me.Text = "Book"
		CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Protected Overrides Sub Finalize()
		MyBase.Finalize()
	End Sub

	Friend WithEvents txtBookName As TextBox
	Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
	Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
	Friend WithEvents dgvBook As MetroFramework.Controls.MetroGrid
	Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
	Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
	Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
	Friend WithEvents colBookID As DataGridViewTextBoxColumn
	Friend WithEvents colBookName As DataGridViewTextBoxColumn
	Friend WithEvents colAuthorName As DataGridViewComboBoxColumn
	Friend WithEvents colBookCategoryName As DataGridViewComboBoxColumn
	Friend WithEvents colStock As DataGridViewTextBoxColumn
	Friend WithEvents colPrice As DataGridViewTextBoxColumn
End Class

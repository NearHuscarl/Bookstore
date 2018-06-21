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
		Me.dgvImport = New System.Windows.Forms.DataGridView()
		Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnAdd = New MetroFramework.Controls.MetroButton()
		Me.btnClear = New MetroFramework.Controls.MetroButton()
		Me.dtpReceivedDate = New MetroFramework.Controls.MetroDateTime()
		Me.lblReceivedDate = New MetroFramework.Controls.MetroLabel()
		Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
		Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
		Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ReceivedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.BookImportDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BookImportDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvImport
		'
		Me.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvImport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colCategory, Me.colAuthor, Me.colAmount, Me.colPrice})
		Me.dgvImport.Location = New System.Drawing.Point(23, 97)
		Me.dgvImport.Name = "dgvImport"
		Me.dgvImport.Size = New System.Drawing.Size(623, 100)
		Me.dgvImport.TabIndex = 1
		'
		'colID
		'
		Me.colID.HeaderText = "ID"
		Me.colID.MaxInputLength = 8
		Me.colID.Name = "colID"
		Me.colID.ReadOnly = True
		Me.colID.Width = 40
		'
		'colName
		'
		Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colName.HeaderText = "Name"
		Me.colName.MaxInputLength = 30
		Me.colName.Name = "colName"
		'
		'colCategory
		'
		Me.colCategory.HeaderText = "Category"
		Me.colCategory.MaxInputLength = 10
		Me.colCategory.Name = "colCategory"
		'
		'colAuthor
		'
		Me.colAuthor.HeaderText = "Author"
		Me.colAuthor.MaxInputLength = 20
		Me.colAuthor.Name = "colAuthor"
		'
		'colAmount
		'
		Me.colAmount.HeaderText = "Amount"
		Me.colAmount.MaxInputLength = 10
		Me.colAmount.Name = "colAmount"
		'
		'colPrice
		'
		Me.colPrice.HeaderText = "Price"
		Me.colPrice.MaxInputLength = 10
		Me.colPrice.Name = "colPrice"
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(188, 413)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(75, 23)
		Me.btnAdd.TabIndex = 5
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseSelectable = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(446, 413)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 6
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseSelectable = True
		'
		'dtpReceivedDate
		'
		Me.dtpReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpReceivedDate.Location = New System.Drawing.Point(385, 48)
		Me.dtpReceivedDate.MinimumSize = New System.Drawing.Size(0, 29)
		Me.dtpReceivedDate.Name = "dtpReceivedDate"
		Me.dtpReceivedDate.Size = New System.Drawing.Size(96, 29)
		Me.dtpReceivedDate.TabIndex = 7
		'
		'lblReceivedDate
		'
		Me.lblReceivedDate.AutoSize = True
		Me.lblReceivedDate.Location = New System.Drawing.Point(281, 54)
		Me.lblReceivedDate.Name = "lblReceivedDate"
		Me.lblReceivedDate.Size = New System.Drawing.Size(92, 19)
		Me.lblReceivedDate.TabIndex = 8
		Me.lblReceivedDate.Text = "Received Date"
		'
		'MetroGrid1
		'
		Me.MetroGrid1.AllowUserToResizeRows = False
		Me.MetroGrid1.AutoGenerateColumns = False
		Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.ReceivedDateDataGridViewTextBoxColumn})
		Me.MetroGrid1.DataSource = Me.BookImportDTOBindingSource
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
		Me.MetroGrid1.EnableHeadersVisualStyles = False
		Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.MetroGrid1.Location = New System.Drawing.Point(23, 229)
		Me.MetroGrid1.Name = "MetroGrid1"
		Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.MetroGrid1.Size = New System.Drawing.Size(829, 150)
		Me.MetroGrid1.TabIndex = 9
		'
		'IDDataGridViewTextBoxColumn
		'
		Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
		Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
		Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
		'
		'NameDataGridViewTextBoxColumn
		'
		Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
		Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
		Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
		'
		'CategoryDataGridViewTextBoxColumn
		'
		Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
		Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
		Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
		'
		'AuthorDataGridViewTextBoxColumn
		'
		Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
		Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
		Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
		'
		'AmountDataGridViewTextBoxColumn
		'
		Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
		Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
		Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
		'
		'PriceDataGridViewTextBoxColumn
		'
		Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
		Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
		Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
		'
		'ReceivedDateDataGridViewTextBoxColumn
		'
		Me.ReceivedDateDataGridViewTextBoxColumn.DataPropertyName = "ReceivedDate"
		Me.ReceivedDateDataGridViewTextBoxColumn.HeaderText = "ReceivedDate"
		Me.ReceivedDateDataGridViewTextBoxColumn.Name = "ReceivedDateDataGridViewTextBoxColumn"
		'
		'BookImportDTOBindingSource
		'
		Me.BookImportDTOBindingSource.DataSource = GetType(BookstoreManagement.DTO.BookImportDTO)
		'
		'frmImport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1011, 495)
		Me.Controls.Add(Me.MetroGrid1)
		Me.Controls.Add(Me.lblReceivedDate)
		Me.Controls.Add(Me.dtpReceivedDate)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.dgvImport)
		Me.Name = "frmImport"
		Me.ShowIcon = False
		Me.Text = "Import Book"
		CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BookImportDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents dgvImport As DataGridView
	Friend WithEvents colID As DataGridViewTextBoxColumn
	Friend WithEvents colName As DataGridViewTextBoxColumn
	Friend WithEvents colCategory As DataGridViewTextBoxColumn
	Friend WithEvents colAuthor As DataGridViewTextBoxColumn
	Friend WithEvents colAmount As DataGridViewTextBoxColumn
	Friend WithEvents colPrice As DataGridViewTextBoxColumn
	Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
	Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
	Friend WithEvents dtpReceivedDate As MetroFramework.Controls.MetroDateTime
	Friend WithEvents lblReceivedDate As MetroFramework.Controls.MetroLabel
	Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
	Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
	Friend WithEvents BookImportDTOBindingSource As BindingSource
	Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ReceivedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

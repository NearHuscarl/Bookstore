<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearch
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
		Me.dgvSearchResults = New MetroFramework.Controls.MetroGrid()
		Me.txtBookName = New MetroFramework.Controls.MetroTextBox()
		Me.lblBookName = New MetroFramework.Controls.MetroLabel()
		Me.lblCategory = New MetroFramework.Controls.MetroLabel()
		Me.cbbCategory = New MetroFramework.Controls.MetroComboBox()
		Me.lblAuthor = New MetroFramework.Controls.MetroLabel()
		Me.txtAuthor = New MetroFramework.Controls.MetroTextBox()
		Me.cbbAmount = New MetroFramework.Controls.MetroComboBox()
		Me.lblAmount = New MetroFramework.Controls.MetroLabel()
		Me.btnSearch = New MetroFramework.Controls.MetroButton()
		Me.colBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvSearchResults
		'
		Me.dgvSearchResults.AllowUserToResizeRows = False
		Me.dgvSearchResults.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgvSearchResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgvSearchResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvSearchResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvSearchResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBook, Me.colCategory, Me.colAuthor, Me.colAmount})
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvSearchResults.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvSearchResults.EnableHeadersVisualStyles = False
		Me.dgvSearchResults.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		Me.dgvSearchResults.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.dgvSearchResults.Location = New System.Drawing.Point(119, 153)
		Me.dgvSearchResults.Name = "dgvSearchResults"
		Me.dgvSearchResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvSearchResults.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.dgvSearchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dgvSearchResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvSearchResults.Size = New System.Drawing.Size(580, 227)
		Me.dgvSearchResults.TabIndex = 9
		'
		'txtBookName
		'
		'
		'
		'
		Me.txtBookName.CustomButton.Image = Nothing
		Me.txtBookName.CustomButton.Location = New System.Drawing.Point(163, 1)
		Me.txtBookName.CustomButton.Name = ""
		Me.txtBookName.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtBookName.CustomButton.TabIndex = 1
		Me.txtBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtBookName.CustomButton.UseSelectable = True
		Me.txtBookName.CustomButton.Visible = False
		Me.txtBookName.Lines = New String(-1) {}
		Me.txtBookName.Location = New System.Drawing.Point(176, 73)
		Me.txtBookName.MaxLength = 32767
		Me.txtBookName.Name = "txtBookName"
		Me.txtBookName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtBookName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtBookName.SelectedText = ""
		Me.txtBookName.SelectionLength = 0
		Me.txtBookName.SelectionStart = 0
		Me.txtBookName.ShortcutsEnabled = True
		Me.txtBookName.Size = New System.Drawing.Size(185, 23)
		Me.txtBookName.TabIndex = 10
		Me.txtBookName.UseSelectable = True
		Me.txtBookName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtBookName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'lblBookName
		'
		Me.lblBookName.AutoSize = True
		Me.lblBookName.Location = New System.Drawing.Point(91, 73)
		Me.lblBookName.Name = "lblBookName"
		Me.lblBookName.Size = New System.Drawing.Size(79, 19)
		Me.lblBookName.TabIndex = 11
		Me.lblBookName.Text = "Book Name"
		'
		'lblCategory
		'
		Me.lblCategory.AutoSize = True
		Me.lblCategory.Location = New System.Drawing.Point(106, 106)
		Me.lblCategory.Name = "lblCategory"
		Me.lblCategory.Size = New System.Drawing.Size(64, 19)
		Me.lblCategory.TabIndex = 13
		Me.lblCategory.Text = "Category"
		'
		'cbbCategory
		'
		Me.cbbCategory.FormattingEnabled = True
		Me.cbbCategory.ItemHeight = 23
		Me.cbbCategory.Location = New System.Drawing.Point(175, 102)
		Me.cbbCategory.Name = "cbbCategory"
		Me.cbbCategory.Size = New System.Drawing.Size(186, 29)
		Me.cbbCategory.TabIndex = 14
		Me.cbbCategory.UseSelectable = True
		'
		'lblAuthor
		'
		Me.lblAuthor.AutoSize = True
		Me.lblAuthor.Location = New System.Drawing.Point(407, 75)
		Me.lblAuthor.Name = "lblAuthor"
		Me.lblAuthor.Size = New System.Drawing.Size(49, 19)
		Me.lblAuthor.TabIndex = 16
		Me.lblAuthor.Text = "Author"
		'
		'txtAuthor
		'
		'
		'
		'
		Me.txtAuthor.CustomButton.Image = Nothing
		Me.txtAuthor.CustomButton.Location = New System.Drawing.Point(124, 1)
		Me.txtAuthor.CustomButton.Name = ""
		Me.txtAuthor.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtAuthor.CustomButton.TabIndex = 1
		Me.txtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtAuthor.CustomButton.UseSelectable = True
		Me.txtAuthor.CustomButton.Visible = False
		Me.txtAuthor.Lines = New String(-1) {}
		Me.txtAuthor.Location = New System.Drawing.Point(462, 75)
		Me.txtAuthor.MaxLength = 32767
		Me.txtAuthor.Name = "txtAuthor"
		Me.txtAuthor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAuthor.SelectedText = ""
		Me.txtAuthor.SelectionLength = 0
		Me.txtAuthor.SelectionStart = 0
		Me.txtAuthor.ShortcutsEnabled = True
		Me.txtAuthor.Size = New System.Drawing.Size(146, 23)
		Me.txtAuthor.TabIndex = 15
		Me.txtAuthor.UseSelectable = True
		Me.txtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtAuthor.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'cbbAmount
		'
		Me.cbbAmount.FormattingEnabled = True
		Me.cbbAmount.ItemHeight = 23
		Me.cbbAmount.Location = New System.Drawing.Point(461, 104)
		Me.cbbAmount.Name = "cbbAmount"
		Me.cbbAmount.Size = New System.Drawing.Size(147, 29)
		Me.cbbAmount.TabIndex = 18
		Me.cbbAmount.UseSelectable = True
		'
		'lblAmount
		'
		Me.lblAmount.AutoSize = True
		Me.lblAmount.Location = New System.Drawing.Point(399, 110)
		Me.lblAmount.Name = "lblAmount"
		Me.lblAmount.Size = New System.Drawing.Size(56, 19)
		Me.lblAmount.TabIndex = 17
		Me.lblAmount.Text = "Amount"
		'
		'btnSearch
		'
		Me.btnSearch.Location = New System.Drawing.Point(635, 108)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(75, 23)
		Me.btnSearch.TabIndex = 19
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseSelectable = True
		'
		'colBook
		'
		Me.colBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.colBook.FillWeight = 172.2907!
		Me.colBook.HeaderText = "Book"
		Me.colBook.Name = "colBook"
		Me.colBook.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		'
		'colCategory
		'
		Me.colCategory.HeaderText = "Category"
		Me.colCategory.Name = "colCategory"
		Me.colCategory.ReadOnly = True
		Me.colCategory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.colCategory.Width = 150
		'
		'colAuthor
		'
		Me.colAuthor.FillWeight = 60.14212!
		Me.colAuthor.HeaderText = "Author"
		Me.colAuthor.Name = "colAuthor"
		Me.colAuthor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colAuthor.Width = 115
		'
		'colAmount
		'
		Me.colAmount.FillWeight = 123.8739!
		Me.colAmount.HeaderText = "Amount"
		Me.colAmount.Name = "colAmount"
		Me.colAmount.ReadOnly = True
		Me.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.colAmount.Width = 110
		'
		'frmSearch
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(818, 437)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.cbbAmount)
		Me.Controls.Add(Me.lblAmount)
		Me.Controls.Add(Me.lblAuthor)
		Me.Controls.Add(Me.txtAuthor)
		Me.Controls.Add(Me.cbbCategory)
		Me.Controls.Add(Me.lblCategory)
		Me.Controls.Add(Me.lblBookName)
		Me.Controls.Add(Me.txtBookName)
		Me.Controls.Add(Me.dgvSearchResults)
		Me.Name = "frmSearch"
		Me.ShowIcon = False
		Me.Text = "Search"
		CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ReceivedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents dgvSearchResults As MetroFramework.Controls.MetroGrid
	Friend WithEvents DateImportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents txtBookName As MetroFramework.Controls.MetroTextBox
	Friend WithEvents lblBookName As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblCategory As MetroFramework.Controls.MetroLabel
	Friend WithEvents cbbCategory As MetroFramework.Controls.MetroComboBox
	Friend WithEvents lblAuthor As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtAuthor As MetroFramework.Controls.MetroTextBox
	Friend WithEvents cbbAmount As MetroFramework.Controls.MetroComboBox
	Friend WithEvents lblAmount As MetroFramework.Controls.MetroLabel
	Friend WithEvents btnSearch As MetroFramework.Controls.MetroButton
	Friend WithEvents colBook As DataGridViewTextBoxColumn
	Friend WithEvents colCategory As DataGridViewTextBoxColumn
	Friend WithEvents colAuthor As DataGridViewTextBoxColumn
	Friend WithEvents colAmount As DataGridViewTextBoxColumn
End Class

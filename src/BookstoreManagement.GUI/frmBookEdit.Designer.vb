<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookEdit
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
		Me.lblID = New MetroFramework.Controls.MetroLabel()
		Me.lblName = New MetroFramework.Controls.MetroLabel()
		Me.lblAuthor = New MetroFramework.Controls.MetroLabel()
		Me.lblCategory = New MetroFramework.Controls.MetroLabel()
		Me.lblStock = New MetroFramework.Controls.MetroLabel()
		Me.lblPrice = New MetroFramework.Controls.MetroLabel()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.cbAuthor = New System.Windows.Forms.ComboBox()
		Me.cbCategory = New System.Windows.Forms.ComboBox()
		Me.txtStock = New System.Windows.Forms.TextBox()
		Me.txtPrice = New System.Windows.Forms.TextBox()
		Me.btnAddAuthor = New MetroFramework.Controls.MetroButton()
		Me.btnAddCategory = New MetroFramework.Controls.MetroButton()
		Me.btnConfirm = New MetroFramework.Controls.MetroButton()
		Me.btnCancel = New MetroFramework.Controls.MetroButton()
		Me.SuspendLayout()
		'
		'lblID
		'
		Me.lblID.AutoSize = True
		Me.lblID.Location = New System.Drawing.Point(23, 60)
		Me.lblID.Name = "lblID"
		Me.lblID.Size = New System.Drawing.Size(21, 19)
		Me.lblID.TabIndex = 0
		Me.lblID.Text = "ID"
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(23, 86)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(45, 19)
		Me.lblName.TabIndex = 0
		Me.lblName.Text = "Name"
		'
		'lblAuthor
		'
		Me.lblAuthor.AutoSize = True
		Me.lblAuthor.Location = New System.Drawing.Point(23, 113)
		Me.lblAuthor.Name = "lblAuthor"
		Me.lblAuthor.Size = New System.Drawing.Size(49, 19)
		Me.lblAuthor.TabIndex = 0
		Me.lblAuthor.Text = "Author"
		'
		'lblCategory
		'
		Me.lblCategory.AutoSize = True
		Me.lblCategory.Location = New System.Drawing.Point(23, 140)
		Me.lblCategory.Name = "lblCategory"
		Me.lblCategory.Size = New System.Drawing.Size(64, 19)
		Me.lblCategory.TabIndex = 0
		Me.lblCategory.Text = "Category"
		'
		'lblStock
		'
		Me.lblStock.AutoSize = True
		Me.lblStock.Location = New System.Drawing.Point(23, 166)
		Me.lblStock.Name = "lblStock"
		Me.lblStock.Size = New System.Drawing.Size(40, 19)
		Me.lblStock.TabIndex = 0
		Me.lblStock.Text = "Stock"
		'
		'lblPrice
		'
		Me.lblPrice.AutoSize = True
		Me.lblPrice.Location = New System.Drawing.Point(23, 192)
		Me.lblPrice.Name = "lblPrice"
		Me.lblPrice.Size = New System.Drawing.Size(38, 19)
		Me.lblPrice.TabIndex = 0
		Me.lblPrice.Text = "Price"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(110, 59)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(467, 20)
		Me.txtID.TabIndex = 1
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(110, 85)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(467, 20)
		Me.txtName.TabIndex = 2
		'
		'cbAuthor
		'
		Me.cbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbAuthor.FormattingEnabled = True
		Me.cbAuthor.Location = New System.Drawing.Point(110, 111)
		Me.cbAuthor.Name = "cbAuthor"
		Me.cbAuthor.Size = New System.Drawing.Size(386, 21)
		Me.cbAuthor.TabIndex = 3
		'
		'cbCategory
		'
		Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbCategory.FormattingEnabled = True
		Me.cbCategory.Location = New System.Drawing.Point(110, 138)
		Me.cbCategory.Name = "cbCategory"
		Me.cbCategory.Size = New System.Drawing.Size(386, 21)
		Me.cbCategory.TabIndex = 3
		'
		'txtStock
		'
		Me.txtStock.Location = New System.Drawing.Point(110, 165)
		Me.txtStock.Name = "txtStock"
		Me.txtStock.ReadOnly = True
		Me.txtStock.Size = New System.Drawing.Size(467, 20)
		Me.txtStock.TabIndex = 1
		'
		'txtPrice
		'
		Me.txtPrice.Location = New System.Drawing.Point(110, 191)
		Me.txtPrice.Name = "txtPrice"
		Me.txtPrice.Size = New System.Drawing.Size(467, 20)
		Me.txtPrice.TabIndex = 1
		'
		'btnAddAuthor
		'
		Me.btnAddAuthor.Location = New System.Drawing.Point(502, 109)
		Me.btnAddAuthor.Name = "btnAddAuthor"
		Me.btnAddAuthor.Size = New System.Drawing.Size(75, 23)
		Me.btnAddAuthor.TabIndex = 4
		Me.btnAddAuthor.Text = "Add"
		Me.btnAddAuthor.UseSelectable = True
		'
		'btnAddCategory
		'
		Me.btnAddCategory.Location = New System.Drawing.Point(502, 136)
		Me.btnAddCategory.Name = "btnAddCategory"
		Me.btnAddCategory.Size = New System.Drawing.Size(75, 23)
		Me.btnAddCategory.TabIndex = 4
		Me.btnAddCategory.Text = "Add"
		Me.btnAddCategory.UseSelectable = True
		'
		'btnConfirm
		'
		Me.btnConfirm.Location = New System.Drawing.Point(23, 292)
		Me.btnConfirm.Name = "btnConfirm"
		Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
		Me.btnConfirm.TabIndex = 4
		Me.btnConfirm.Text = "Confirm"
		Me.btnConfirm.UseSelectable = True
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(502, 292)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 4
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseSelectable = True
		'
		'frmBookEdit
		'
		Me.AcceptButton = Me.btnConfirm
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(600, 338)
		Me.Controls.Add(Me.btnAddCategory)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnConfirm)
		Me.Controls.Add(Me.btnAddAuthor)
		Me.Controls.Add(Me.cbCategory)
		Me.Controls.Add(Me.cbAuthor)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.txtPrice)
		Me.Controls.Add(Me.txtStock)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.lblPrice)
		Me.Controls.Add(Me.lblStock)
		Me.Controls.Add(Me.lblCategory)
		Me.Controls.Add(Me.lblAuthor)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.lblID)
		Me.MaximizeBox = False
		Me.Name = "frmBookEdit"
		Me.Resizable = False
		Me.ShowIcon = False
		Me.Text = "Book"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblID As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblAuthor As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblCategory As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblStock As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblPrice As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtID As TextBox
	Friend WithEvents txtName As TextBox
	Friend WithEvents cbAuthor As ComboBox
	Friend WithEvents cbCategory As ComboBox
	Friend WithEvents txtStock As TextBox
	Friend WithEvents txtPrice As TextBox
	Friend WithEvents btnAddAuthor As MetroFramework.Controls.MetroButton
	Friend WithEvents btnAddCategory As MetroFramework.Controls.MetroButton
	Friend WithEvents btnConfirm As MetroFramework.Controls.MetroButton
	Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
End Class

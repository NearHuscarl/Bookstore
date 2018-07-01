<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerEdit
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
		Me.lblAddress = New MetroFramework.Controls.MetroLabel()
		Me.lblEmail = New MetroFramework.Controls.MetroLabel()
		Me.lblPhoneNumber = New MetroFramework.Controls.MetroLabel()
		Me.lblDebt = New MetroFramework.Controls.MetroLabel()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.txtPhone = New System.Windows.Forms.TextBox()
		Me.txtDebt = New System.Windows.Forms.TextBox()
		Me.btnCancel = New MetroFramework.Controls.MetroButton()
		Me.btnConfirm = New MetroFramework.Controls.MetroButton()
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
		Me.lblName.TabIndex = 1
		Me.lblName.Text = "Name"
		'
		'lblAddress
		'
		Me.lblAddress.AutoSize = True
		Me.lblAddress.Location = New System.Drawing.Point(23, 112)
		Me.lblAddress.Name = "lblAddress"
		Me.lblAddress.Size = New System.Drawing.Size(56, 19)
		Me.lblAddress.TabIndex = 1
		Me.lblAddress.Text = "Address"
		'
		'lblEmail
		'
		Me.lblEmail.AutoSize = True
		Me.lblEmail.Location = New System.Drawing.Point(23, 138)
		Me.lblEmail.Name = "lblEmail"
		Me.lblEmail.Size = New System.Drawing.Size(41, 19)
		Me.lblEmail.TabIndex = 1
		Me.lblEmail.Text = "Email"
		'
		'lblPhoneNumber
		'
		Me.lblPhoneNumber.AutoSize = True
		Me.lblPhoneNumber.Location = New System.Drawing.Point(23, 164)
		Me.lblPhoneNumber.Name = "lblPhoneNumber"
		Me.lblPhoneNumber.Size = New System.Drawing.Size(46, 19)
		Me.lblPhoneNumber.TabIndex = 1
		Me.lblPhoneNumber.Text = "Phone"
		'
		'lblDebt
		'
		Me.lblDebt.AutoSize = True
		Me.lblDebt.Location = New System.Drawing.Point(23, 190)
		Me.lblDebt.Name = "lblDebt"
		Me.lblDebt.Size = New System.Drawing.Size(37, 19)
		Me.lblDebt.TabIndex = 1
		Me.lblDebt.Text = "Debt"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(110, 59)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(467, 20)
		Me.txtID.TabIndex = 2
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(110, 85)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(467, 20)
		Me.txtName.TabIndex = 2
		'
		'txtAddress
		'
		Me.txtAddress.Location = New System.Drawing.Point(110, 111)
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(467, 20)
		Me.txtAddress.TabIndex = 2
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(110, 137)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(467, 20)
		Me.txtEmail.TabIndex = 2
		'
		'txtPhone
		'
		Me.txtPhone.Location = New System.Drawing.Point(110, 163)
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(467, 20)
		Me.txtPhone.TabIndex = 2
		'
		'txtDebt
		'
		Me.txtDebt.Location = New System.Drawing.Point(110, 189)
		Me.txtDebt.Name = "txtDebt"
		Me.txtDebt.ReadOnly = True
		Me.txtDebt.Size = New System.Drawing.Size(467, 20)
		Me.txtDebt.TabIndex = 2
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(502, 292)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 3
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseSelectable = True
		'
		'btnConfirm
		'
		Me.btnConfirm.Location = New System.Drawing.Point(23, 292)
		Me.btnConfirm.Name = "btnConfirm"
		Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
		Me.btnConfirm.TabIndex = 3
		Me.btnConfirm.Text = "Confirm"
		Me.btnConfirm.UseSelectable = True
		'
		'frmCustomerEdit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(600, 338)
		Me.Controls.Add(Me.btnConfirm)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.txtDebt)
		Me.Controls.Add(Me.txtPhone)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.txtAddress)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.lblDebt)
		Me.Controls.Add(Me.lblPhoneNumber)
		Me.Controls.Add(Me.lblEmail)
		Me.Controls.Add(Me.lblAddress)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.lblID)
		Me.MaximizeBox = False
		Me.Name = "frmCustomerEdit"
		Me.Resizable = False
		Me.ShowIcon = False
		Me.Text = "Customer"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblID As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblAddress As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblEmail As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblPhoneNumber As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblDebt As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtID As TextBox
	Friend WithEvents txtName As TextBox
	Friend WithEvents txtAddress As TextBox
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents txtPhone As TextBox
	Friend WithEvents txtDebt As TextBox
	Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
	Friend WithEvents btnConfirm As MetroFramework.Controls.MetroButton
End Class

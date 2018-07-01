<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuthorEdit
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
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.txtName = New System.Windows.Forms.TextBox()
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
		Me.lblName.TabIndex = 1
		Me.lblName.Text = "Name"
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(110, 59)
		Me.txtID.Name = "txtID"
		Me.txtID.ReadOnly = True
		Me.txtID.Size = New System.Drawing.Size(266, 20)
		Me.txtID.TabIndex = 2
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(110, 85)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(266, 20)
		Me.txtName.TabIndex = 2
		'
		'btnConfirm
		'
		Me.btnConfirm.Location = New System.Drawing.Point(23, 179)
		Me.btnConfirm.Name = "btnConfirm"
		Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
		Me.btnConfirm.TabIndex = 3
		Me.btnConfirm.Text = "Confirm"
		Me.btnConfirm.UseSelectable = True
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(301, 179)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 3
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseSelectable = True
		'
		'frmAuthorEdit
		'
		Me.AcceptButton = Me.btnConfirm
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(400, 225)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnConfirm)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.txtID)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.lblID)
		Me.MaximizeBox = False
		Me.Name = "frmAuthorEdit"
		Me.Resizable = False
		Me.ShowIcon = False
		Me.Text = "Author"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Protected Overrides Sub Finalize()
		MyBase.Finalize()
	End Sub

	Friend WithEvents lblID As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtID As TextBox
	Friend WithEvents txtName As TextBox
	Friend WithEvents btnConfirm As MetroFramework.Controls.MetroButton
	Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
End Class

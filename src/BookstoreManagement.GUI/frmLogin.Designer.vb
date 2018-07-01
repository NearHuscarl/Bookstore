<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
		Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
		Me.btnLogin = New MetroFramework.Controls.MetroButton()
		Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
		Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
		Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
		Me.pbPassword = New System.Windows.Forms.PictureBox()
		Me.pbUsername = New System.Windows.Forms.PictureBox()
		Me.pbLogin = New System.Windows.Forms.PictureBox()
		Me.lblPassword = New MetroFramework.Controls.MetroLabel()
		Me.lblUsername = New MetroFramework.Controls.MetroLabel()
		Me.ckbRememberMe = New MetroFramework.Controls.MetroCheckBox()
		Me.pnlLogin = New MetroFramework.Controls.MetroPanel()
		Me.MetroPanel1.SuspendLayout()
		Me.MetroPanel2.SuspendLayout()
		CType(Me.pbPassword, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbUsername, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlLogin.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtUsername
		'
		'
		'
		'
		Me.txtUsername.CustomButton.Image = Nothing
		Me.txtUsername.CustomButton.Location = New System.Drawing.Point(120, 1)
		Me.txtUsername.CustomButton.Name = ""
		Me.txtUsername.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtUsername.CustomButton.TabIndex = 1
		Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtUsername.CustomButton.UseSelectable = True
		Me.txtUsername.CustomButton.Visible = False
		Me.txtUsername.Lines = New String(-1) {}
		Me.txtUsername.Location = New System.Drawing.Point(21, 0)
		Me.txtUsername.MaxLength = 32767
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUsername.SelectedText = ""
		Me.txtUsername.SelectionLength = 0
		Me.txtUsername.SelectionStart = 0
		Me.txtUsername.ShortcutsEnabled = True
		Me.txtUsername.Size = New System.Drawing.Size(142, 23)
		Me.txtUsername.TabIndex = 0
		Me.txtUsername.UseSelectable = True
		Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'btnLogin
		'
		Me.btnLogin.Location = New System.Drawing.Point(31, 242)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(163, 23)
		Me.btnLogin.TabIndex = 2
		Me.btnLogin.Text = "Login"
		Me.btnLogin.UseSelectable = True
		'
		'MetroPanel1
		'
		Me.MetroPanel1.Controls.Add(Me.pbUsername)
		Me.MetroPanel1.Controls.Add(Me.txtUsername)
		Me.MetroPanel1.HorizontalScrollbarBarColor = True
		Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
		Me.MetroPanel1.HorizontalScrollbarSize = 10
		Me.MetroPanel1.Location = New System.Drawing.Point(31, 141)
		Me.MetroPanel1.Name = "MetroPanel1"
		Me.MetroPanel1.Size = New System.Drawing.Size(163, 23)
		Me.MetroPanel1.TabIndex = 4
		Me.MetroPanel1.VerticalScrollbarBarColor = True
		Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
		Me.MetroPanel1.VerticalScrollbarSize = 10
		'
		'MetroPanel2
		'
		Me.MetroPanel2.Controls.Add(Me.pbPassword)
		Me.MetroPanel2.Controls.Add(Me.txtPassword)
		Me.MetroPanel2.HorizontalScrollbarBarColor = True
		Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
		Me.MetroPanel2.HorizontalScrollbarSize = 10
		Me.MetroPanel2.Location = New System.Drawing.Point(31, 192)
		Me.MetroPanel2.Name = "MetroPanel2"
		Me.MetroPanel2.Size = New System.Drawing.Size(163, 23)
		Me.MetroPanel2.TabIndex = 5
		Me.MetroPanel2.VerticalScrollbarBarColor = True
		Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
		Me.MetroPanel2.VerticalScrollbarSize = 10
		'
		'txtPassword
		'
		'
		'
		'
		Me.txtPassword.CustomButton.Image = Nothing
		Me.txtPassword.CustomButton.Location = New System.Drawing.Point(120, 1)
		Me.txtPassword.CustomButton.Name = ""
		Me.txtPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtPassword.CustomButton.TabIndex = 1
		Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtPassword.CustomButton.UseSelectable = True
		Me.txtPassword.CustomButton.Visible = False
		Me.txtPassword.Lines = New String(-1) {}
		Me.txtPassword.Location = New System.Drawing.Point(21, 0)
		Me.txtPassword.MaxLength = 32767
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
		Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPassword.SelectedText = ""
		Me.txtPassword.SelectionLength = 0
		Me.txtPassword.SelectionStart = 0
		Me.txtPassword.ShortcutsEnabled = True
		Me.txtPassword.Size = New System.Drawing.Size(142, 23)
		Me.txtPassword.TabIndex = 1
		Me.txtPassword.UseSelectable = True
		Me.txtPassword.UseSystemPasswordChar = True
		Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'pbPassword
		'
		Me.pbPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				Or System.Windows.Forms.AnchorStyles.Left) _
				Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pbPassword.Image = Global.BookstoreManagement.GUI.My.Resources.Resources.Password
		Me.pbPassword.Location = New System.Drawing.Point(0, 0)
		Me.pbPassword.Name = "pbPassword"
		Me.pbPassword.Size = New System.Drawing.Size(23, 23)
		Me.pbPassword.TabIndex = 7
		Me.pbPassword.TabStop = False
		'
		'pbUsername
		'
		Me.pbUsername.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.pbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pbUsername.Image = Global.BookstoreManagement.GUI.My.Resources.Resources.Username
		Me.pbUsername.Location = New System.Drawing.Point(0, 0)
		Me.pbUsername.Name = "pbUsername"
		Me.pbUsername.Size = New System.Drawing.Size(23, 23)
		Me.pbUsername.TabIndex = 6
		Me.pbUsername.TabStop = False
		'
		'pbLogin
		'
		Me.pbLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				Or System.Windows.Forms.AnchorStyles.Left) _
				Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pbLogin.Image = Global.BookstoreManagement.GUI.My.Resources.Resources.Login
		Me.pbLogin.Location = New System.Drawing.Point(67, 22)
		Me.pbLogin.Name = "pbLogin"
		Me.pbLogin.Size = New System.Drawing.Size(82, 82)
		Me.pbLogin.TabIndex = 3
		Me.pbLogin.TabStop = False
		'
		'lblPassword
		'
		Me.lblPassword.AutoSize = True
		Me.lblPassword.Location = New System.Drawing.Point(27, 170)
		Me.lblPassword.Name = "lblPassword"
		Me.lblPassword.Size = New System.Drawing.Size(63, 19)
		Me.lblPassword.TabIndex = 6
		Me.lblPassword.Text = "Password"
		Me.lblPassword.UseCustomBackColor = True
		'
		'lblUsername
		'
		Me.lblUsername.AutoSize = True
		Me.lblUsername.Location = New System.Drawing.Point(27, 119)
		Me.lblUsername.Name = "lblUsername"
		Me.lblUsername.Size = New System.Drawing.Size(68, 19)
		Me.lblUsername.TabIndex = 7
		Me.lblUsername.Text = "Username"
		Me.lblUsername.UseCustomBackColor = True
		'
		'ckbRememberMe
		'
		Me.ckbRememberMe.AutoSize = True
		Me.ckbRememberMe.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
		Me.ckbRememberMe.Location = New System.Drawing.Point(31, 221)
		Me.ckbRememberMe.Name = "ckbRememberMe"
		Me.ckbRememberMe.Size = New System.Drawing.Size(103, 15)
		Me.ckbRememberMe.TabIndex = 8
		Me.ckbRememberMe.Text = "Remember Me?"
		Me.ckbRememberMe.UseCustomBackColor = True
		Me.ckbRememberMe.UseSelectable = True
		'
		'pnlLogin
		'
		Me.pnlLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
		Me.pnlLogin.Controls.Add(Me.lblUsername)
		Me.pnlLogin.Controls.Add(Me.ckbRememberMe)
		Me.pnlLogin.Controls.Add(Me.pbLogin)
		Me.pnlLogin.Controls.Add(Me.lblPassword)
		Me.pnlLogin.Controls.Add(Me.btnLogin)
		Me.pnlLogin.Controls.Add(Me.MetroPanel2)
		Me.pnlLogin.Controls.Add(Me.MetroPanel1)
		Me.pnlLogin.HorizontalScrollbarBarColor = True
		Me.pnlLogin.HorizontalScrollbarHighlightOnWheel = False
		Me.pnlLogin.HorizontalScrollbarSize = 10
		Me.pnlLogin.Location = New System.Drawing.Point(263, 63)
		Me.pnlLogin.Name = "pnlLogin"
		Me.pnlLogin.Size = New System.Drawing.Size(225, 282)
		Me.pnlLogin.TabIndex = 9
		Me.pnlLogin.UseCustomBackColor = True
		Me.pnlLogin.VerticalScrollbarBarColor = True
		Me.pnlLogin.VerticalScrollbarHighlightOnWheel = False
		Me.pnlLogin.VerticalScrollbarSize = 10
		'
		'frmLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(750, 400)
		Me.Controls.Add(Me.pnlLogin)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frmLogin"
		Me.Resizable = False
		Me.Style = MetroFramework.MetroColorStyle.Green
		Me.MetroPanel1.ResumeLayout(False)
		Me.MetroPanel2.ResumeLayout(False)
		CType(Me.pbPassword, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbUsername, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbLogin, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlLogin.ResumeLayout(False)
		Me.pnlLogin.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
	Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
	Friend WithEvents pbLogin As PictureBox
	Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
	Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
	Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
	Friend WithEvents pbUsername As PictureBox
	Friend WithEvents pbPassword As PictureBox
	Friend WithEvents lblPassword As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
	Friend WithEvents ckbRememberMe As MetroFramework.Controls.MetroCheckBox
	Friend WithEvents pnlLogin As MetroFramework.Controls.MetroPanel
End Class

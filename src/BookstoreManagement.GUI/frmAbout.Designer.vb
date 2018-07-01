<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
		Me.lblName = New MetroFramework.Controls.MetroLabel()
		Me.lblAuthors = New MetroFramework.Controls.MetroLabel()
		Me.lblVersionText = New MetroFramework.Controls.MetroLabel()
		Me.lblVersion = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
		Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
		Me.pnlAbout = New MetroFramework.Controls.MetroPanel()
		Me.lblSourceCode = New MetroFramework.Controls.MetroLabel()
		Me.lkSourceCode = New MetroFramework.Controls.MetroLink()
		Me.pnlAbout.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.FontSize = MetroFramework.MetroLabelSize.Tall
		Me.lblName.Location = New System.Drawing.Point(47, 28)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(193, 25)
		Me.lblName.TabIndex = 0
		Me.lblName.Text = "Bookstore Management"
		Me.lblName.UseCustomBackColor = True
		'
		'lblAuthors
		'
		Me.lblAuthors.AutoSize = True
		Me.lblAuthors.FontWeight = MetroFramework.MetroLabelWeight.Regular
		Me.lblAuthors.Location = New System.Drawing.Point(55, 92)
		Me.lblAuthors.Name = "lblAuthors"
		Me.lblAuthors.Size = New System.Drawing.Size(61, 19)
		Me.lblAuthors.TabIndex = 1
		Me.lblAuthors.Text = "Authors:"
		Me.lblAuthors.UseCustomBackColor = True
		'
		'lblVersionText
		'
		Me.lblVersionText.AutoSize = True
		Me.lblVersionText.FontWeight = MetroFramework.MetroLabelWeight.Regular
		Me.lblVersionText.Location = New System.Drawing.Point(55, 152)
		Me.lblVersionText.Name = "lblVersionText"
		Me.lblVersionText.Size = New System.Drawing.Size(57, 19)
		Me.lblVersionText.TabIndex = 2
		Me.lblVersionText.Text = "Version:"
		Me.lblVersionText.UseCustomBackColor = True
		'
		'lblVersion
		'
		Me.lblVersion.AutoSize = True
		Me.lblVersion.Location = New System.Drawing.Point(122, 152)
		Me.lblVersion.Name = "lblVersion"
		Me.lblVersion.Size = New System.Drawing.Size(36, 19)
		Me.lblVersion.TabIndex = 3
		Me.lblVersion.Text = "0.0.0"
		Me.lblVersion.UseCustomBackColor = True
		'
		'MetroLabel1
		'
		Me.MetroLabel1.AutoSize = True
		Me.MetroLabel1.Location = New System.Drawing.Point(122, 92)
		Me.MetroLabel1.Name = "MetroLabel1"
		Me.MetroLabel1.Size = New System.Drawing.Size(89, 19)
		Me.MetroLabel1.TabIndex = 4
		Me.MetroLabel1.Text = "Hồng Gia Lập"
		Me.MetroLabel1.UseCustomBackColor = True
		'
		'MetroLabel2
		'
		Me.MetroLabel2.AutoSize = True
		Me.MetroLabel2.Location = New System.Drawing.Point(122, 121)
		Me.MetroLabel2.Name = "MetroLabel2"
		Me.MetroLabel2.Size = New System.Drawing.Size(142, 19)
		Me.MetroLabel2.TabIndex = 5
		Me.MetroLabel2.Text = "Nguyễn Khánh Nguyên"
		Me.MetroLabel2.UseCustomBackColor = True
		'
		'pnlAbout
		'
		Me.pnlAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
		Me.pnlAbout.Controls.Add(Me.lkSourceCode)
		Me.pnlAbout.Controls.Add(Me.lblSourceCode)
		Me.pnlAbout.Controls.Add(Me.lblName)
		Me.pnlAbout.Controls.Add(Me.MetroLabel2)
		Me.pnlAbout.Controls.Add(Me.MetroLabel1)
		Me.pnlAbout.Controls.Add(Me.lblVersion)
		Me.pnlAbout.Controls.Add(Me.lblAuthors)
		Me.pnlAbout.Controls.Add(Me.lblVersionText)
		Me.pnlAbout.HorizontalScrollbarBarColor = True
		Me.pnlAbout.HorizontalScrollbarHighlightOnWheel = False
		Me.pnlAbout.HorizontalScrollbarSize = 10
		Me.pnlAbout.Location = New System.Drawing.Point(30, 63)
		Me.pnlAbout.Name = "pnlAbout"
		Me.pnlAbout.Size = New System.Drawing.Size(289, 222)
		Me.pnlAbout.TabIndex = 6
		Me.pnlAbout.UseCustomBackColor = True
		Me.pnlAbout.VerticalScrollbarBarColor = True
		Me.pnlAbout.VerticalScrollbarHighlightOnWheel = False
		Me.pnlAbout.VerticalScrollbarSize = 10
		'
		'lblSourceCode
		'
		Me.lblSourceCode.AutoSize = True
		Me.lblSourceCode.FontWeight = MetroFramework.MetroLabelWeight.Regular
		Me.lblSourceCode.Location = New System.Drawing.Point(27, 184)
		Me.lblSourceCode.Name = "lblSourceCode"
		Me.lblSourceCode.Size = New System.Drawing.Size(89, 19)
		Me.lblSourceCode.TabIndex = 6
		Me.lblSourceCode.Text = "Source Code:"
		Me.lblSourceCode.UseCustomBackColor = True
		'
		'lkSourceCode
		'
		Me.lkSourceCode.Location = New System.Drawing.Point(122, 184)
		Me.lkSourceCode.Name = "lkSourceCode"
		Me.lkSourceCode.Size = New System.Drawing.Size(49, 19)
		Me.lkSourceCode.TabIndex = 7
		Me.lkSourceCode.Text = "Github"
		Me.lkSourceCode.UseCustomBackColor = True
		Me.lkSourceCode.UseSelectable = True
		'
		'frmAbout
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(342, 308)
		Me.Controls.Add(Me.pnlAbout)
		Me.MaximizeBox = False
		Me.Name = "frmAbout"
		Me.Resizable = False
		Me.Text = "About"
		Me.pnlAbout.ResumeLayout(False)
		Me.pnlAbout.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblAuthors As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblVersionText As MetroFramework.Controls.MetroLabel
	Friend WithEvents lblVersion As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
	Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
	Friend WithEvents pnlAbout As MetroFramework.Controls.MetroPanel
	Friend WithEvents lblSourceCode As MetroFramework.Controls.MetroLabel
	Friend WithEvents lkSourceCode As MetroFramework.Controls.MetroLink
End Class

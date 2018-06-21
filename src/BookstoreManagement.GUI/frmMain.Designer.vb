<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImportBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BookToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookToolStripMenuItem, Me.ManagementToolStripMenuItem, Me.BookToolStripMenuItem1})
		Me.MenuStrip1.Location = New System.Drawing.Point(20, 60)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(760, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'BookToolStripMenuItem
		'
		Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
		Me.BookToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.BookToolStripMenuItem.Text = "File"
		'
		'ManagementToolStripMenuItem
		'
		Me.ManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportBookToolStripMenuItem})
		Me.ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem"
		Me.ManagementToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
		Me.ManagementToolStripMenuItem.Text = "Management"
		'
		'ImportBookToolStripMenuItem
		'
		Me.ImportBookToolStripMenuItem.Name = "ImportBookToolStripMenuItem"
		Me.ImportBookToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
		Me.ImportBookToolStripMenuItem.Text = "Import Book"
		'
		'BookToolStripMenuItem1
		'
		Me.BookToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem})
		Me.BookToolStripMenuItem1.Name = "BookToolStripMenuItem1"
		Me.BookToolStripMenuItem1.Size = New System.Drawing.Size(46, 20)
		Me.BookToolStripMenuItem1.Text = "Book"
		'
		'AddToolStripMenuItem
		'
		Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
		Me.AddToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
		Me.AddToolStripMenuItem.Text = "Add"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.MenuStrip1)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "frmMain"
		Me.Text = "frmMain"
		Me.TransparencyKey = System.Drawing.Color.Empty
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents BookToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ManagementToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ImportBookToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BookToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegulation
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
		Me.lblMinImportAmount = New MetroFramework.Controls.MetroLabel()
		Me.txtMinImportAmount = New MetroFramework.Controls.MetroTextBox()
		Me.txtMaxStockBeforeImport = New MetroFramework.Controls.MetroTextBox()
		Me.lblMaxStockBeforeImport = New MetroFramework.Controls.MetroLabel()
		Me.txtMaxDebt = New MetroFramework.Controls.MetroTextBox()
		Me.lblMaxDebt = New MetroFramework.Controls.MetroLabel()
		Me.txtMinStockAfterSales = New MetroFramework.Controls.MetroTextBox()
		Me.lblMinStockAfterSales = New MetroFramework.Controls.MetroLabel()
		Me.ckbUseRegulation = New MetroFramework.Controls.MetroCheckBox()
		Me.btnApply = New MetroFramework.Controls.MetroButton()
		Me.btnSave = New MetroFramework.Controls.MetroButton()
		Me.SuspendLayout()
		'
		'lblMinImportAmount
		'
		Me.lblMinImportAmount.AutoSize = True
		Me.lblMinImportAmount.Location = New System.Drawing.Point(91, 115)
		Me.lblMinImportAmount.Name = "lblMinImportAmount"
		Me.lblMinImportAmount.Size = New System.Drawing.Size(161, 19)
		Me.lblMinImportAmount.TabIndex = 0
		Me.lblMinImportAmount.Text = "Minimum Import Amount"
		'
		'txtMinImportAmount
		'
		'
		'
		'
		Me.txtMinImportAmount.CustomButton.Image = Nothing
		Me.txtMinImportAmount.CustomButton.Location = New System.Drawing.Point(28, 1)
		Me.txtMinImportAmount.CustomButton.Name = ""
		Me.txtMinImportAmount.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtMinImportAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMinImportAmount.CustomButton.TabIndex = 1
		Me.txtMinImportAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMinImportAmount.CustomButton.UseSelectable = True
		Me.txtMinImportAmount.CustomButton.Visible = False
		Me.txtMinImportAmount.Lines = New String(-1) {}
		Me.txtMinImportAmount.Location = New System.Drawing.Point(258, 115)
		Me.txtMinImportAmount.MaxLength = 32767
		Me.txtMinImportAmount.Name = "txtMinImportAmount"
		Me.txtMinImportAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMinImportAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMinImportAmount.SelectedText = ""
		Me.txtMinImportAmount.SelectionLength = 0
		Me.txtMinImportAmount.SelectionStart = 0
		Me.txtMinImportAmount.ShortcutsEnabled = True
		Me.txtMinImportAmount.Size = New System.Drawing.Size(50, 23)
		Me.txtMinImportAmount.TabIndex = 1
		Me.txtMinImportAmount.UseSelectable = True
		Me.txtMinImportAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMinImportAmount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'txtMaxStockBeforeImport
		'
		'
		'
		'
		Me.txtMaxStockBeforeImport.CustomButton.Image = Nothing
		Me.txtMaxStockBeforeImport.CustomButton.Location = New System.Drawing.Point(28, 1)
		Me.txtMaxStockBeforeImport.CustomButton.Name = ""
		Me.txtMaxStockBeforeImport.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtMaxStockBeforeImport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaxStockBeforeImport.CustomButton.TabIndex = 1
		Me.txtMaxStockBeforeImport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaxStockBeforeImport.CustomButton.UseSelectable = True
		Me.txtMaxStockBeforeImport.CustomButton.Visible = False
		Me.txtMaxStockBeforeImport.Lines = New String(-1) {}
		Me.txtMaxStockBeforeImport.Location = New System.Drawing.Point(258, 153)
		Me.txtMaxStockBeforeImport.MaxLength = 32767
		Me.txtMaxStockBeforeImport.Name = "txtMaxStockBeforeImport"
		Me.txtMaxStockBeforeImport.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaxStockBeforeImport.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaxStockBeforeImport.SelectedText = ""
		Me.txtMaxStockBeforeImport.SelectionLength = 0
		Me.txtMaxStockBeforeImport.SelectionStart = 0
		Me.txtMaxStockBeforeImport.ShortcutsEnabled = True
		Me.txtMaxStockBeforeImport.Size = New System.Drawing.Size(50, 23)
		Me.txtMaxStockBeforeImport.TabIndex = 3
		Me.txtMaxStockBeforeImport.UseSelectable = True
		Me.txtMaxStockBeforeImport.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMaxStockBeforeImport.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'lblMaxStockBeforeImport
		'
		Me.lblMaxStockBeforeImport.AutoSize = True
		Me.lblMaxStockBeforeImport.Location = New System.Drawing.Point(61, 153)
		Me.lblMaxStockBeforeImport.Name = "lblMaxStockBeforeImport"
		Me.lblMaxStockBeforeImport.Size = New System.Drawing.Size(191, 19)
		Me.lblMaxStockBeforeImport.TabIndex = 2
		Me.lblMaxStockBeforeImport.Text = "Maximum Stock Before Import"
		'
		'txtMaxDebt
		'
		'
		'
		'
		Me.txtMaxDebt.CustomButton.Image = Nothing
		Me.txtMaxDebt.CustomButton.Location = New System.Drawing.Point(28, 1)
		Me.txtMaxDebt.CustomButton.Name = ""
		Me.txtMaxDebt.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtMaxDebt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMaxDebt.CustomButton.TabIndex = 1
		Me.txtMaxDebt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMaxDebt.CustomButton.UseSelectable = True
		Me.txtMaxDebt.CustomButton.Visible = False
		Me.txtMaxDebt.Lines = New String(-1) {}
		Me.txtMaxDebt.Location = New System.Drawing.Point(258, 192)
		Me.txtMaxDebt.MaxLength = 32767
		Me.txtMaxDebt.Name = "txtMaxDebt"
		Me.txtMaxDebt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMaxDebt.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMaxDebt.SelectedText = ""
		Me.txtMaxDebt.SelectionLength = 0
		Me.txtMaxDebt.SelectionStart = 0
		Me.txtMaxDebt.ShortcutsEnabled = True
		Me.txtMaxDebt.Size = New System.Drawing.Size(50, 23)
		Me.txtMaxDebt.TabIndex = 5
		Me.txtMaxDebt.UseSelectable = True
		Me.txtMaxDebt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMaxDebt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'lblMaxDebt
		'
		Me.lblMaxDebt.AutoSize = True
		Me.lblMaxDebt.Location = New System.Drawing.Point(186, 196)
		Me.lblMaxDebt.Name = "lblMaxDebt"
		Me.lblMaxDebt.Size = New System.Drawing.Size(66, 19)
		Me.lblMaxDebt.TabIndex = 4
		Me.lblMaxDebt.Text = "Max Debt"
		'
		'txtMinStockAfterSales
		'
		'
		'
		'
		Me.txtMinStockAfterSales.CustomButton.Image = Nothing
		Me.txtMinStockAfterSales.CustomButton.Location = New System.Drawing.Point(28, 1)
		Me.txtMinStockAfterSales.CustomButton.Name = ""
		Me.txtMinStockAfterSales.CustomButton.Size = New System.Drawing.Size(21, 21)
		Me.txtMinStockAfterSales.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
		Me.txtMinStockAfterSales.CustomButton.TabIndex = 1
		Me.txtMinStockAfterSales.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
		Me.txtMinStockAfterSales.CustomButton.UseSelectable = True
		Me.txtMinStockAfterSales.CustomButton.Visible = False
		Me.txtMinStockAfterSales.Lines = New String(-1) {}
		Me.txtMinStockAfterSales.Location = New System.Drawing.Point(258, 232)
		Me.txtMinStockAfterSales.MaxLength = 32767
		Me.txtMinStockAfterSales.Name = "txtMinStockAfterSales"
		Me.txtMinStockAfterSales.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtMinStockAfterSales.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMinStockAfterSales.SelectedText = ""
		Me.txtMinStockAfterSales.SelectionLength = 0
		Me.txtMinStockAfterSales.SelectionStart = 0
		Me.txtMinStockAfterSales.ShortcutsEnabled = True
		Me.txtMinStockAfterSales.Size = New System.Drawing.Size(50, 23)
		Me.txtMinStockAfterSales.TabIndex = 7
		Me.txtMinStockAfterSales.UseSelectable = True
		Me.txtMinStockAfterSales.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
		Me.txtMinStockAfterSales.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
		'
		'lblMinStockAfterSales
		'
		Me.lblMinStockAfterSales.AutoSize = True
		Me.lblMinStockAfterSales.Location = New System.Drawing.Point(86, 236)
		Me.lblMinStockAfterSales.Name = "lblMinStockAfterSales"
		Me.lblMinStockAfterSales.Size = New System.Drawing.Size(166, 19)
		Me.lblMinStockAfterSales.TabIndex = 6
		Me.lblMinStockAfterSales.Text = "Minimum Stock After Sales"
		'
		'ckbUseRegulation
		'
		Me.ckbUseRegulation.AutoSize = True
		Me.ckbUseRegulation.FontSize = MetroFramework.MetroCheckBoxSize.Medium
		Me.ckbUseRegulation.Location = New System.Drawing.Point(23, 76)
		Me.ckbUseRegulation.Name = "ckbUseRegulation"
		Me.ckbUseRegulation.Size = New System.Drawing.Size(117, 19)
		Me.ckbUseRegulation.TabIndex = 9
		Me.ckbUseRegulation.Text = "Use Regulation"
		Me.ckbUseRegulation.UseSelectable = True
		'
		'btnApply
		'
		Me.btnApply.Location = New System.Drawing.Point(237, 282)
		Me.btnApply.Name = "btnApply"
		Me.btnApply.Size = New System.Drawing.Size(75, 23)
		Me.btnApply.TabIndex = 10
		Me.btnApply.Text = "Apply"
		Me.btnApply.UseSelectable = True
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(104, 282)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(75, 23)
		Me.btnSave.TabIndex = 11
		Me.btnSave.Text = "Save"
		Me.btnSave.UseSelectable = True
		'
		'frmRegulation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(416, 333)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnApply)
		Me.Controls.Add(Me.ckbUseRegulation)
		Me.Controls.Add(Me.txtMinStockAfterSales)
		Me.Controls.Add(Me.lblMinStockAfterSales)
		Me.Controls.Add(Me.txtMaxDebt)
		Me.Controls.Add(Me.lblMaxDebt)
		Me.Controls.Add(Me.txtMaxStockBeforeImport)
		Me.Controls.Add(Me.lblMaxStockBeforeImport)
		Me.Controls.Add(Me.txtMinImportAmount)
		Me.Controls.Add(Me.lblMinImportAmount)
		Me.Name = "frmRegulation"
		Me.Text = "Regulation"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblMinImportAmount As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMinImportAmount As MetroFramework.Controls.MetroTextBox
	Friend WithEvents txtMaxStockBeforeImport As MetroFramework.Controls.MetroTextBox
	Friend WithEvents lblMaxStockBeforeImport As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMaxDebt As MetroFramework.Controls.MetroTextBox
	Friend WithEvents lblMaxDebt As MetroFramework.Controls.MetroLabel
	Friend WithEvents txtMinStockAfterSales As MetroFramework.Controls.MetroTextBox
	Friend WithEvents lblMinStockAfterSales As MetroFramework.Controls.MetroLabel
	Friend WithEvents ckbUseRegulation As MetroFramework.Controls.MetroCheckBox
	Friend WithEvents btnApply As MetroFramework.Controls.MetroButton
	Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
End Class

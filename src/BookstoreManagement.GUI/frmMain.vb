Public Class frmMain
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Private Sub ImportBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportBookToolStripMenuItem.Click
		Dim frm As frmImport = New frmImport()
		frm.MdiParent = Me
		frm.Show()
	End Sub
End Class
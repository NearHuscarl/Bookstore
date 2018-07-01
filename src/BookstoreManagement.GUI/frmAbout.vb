Imports System.Reflection
Imports MetroFramework
Imports MetroFramework.Drawing

Public Class frmAbout
	Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim version = Assembly.GetExecutingAssembly().GetName().Version

		lblVersion.Text = $"{version.Major}.{version.Minor}.{version.Build}"
	End Sub

	Private Sub lkSourceCode_Click(sender As Object, e As EventArgs) Handles lkSourceCode.Click
		Process.Start("https://github.com/NearHuscarl/BookstoreManagement")
	End Sub
End Class
Imports System.Drawing.Text
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports MetroFramework
Imports MetroFramework.Drawing

Public Class frmMain
	Private privilege As Integer

	Public Sub New(privilege As Integer)
		Me.privilege = privilege

		InitializeComponent()

		tlImport.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Red)
		tlInvoice.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Yellow)
		tlSearch.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Green)
		tlReceipt.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Orange)
		tlStockReport.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Lime)
		tlDebtReport.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Teal)
		tlRegulation.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Silver)
	End Sub

	Private Sub tlImport_Click(sender As Object, e As EventArgs) Handles tlImport.Click
		If (privilege <= 2) Then
			Dim frm As frmImport = New frmImport()
			'frm.MdiParent = Me
			frm.ShowDialog()
		Else
			MetroMessageBox.Show(Me, "You do not have enough permission", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub tlInvoice_Click(sender As Object, e As EventArgs) Handles tlInvoice.Click
		If (privilege <= 2) Then
			Dim frm As frmInvoice = New frmInvoice()
			frm.ShowDialog()
		Else
			MetroMessageBox.Show(Me, "You do not have enough permission", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub tlSearch_Click(sender As Object, e As EventArgs) Handles tlSearch.Click
		Dim frm As frmSearch = New frmSearch()
		frm.ShowDialog()
	End Sub

	Private Sub tlReceipt_Click(sender As Object, e As EventArgs) Handles tlReceipt.Click
		If (privilege <= 2) Then
			Dim frm As frmReceipt = New frmReceipt()
			frm.ShowDialog()
		Else
			MetroMessageBox.Show(Me, "You do not have enough permission", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub

	Private Sub lkAbout_Click(sender As Object, e As EventArgs) Handles lkAbout.Click
		Dim frm As frmAbout = New frmAbout()
		frm.ShowDialog()
	End Sub

	Private Sub tlRegulation_Click(sender As Object, e As EventArgs) Handles tlRegulation.Click
		If (privilege = 1) Then
			Dim frm As frmRegulation = New frmRegulation()
			frm.ShowDialog()
		Else
			MetroMessageBox.Show(Me, "You do not have enough permission", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If
	End Sub
End Class

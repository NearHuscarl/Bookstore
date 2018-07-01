Imports System.Drawing.Text
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports MetroFramework
Imports MetroFramework.Drawing

Public Class frmMain
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		tlImport.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Red)
		tlInvoice.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Yellow)
		tlSearch.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Green)
		tlReceipt.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Orange)
		tlStockReport.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Lime)
		tlDebtReport.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Teal)
		tlRegulation.BackColor = MetroPaint.GetStyleColor(MetroColorStyle.Silver)
	End Sub

	Private Sub tlImport_Click(sender As Object, e As EventArgs) Handles tlImport.Click
		Dim frm As frmImport = New frmImport()
		'frm.MdiParent = Me
		frm.ShowDialog()
	End Sub

	Private Sub tlInvoice_Click(sender As Object, e As EventArgs) Handles tlInvoice.Click
		Dim frm As frmInvoice = New frmInvoice()
		frm.ShowDialog()
	End Sub

	Private Sub tlSearch_Click(sender As Object, e As EventArgs) Handles tlSearch.Click
		Dim frm As frmSearch = New frmSearch()
		frm.ShowDialog()
	End Sub

	Private Sub tlReceipt_Click(sender As Object, e As EventArgs) Handles tlReceipt.Click
		Dim frm As frmReceipt = New frmReceipt()
		frm.ShowDialog()
	End Sub

	Private Sub lkAbout_Click(sender As Object, e As EventArgs) Handles lkAbout.Click
		Dim frm As frmAbout = New frmAbout()
		frm.ShowDialog()
	End Sub

	Private Sub tlRegulation_Click(sender As Object, e As EventArgs) Handles tlRegulation.Click
		Dim frm As frmRegulation = New frmRegulation()
		frm.ShowDialog()
	End Sub
End Class

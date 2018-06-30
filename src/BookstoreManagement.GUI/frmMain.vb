Imports MetroFramework.Drawing

Public Class frmMain
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		tlImport.BackColor = MetroPaint.GetStyleColor(MetroFramework.MetroColorStyle.Red)
		tlInvoice.BackColor = MetroPaint.GetStyleColor(MetroFramework.MetroColorStyle.Yellow)
		tlSearch.BackColor = MetroPaint.GetStyleColor(MetroFramework.MetroColorStyle.Green)
		tlReceipt.BackColor = MetroPaint.GetStyleColor(MetroFramework.MetroColorStyle.Orange)
		tlStockReport.BackColor = MetroPaint.GetStyleColor(MetroFramework.MetroColorStyle.Lime)
		tlDebtReport.BackColor = MetroPaint.GetStyleColor(MetroFramework.MetroColorStyle.Teal)
		tlRegulation.BackColor = MetroPaint.GetStyleColor(MetroFramework.MetroColorStyle.Silver)
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
End Class
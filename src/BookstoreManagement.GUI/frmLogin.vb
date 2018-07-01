Imports System.Drawing.Drawing2D
Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports MetroFramework.Controls

Public Class frmLogin
	Dim accountBUS As AccountBUS
	Dim optionBUS As OptionBUS

	Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		accountBUS = New AccountBUS()
		optionBUS = New OptionBUS()

		Dim _option = LoadOption()

		If (_option Is Nothing) Then
			Return
		End If

		ckbRememberMe.Checked = _option.RememberMe

		If (_option.RememberMe And _option.RememberedAccount IsNot Nothing) Then
			Dim account As AccountDTO
			Dim result = accountBUS.select_byID(_option.RememberedAccount, account)

			If (result.FlagResult = True) Then
				txtUsername.Text = account.Name
				txtPassword.Text = account.Password
			Else
				MetroMessageBox.Show(Me, "Cannot get account info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Console.WriteLine(result.SystemMessage)
			End If
		End If
		'pnlLogin.BackColor = Color.Blue
		'pbUsername.BackColor = Color.Red
	End Sub

	Private Function LoadOption() As OptionDTO
		Dim _option As OptionDTO
		Dim result = optionBUS.selectAll(_option)

		If (result.FlagResult = False) Then
			MetroMessageBox.Show(Me, "Cannot load login option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
			Return Nothing
		End If

		Return _option
	End Function

	Private Function LoadAccount(username As String) As AccountDTO
		Dim account As AccountDTO
		Dim result = accountBUS.select_byName(username, account)

		If (result.FlagResult = False) Then
			MetroMessageBox.Show(Me, "Cannot get account info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
			Return Nothing
		End If

		Return account
	End Function

	Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
		'MyBase.OnPaintBackground(e)
		'BackColor = Color.Red
		Dim gradientBrush As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, Color.Red, Color.Black, 0, False)
		'Me.BackColor =
		e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
	End Sub

	Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		Dim account As AccountDTO
		Dim result = accountBUS.select_byName(txtUsername.Text, account)

		If (result.FlagResult = False) Then
			MetroMessageBox.Show(Me, "Username not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If

		If (txtPassword.Text = account.Password) Then
			UpdateOption(account)
			LoginSuccess()
		Else
			MetroMessageBox.Show(Me, "Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End If
	End Sub

	Private Sub UpdateOption(account As AccountDTO)
		Dim _option = LoadOption()

		_option.RememberMe = ckbRememberMe.Checked
		_option.RememberedAccount = account.ID

		Dim result = optionBUS.update(_option)

		If (result.FlagResult = False) Then
			MetroMessageBox.Show(Me, "Cannot update login info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Console.WriteLine(result.SystemMessage)
		End If
	End Sub

	Private Sub LoginSuccess()
		Dim frm As frmMain = New frmMain()

		frm.Show()
		Close()
	End Sub
End Class
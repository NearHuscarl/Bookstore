Imports BookstoreManagement.BUS
Imports BookstoreManagement.DTO
Imports MetroFramework
Imports Utility


Public Class frmCustomerEdit

	Private customerBUS As CustomerBUS
	Private isModified As Boolean

	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub
	Public Sub New(customer As CustomerDTO, isModified As Boolean)
		InitializeComponent()
		customerBUS = New CustomerBUS()
		Me.isModified = isModified
		Try
			If (isModified) Then
				txtID.Text = customer.ID
				txtName.Text = customer.Name
				txtAddress.Text = customer.Address
				txtEmail.Text = customer.Email
				txtPhone.Text = customer.PhoneNumber
				txtDebt.Text = customer.CurrentDebt
			Else
				Dim result As Result
				result = customerBUS.getNextId(customer.ID)

				txtID.Text = customer.ID
				txtName.Text = String.Empty
				txtAddress.Text = String.Empty
				txtEmail.Text = String.Empty
				txtPhone.Text = String.Empty
				txtDebt.Text = 0
			End If
		Catch ex As Exception
			Debug.WriteLine(ex.StackTrace)
		End Try
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Dispose()
	End Sub

	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		Dim newCustomer = New CustomerDTO
		Try
			newCustomer.ID = txtID.Text
			newCustomer.Name = txtName.Text
			newCustomer.Address = txtAddress.Text
			newCustomer.PhoneNumber = txtPhone.Text
			newCustomer.Email = txtEmail.Text
			newCustomer.CurrentDebt = txtDebt.Text
			Dim result As Result
			If (isModified) Then
				result = customerBUS.update(newCustomer)
			Else
				result = customerBUS.insert(newCustomer)
			End If
		Catch ex As Exception
			Debug.WriteLine(ex.StackTrace)
		Finally
			Me.Dispose()
		End Try
	End Sub

End Class
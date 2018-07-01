Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class AccountBUS
	Private accountDAL As AccountDAL

	Public Sub New()
		accountDAL = New AccountDAL()
	End Sub

	Public Sub New(connectionStr As String)
		accountDAL = New AccountDAL(connectionStr)
	End Sub

	Private Function IsValidToUpdate(account As AccountDTO) As Result
		If (String.IsNullOrEmpty(account.Name)) Then
			Return New Result(False, "Account name is missing", "")
		End If

		If (String.IsNullOrEmpty(account.Password)) Then
			Return New Result(False, "Account password is missing", "")
		End If

		If (account.Privilege < 0 Or account.Privilege > 5) Then
			Return New Result(False, "Account privilege is out of range", "")
		End If

		Return New Result(True)
	End Function

	Public Function select_byID(ID As String, ByRef account As AccountDTO) As Result
		' Validate here
		Return accountDAL.select_byID(ID, account)
	End Function

	Public Function select_byName(username As String, ByRef account As AccountDTO) As Result
		' Validate here
		Return accountDAL.select_byName(username, account)
	End Function

	Public Function update(account As AccountDTO) As Result
		Dim result = IsValidToUpdate(account)

		If (result.FlagResult = True) Then
			Return accountDAL.update(account)
		End If

		Return result
	End Function
End Class

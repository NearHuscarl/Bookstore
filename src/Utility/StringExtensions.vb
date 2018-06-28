Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

Public Module StringExtensions
	<Extension()>
	Public Sub IncrementID(ByRef this As String, IdPrefix As String, Optional format As String = "D4")

		Dim IdNumber As Integer

		If IsNothing(this) Then
			IdNumber = 1
		Else
			IdNumber = CInt(Regex.Replace(this, "[^\d]", ""))
			IdNumber += 1
		End If

		this = IdPrefix + IdNumber.ToString(format)
	End Sub
End Module
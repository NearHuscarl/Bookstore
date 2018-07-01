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

	<Extension()>
	Public Function ToNormal(ByRef this As String) As String
		Return this.Trim().ToLowerInvariant()
	End Function

	<Extension()>
	Public Function Contains(ByRef this As String, strToCheck As String, Optional stringComparison As StringComparison = StringComparison.Ordinal) As Boolean
		If (this IsNot Nothing) Then
			Return this.IndexOf(strToCheck, stringComparison) >= 0
		End If
		Return False
   End Function
End Module
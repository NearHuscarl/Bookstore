Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

Public Module ListExtension
	<Extension()>
	Public Sub AddOrReplace(Of T)(ByRef list As List(Of T), item As T, Optional comparer As IComparer(Of T) = Nothing)
		Dim duplicatedItems As IEnumerable(Of T)

		If (comparer Is Nothing) Then
			duplicatedItems = list.Where(Function(i) i.Equals(item))
		Else
			duplicatedItems = list.Where(Function(i) comparer.Compare(i, item) = 0)
		End If

		If (duplicatedItems.Count = 0) Then
			list.Add(item)
		Else
			Dim oldIndex = list.IndexOf(duplicatedItems.First())
			list(oldIndex) = item
		End If
	End Sub

	<Extension()>
	Public Sub AddIfNotExist(Of T)(ByRef list As List(Of T), item As T, Optional comparer As IComparer(Of T) = Nothing)
		Dim duplicatedItems As IEnumerable(Of T)

		If (comparer Is Nothing) Then
			duplicatedItems = list.Where(Function(i) i.Equals(item))
		Else
			duplicatedItems = list.Where(Function(i) comparer.Compare(i, item) = 0)
		End If

		If (duplicatedItems.Count = 0) Then
			list.Add(item)
		End If
	End Sub
End Module

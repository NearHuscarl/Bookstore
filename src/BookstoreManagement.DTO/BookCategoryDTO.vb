Public Class BookCategoryDTO
	Private _ID As String
	Private _name As String

	Public Sub New()
	End Sub

	Public Sub New(ID As String, name As String)
		Me._ID = ID
		Me._name = name
	End Sub

	Property ID() As String
		Get
			Return _ID
		End Get
		Set(ByVal Value As String)
			_ID = Value
		End Set
	End Property

	Property Name() As String
		Get
			Return _name
		End Get
		Set(ByVal Value As String)
			_name = Value
		End Set
	End Property
End Class

Public Class AccountDTO
	Private _ID As String
	Private _name As String
	Private _password As String
	Private _privilege As Integer

	Public Sub New()
	End Sub

	Public Sub New(ID As String, name As String, password As String, privilege As Integer)
		Me._ID = ID
		Me._name = name
		Me._password = password
		Me._privilege = privilege
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

	Property Password() As String
		Get
			Return _password
		End Get
		Set(ByVal Value As String)
			_password = Value
		End Set
	End Property

	Property Privilege() As Integer
		Get
			Return _privilege
		End Get
		Set(ByVal Value As Integer)
			_privilege = Value
		End Set
	End Property
End Class

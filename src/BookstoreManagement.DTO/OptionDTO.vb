Public Class OptionDTO
	Private _rememberMe As Boolean
	Private _rememberedAccount As String

	Public Sub New()
	End Sub

	Public Sub New(rememberMe As Boolean, rememberedAccount As String)
		Me._rememberMe = rememberMe
		Me._rememberedAccount = rememberedAccount
	End Sub

	Property RememberMe() As Boolean
		Get
			Return _rememberMe
		End Get
		Set(ByVal Value As Boolean)
			_rememberMe = Value
		End Set
	End Property

	''' <summary>
	''' Last account ID to login
	''' </summary>
	''' <returns></returns>
	Property RememberedAccount() As String
		Get
			Return _rememberedAccount
		End Get
		Set(ByVal Value As String)
			_rememberedAccount = Value
		End Set
	End Property
End Class

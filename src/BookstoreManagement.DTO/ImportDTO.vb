Public Class ImportDTO
	Private _ID As String
	Private _dateImport As DateTime

	Public Sub New()
	End Sub

	Public Sub New(ID As String, dateImport As DateTime)
		Me._ID = ID
		Me._dateImport = dateImport
	End Sub

	Property ID() As String
		Get
			Return _ID
		End Get
		Set(ByVal Value As String)
			_ID = Value
		End Set
	End Property

	Property DateImport() As DateTime
		Get
			Return _dateImport
		End Get
		Set(ByVal Value As DateTime)
			_dateImport = Value
		End Set
	End Property
End Class

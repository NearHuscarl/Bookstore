Public Class ImportDetailDTO
	Private _ID As String
	Private _importID As String
	Private _bookID As String
	Private _importAmount As Integer
	Private _currentAmount As Integer
	Private _importPrice As Integer

	Public Sub New()
	End Sub

	Public Sub New(
		ID As String,
		importID As String,
		bookID As String,
		importAmount As Integer,
		currentAmount As Integer,
		importPrice As Integer
		)

		Me._ID = ID
		Me._importID = importID
		Me._bookID = bookID
		Me._importAmount = importAmount
		Me._currentAmount = currentAmount
		Me._importPrice = importPrice
	End Sub

	Property ID() As String
		Get
			Return _ID
		End Get
		Set(ByVal Value As String)
			_ID = Value
		End Set
	End Property

	Property ImportID() As String
		Get
			Return _importID
		End Get
		Set(ByVal Value As String)
			_importID = Value
		End Set
	End Property

	Property BookID() As String
		Get
			Return _bookID
		End Get
		Set(ByVal Value As String)
			_bookID = Value
		End Set
	End Property

	Property ImportAmount() As Integer
		Get
			Return _importAmount
		End Get
		Set(ByVal Value As Integer)
			_importAmount = Value
		End Set
	End Property

	Property CurrentAmount() As Integer
		Get
			Return _currentAmount
		End Get
		Set(ByVal Value As Integer)
			_currentAmount = Value
		End Set
	End Property

	Property ImportPrice() As Integer
		Get
			Return _importPrice
		End Get
		Set(ByVal Value As Integer)
			_importPrice = Value
		End Set
	End Property
End Class

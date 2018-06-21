Public Class StockReportDetailDTO
	Private _ID As String
	Private _stockReportID As String
	Private _bookID As String
	Private _openingStock As Integer
	Private _newStock As Integer
	Private _closingStock As Integer

	Public Sub New()
	End Sub

	Public Sub New(
		ID As String,
		stockReportID As String,
		bookID As String,
		openingStock As Integer,
		newStock As Integer,
		closingStock As Integer)

		Me._ID = ID
		Me._stockReportID = stockReportID
		Me._bookID = bookID
		Me._openingStock = openingStock
		Me._newStock = newStock
		Me._closingStock = closingStock
	End Sub

	Property ID() As String
		Get
			Return _ID
		End Get
		Set(ByVal Value As String)
			_ID = Value
		End Set
	End Property

	Property StockReportID() As String
		Get
			Return _stockReportID
		End Get
		Set(ByVal Value As String)
			_stockReportID = Value
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

	Property OpeningStock() As Integer
		Get
			Return _openingStock
		End Get
		Set(ByVal Value As Integer)
			_openingStock = Value
		End Set
	End Property

	Property NewStock() As Integer
		Get
			Return _newStock
		End Get
		Set(ByVal Value As Integer)
			_newStock = Value
		End Set
	End Property

	Property ClosingStock() As Integer
		Get
			Return _closingStock
		End Get
		Set(ByVal Value As Integer)
			_closingStock = Value
		End Set
	End Property
End Class

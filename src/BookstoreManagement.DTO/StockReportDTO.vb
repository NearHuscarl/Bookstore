Public Class StockReportDTO
	Private _ID As String
	Private _reportDate As DateTime

	Public Sub New()
	End Sub

	Public Sub New(ID As String, reportDate As DateTime)
		Me._ID = ID
		Me._reportDate = reportDate
	End Sub

	Property ID() As String
		Get
			Return _ID
		End Get
		Set(ByVal Value As String)
			_ID = Value
		End Set
	End Property

	Property ReportDate() As DateTime
		Get
			Return _reportDate
		End Get
		Set(ByVal Value As DateTime)
			_reportDate = Value
		End Set
	End Property
End Class

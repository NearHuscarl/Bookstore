Public Class StockReportDTO
	Private _ID As String
	Private _dateReport As DateTime

	Public Sub New()
	End Sub

	Public Sub New(ID As String, dateReport As DateTime)
		Me._ID = ID
		Me._dateReport = dateReport
	End Sub

	Property ID() As String
		Get
			Return _ID
		End Get
		Set(ByVal Value As String)
			_ID = Value
		End Set
	End Property

	Property DateReport() As DateTime
		Get
			Return _dateReport
		End Get
		Set(ByVal Value As DateTime)
			_dateReport = Value
		End Set
	End Property
End Class

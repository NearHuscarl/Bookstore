Public Class ReceiptDTO
	Private _ID As String
	Private _customerID As String
	Private _dateCollect As DateTime
	Private _collectedAmount As Integer

   Public Sub New()
   End Sub

	Public Sub New(
		  ID As String,
		  customerID As String,
		  dateCollect As DateTime,
		  collectedAmount As Integer)

		Me._ID = ID
		Me._customerID = customerID
		Me._dateCollect = dateCollect
		Me._collectedAmount = collectedAmount
	End Sub

	Property ID() As String
      Get
         Return _ID
      End Get
      Set(ByVal Value As String)
         _ID = Value
      End Set
   End Property

   Property CustomerID() As String
      Get
         Return _customerID
      End Get
      Set(ByVal Value As String)
         _customerID = Value
      End Set
   End Property

	Property DateCollect() As DateTime
		Get
			Return _dateCollect
		End Get
		Set(ByVal Value As DateTime)
			_dateCollect = Value
		End Set
	End Property

	Property CollectedAmount() As Integer
		Get
			Return _collectedAmount
		End Get
		Set(ByVal Value As Integer)
			_collectedAmount = Value
		End Set
	End Property
End Class

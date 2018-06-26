Public Class InvoiceDetailDTO
   Private _ID As String
   Private _invoiceID As String
   Private _bookID As String
	Private _amount As Integer
	Private _salesPrice As Integer

   Public Sub New()
   End Sub

	Public Sub New(
		  ID As String,
		  invoiceID As String,
		  bookID As String,
		  amount As Integer,
		  salesPrice As Integer)

		Me._ID = ID
		Me._invoiceID = invoiceID
		Me._bookID = bookID
		Me._amount = amount
		Me._salesPrice = salesPrice
	End Sub

	Property ID() As String
      Get
         Return _ID
      End Get
      Set(ByVal Value As String)
         _ID = Value
      End Set
   End Property

   Property InvoiceID() As String
      Get
         Return _invoiceID
      End Get
      Set(ByVal Value As String)
         _invoiceID = Value
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

	Property Amount() As Integer
		Get
			Return _amount
		End Get
		Set(ByVal Value As Integer)
			_amount = Value
		End Set
	End Property

	Property SalesPrice() As Integer
      Get
         Return _salesPrice
      End Get
      Set(ByVal Value As Integer)
         _salesPrice = Value
      End Set
   End Property
End Class

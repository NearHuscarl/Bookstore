Public Class InvoiceDTO
	Private _ID As String
	Private _customerID As String
	Private _invoiceDate As DateTime

	Public Sub New()
   End Sub

	Public Sub New(
		  ID As String,
		  customerID As String,
		  invoiceDate As DateTime)

		Me._ID = ID
		Me._customerID = customerID
		Me._invoiceDate = invoiceDate
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

	Property InvoiceDate() As DateTime
		Get
			Return _invoiceDate
		End Get
		Set(ByVal Value As DateTime)
			_invoiceDate = Value
		End Set
	End Property
End Class

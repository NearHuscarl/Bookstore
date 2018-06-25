Public Class BookDTO
	Private _ID As String
   Private _name As String
   Private _authorID As String
   Private _bookCategoryID As String
   Private _stock As Integer
   Private _price As Integer

   Public Sub New()
	End Sub

   Public Sub New(
        ID As String,
        name As String,
        authorID As String,
        bookCategoryID As String,
        stock As Integer,
        price As Integer
        )

      Me._ID = ID
      Me._name = name
      Me._authorID = authorID
      Me._bookCategoryID = bookCategoryID
      Me._stock = stock
      Me._price = price
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

   Property AuthorID() As String
      Get
         Return _authorID
      End Get
      Set(ByVal Value As String)
         _authorID = Value
      End Set
   End Property

   Property BookCategoryID() As String
      Get
         Return _bookCategoryID
      End Get
      Set(ByVal Value As String)
         _bookCategoryID = Value
      End Set
   End Property

   Property Stock() As Integer
      Get
         Return _stock
      End Get
      Set(ByVal Value As Integer)
         _stock = Value
      End Set
   End Property

   Property Price() As Integer
      Get
         Return _price
      End Get
      Set(ByVal Value As Integer)
         _price = Value
      End Set
   End Property
End Class

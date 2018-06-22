Public Class BookDTO
	Private _ID As String
	Private _name As String
	Private _category As BookCategoryDTO
	Private _author As AuthorDTO
   Private _importAmount As Integer

   Public Sub New()
	End Sub

	Public Sub New(
		ID As String,
		name As String,
		category As BookCategoryDTO,
		author As AuthorDTO,
		importAmount As Integer,
		importPrice As Integer
		)

		Me._ID = ID
		Me._name = name
		Me._category = category
		Me._author = author
      Me._importAmount = importAmount
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

	Property Category() As BookCategoryDTO
		Get
			Return _category
		End Get
		Set(ByVal Value As BookCategoryDTO)
			_category = Value
		End Set
	End Property

	Property Author() As AuthorDTO
		Get
			Return _author
		End Get
		Set(ByVal Value As AuthorDTO)
			_author = Value
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
End Class

Public Class ImportDTO
	Private _ID As String
   Private _importDate As DateTime

   Public Sub New()
	End Sub

   Public Sub New(ID As String, importDate As DateTime)
      Me._ID = ID
      Me._importDate = importDate
   End Sub

   Property ID() As String
		Get
			Return _ID
		End Get
		Set(ByVal Value As String)
			_ID = Value
		End Set
	End Property

   Property ImportDate() As DateTime
      Get
         Return _importDate
      End Get
      Set(ByVal Value As DateTime)
         _importDate = Value
      End Set
   End Property
End Class

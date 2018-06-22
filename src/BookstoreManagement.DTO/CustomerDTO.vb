Public Class CustomerDTO
	Private _ID As String
	Private _name As String
	Private _address As String
	Private _email As String
	Private _phoneNumber As Long
   Private _currentDebt As Integer

   Public Sub New()
   End Sub

   Public Sub New(
        ID As String,
        name As String,
        address As String,
        email As String,
        phoneNumber As Long,
        currentDebt As Integer
        )

      Me._ID = ID
      Me._name = name
      Me._address = address
      Me._email = email
      Me._phoneNumber = phoneNumber
      Me._currentDebt = currentDebt
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

   Property Address() As String
      Get
         Return _address
      End Get
      Set(ByVal Value As String)
         _address = Value
      End Set
   End Property

   Property Email() As String
      Get
         Return _email
      End Get
      Set(ByVal Value As String)
         _email = Value
      End Set
   End Property

   Property PhoneNumber() As Long
      Get
         Return _phoneNumber
      End Get
      Set(ByVal Value As Long)
         _phoneNumber = Value
      End Set
   End Property

   Property CurrentDebt() As Integer
      Get
         Return _currentDebt
      End Get
      Set(ByVal Value As Integer)
         _currentDebt = Value
      End Set
	End Property
End Class

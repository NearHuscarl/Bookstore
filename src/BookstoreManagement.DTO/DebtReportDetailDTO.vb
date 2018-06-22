Public Class DebtReportDetailDTO
   Private _ID As String
   Private _debtReportID As String
   Private _customerID As String
   Private _openingDebt As Integer
   Private _newDebt As Integer
   Private _closingDebt As Integer

   Public Sub New()
   End Sub

   Public Sub New(
        ID As String,
        debtReportID As String,
        customerID As String,
        openingDebt As Integer,
        newDebt As Integer,
        closingDebt As Integer)

      Me._ID = ID
      Me._debtReportID = debtReportID
      Me._customerID = customerID
      Me._openingDebt = openingDebt
      Me._newDebt = newDebt
      Me._closingDebt = closingDebt
   End Sub

   Property ID() As String
      Get
         Return _ID
      End Get
      Set(ByVal Value As String)
         _ID = Value
      End Set
   End Property

   Property DebtReportID() As String
      Get
         Return _debtReportID
      End Get
      Set(ByVal Value As String)
         _debtReportID = Value
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

   Property OpeningDebt() As Integer
      Get
         Return _openingDebt
      End Get
      Set(ByVal Value As Integer)
         _openingDebt = Value
      End Set
   End Property

   Property NewDebt() As Integer
      Get
         Return _newDebt
      End Get
      Set(ByVal Value As Integer)
         _newDebt = Value
      End Set
   End Property

   Property ClosingDebt() As Integer
      Get
         Return _closingDebt
      End Get
      Set(ByVal Value As Integer)
         _closingDebt = Value
      End Set
   End Property
End Class

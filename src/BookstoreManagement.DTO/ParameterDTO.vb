Public Class ParameterDTO
	Private _minImportAmount As Integer
	Private _minStockBeforeImport As Integer
	Private _minStockAfterSales As Integer
   Private _maxDebt As Integer
   Private _useRegulation As Boolean

   Public Sub New()
   End Sub

   Public Sub New(
        minImportAmount As Integer,
        minStockBeforeImport As Integer,
        minStockAfterSales As Integer,
        maxDebt As Integer,
        useRegulation As Boolean
        )

      Me._minImportAmount = minImportAmount
      Me._minStockBeforeImport = minStockBeforeImport
      Me._minStockAfterSales = minStockAfterSales
      Me._maxDebt = maxDebt
      Me._useRegulation = useRegulation
   End Sub

   Property MinImportAmount() As Integer
      Get
         Return _minImportAmount
      End Get
      Set(ByVal Value As Integer)
         _minImportAmount = Value
      End Set
   End Property

   Property MinStockBeforeImport() As Integer
      Get
         Return _minStockBeforeImport
      End Get
      Set(ByVal Value As Integer)
         _minStockBeforeImport = Value
      End Set
   End Property

   Property MinStockAfterSales() As Integer
      Get
         Return _minStockAfterSales
      End Get
      Set(ByVal Value As Integer)
         _minStockAfterSales = Value
      End Set
   End Property

   Property MaxDebt() As Integer
      Get
         Return _maxDebt
      End Get
      Set(ByVal Value As Integer)
         _maxDebt = Value
      End Set
	End Property

	Property UseRegulation() As Boolean
		Get
			Return _useRegulation
		End Get
		Set(ByVal Value As Boolean)
			_useRegulation = Value
		End Set
	End Property
End Class

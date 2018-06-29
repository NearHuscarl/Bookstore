Public Class ParameterDTO
	Private _minImportAmount As Integer
	Private _maxStockBeforeImport As Integer
	Private _maxDebt As Integer
	Private _minStockAfterSales As Integer
	Private _useRegulation As Boolean

	Public Sub New()
	End Sub

	Public Sub New(
		  minImportAmount As Integer,
		  maxStockBeforeImport As Integer,
		  maxDebt As Integer,
		  MinStockAfterSales As Integer,
		  UseRegulation As Boolean
		  )

		Me._minImportAmount = minImportAmount
		Me._maxStockBeforeImport = maxStockBeforeImport
		Me._maxDebt = maxDebt
		Me._minStockAfterSales = MinStockAfterSales
		Me._useRegulation = UseRegulation
	End Sub

	Property MinImportAmount() As Integer
		Get
			Return _minImportAmount
		End Get
		Set(ByVal Value As Integer)
			_minImportAmount = Value
		End Set
	End Property

	Property MaxStockBeforeImport() As Integer
		Get
			Return _maxStockBeforeImport
		End Get
		Set(ByVal Value As Integer)
			_maxStockBeforeImport = Value
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

	Property MinStockAfterSales() As Integer
		Get
			Return _minStockAfterSales
		End Get
		Set(ByVal Value As Integer)
			_minStockAfterSales = Value
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

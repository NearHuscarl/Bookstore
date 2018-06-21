Public Class DeptReportDetail
	Private _ID As String
	Private _deptReportID As String
	Private _customerID As String
	Private _openingDept As Integer
	Private _newDept As Integer
	Private _closingDept As Integer

	Public Sub New()
	End Sub

	Public Sub New(
		ID As String,
		deptReportID As String,
		customerID As String,
		openingDept As Integer,
		newDept As Integer,
		closingDept As Integer)

		Me._ID = ID
		Me._deptReportID = deptReportID
		Me._customerID = customerID
		Me._openingDept = openingDept
		Me._newDept = newDept
		Me._closingDept = closingDept
	End Sub

	Property ID() As String
		Get
			Return _ID
		End Get
		Set(ByVal Value As String)
			_ID = Value
		End Set
	End Property

	Property DeptReportID() As String
		Get
			Return _deptReportID
		End Get
		Set(ByVal Value As String)
			_deptReportID = Value
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

	Property OpeningDept() As Integer
		Get
			Return _openingDept
		End Get
		Set(ByVal Value As Integer)
			_openingDept = Value
		End Set
	End Property

	Property NewDept() As Integer
		Get
			Return _newDept
		End Get
		Set(ByVal Value As Integer)
			_newDept = Value
		End Set
	End Property

	Property ClosingDept() As Integer
		Get
			Return _closingDept
		End Get
		Set(ByVal Value As Integer)
			_closingDept = Value
		End Set
	End Property
End Class

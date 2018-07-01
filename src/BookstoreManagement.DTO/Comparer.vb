Imports BookstoreManagement.DTO

Public Class BookComparer
	Implements IComparer(Of BookDTO)

	Public Function Compare(x As BookDTO, y As BookDTO) As Integer Implements IComparer(Of BookDTO).Compare
		If (x.ID = y.ID) Then
			Return 0
		End If

		Return -1
	End Function

	Public Shared ReadOnly Property Instance() As BookComparer
		Get
			Return New BookComparer()
		End Get
	End Property
End Class

Public Class CustomerComparer
	Implements IComparer(Of CustomerDTO)

	Public Function Compare(x As CustomerDTO, y As CustomerDTO) As Integer Implements IComparer(Of CustomerDTO).Compare
		If (x.ID = y.ID) Then
			Return 0
		End If

		Return -1
	End Function

	Public Shared ReadOnly Property Instance() As CustomerComparer
		Get
			Return New CustomerComparer()
		End Get
	End Property
End Class

Public Class ImportDetailComparer
	Implements IComparer(Of ImportDetailDTO)

	Public Function Compare(x As ImportDetailDTO, y As ImportDetailDTO) As Integer Implements IComparer(Of ImportDetailDTO).Compare
		If (x.ID = y.ID) Then
			Return 0
		End If

		Return -1
	End Function

	Public Shared ReadOnly Property Instance() As ImportDetailComparer
		Get
			Return New ImportDetailComparer()
		End Get
	End Property
End Class

Public Class InvoiceDetailComparer
	Implements IComparer(Of InvoiceDetailDTO)

	Public Function Compare(x As InvoiceDetailDTO, y As InvoiceDetailDTO) As Integer Implements IComparer(Of InvoiceDetailDTO).Compare
		If (x.ID = y.ID) Then
			Return 0
		End If

		Return -1
	End Function

	Public Shared ReadOnly Property Instance() As InvoiceDetailComparer
		Get
			Return New InvoiceDetailComparer()
		End Get
	End Property
End Class

Public Class ReceiptComparer
	Implements IComparer(Of ReceiptDTO)

	Public Function Compare(x As ReceiptDTO, y As ReceiptDTO) As Integer Implements IComparer(Of ReceiptDTO).Compare
		If (x.ID = y.ID) Then
			Return 0
		End If

		Return -1
	End Function

	Public Shared ReadOnly Property Instance() As ReceiptComparer
		Get
			Return New ReceiptComparer()
		End Get
	End Property
End Class
Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class ReceiptBUS
	Private receiptDAL As ReceiptDAL
	Private parameterBUS As ParameterBUS
	Private customerBUS As CustomerBUS

	Public Sub New()
		receiptDAL = New ReceiptDAL()
		parameterBUS = New ParameterBUS()
		customerBUS = New CustomerBUS()
	End Sub

	Public Sub New(connectionStr As String)
		receiptDAL = New ReceiptDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As String) As Result
		Return receiptDAL.getNextId(nextId)
	End Function

	Private Function IsValidToAdd(receipt As ReceiptDTO) As Result
		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)
		Dim customer As CustomerDTO

		If result.FlagResult = False Then
			Return result
		End If

		If (receipt.CustomerID Is Nothing) Then
			Return New Result(False, $"Customer ID of {receipt.ID} is missing", "")
		End If

		result = customerBUS.select_ByID(receipt.CustomerID, customer)

		If (result.FlagResult = True) Then
			If (receipt.CollectedAmount > customer.CurrentDebt) Then
				Return New Result(False, $"Total amount of {receipt.ID} is bigger than {customer.ID}'s current debt ({receipt.CollectedAmount} > {customer.CurrentDebt})", "")
			End If
		Else
			Return New Result(False, $"Cannot load customer when validating receipt", "")
		End If

		Return result
	End Function

	Private Function IsValidToUpdate(oldReceipt As ReceiptDTO, newReceipt As ReceiptDTO) As Result
		Dim parameter As ParameterDTO
		Dim result = parameterBUS.selectAll(parameter)
		Dim customer As CustomerDTO

		If result.FlagResult = False Then
			Return result
		End If

		If (newReceipt.CustomerID Is Nothing) Then
			Return New Result(False, $"Customer ID of {newReceipt.ID} is missing", "")
		End If

		If (oldReceipt.ID <> newReceipt.ID) Then
			Return IsValidToAdd(newReceipt)
		End If

		result = customerBUS.select_ByID(oldReceipt.CustomerID, customer)

		If (result.FlagResult = True) Then
			If (newReceipt.CollectedAmount - oldReceipt.CollectedAmount > customer.CurrentDebt) Then
				Return New Result(False, $"Total amount of {newReceipt.ID} is bigger than {customer.ID}'s current debt ({newReceipt.CollectedAmount - oldReceipt.CollectedAmount} > {customer.CurrentDebt})", "")
			End If
		Else
			Return New Result(False, $"Cannot load book when validating invoice detail", "")
		End If

		Return result
	End Function

	Public Function insert(receipt As ReceiptDTO) As Result
		Dim result As Result

		result = IsValidToAdd(receipt)

		If (result.FlagResult = False) Then
			Return result
		End If

		Dim customer As CustomerDTO
		result = customerBUS.select_ByID(receipt.CustomerID, customer)

		If (result.FlagResult = True) Then
			customer.CurrentDebt -= receipt.CollectedAmount
			customerBUS.update(customer)
		Else
			Return New Result(False, $"Cannot load customer for receipt {receipt.ID}", "")
		End If

		Return receiptDAL.insert(receipt)
	End Function

	Public Function select_ByID(receiptID As String, ByRef receipt As ReceiptDTO) As Result
		Return receiptDAL.select_ByID(receiptID, receipt)
	End Function

	Public Function selectALL(ByRef receipts As List(Of ReceiptDTO)) As Result
		Return receiptDAL.selectAll(receipts)
	End Function

	Public Function selectAll_ByDate(dateCollected As DateTime, ByRef receipts As List(Of ReceiptDTO)) As Result
		Return receiptDAL.selectAll_ByDate(dateCollected, receipts)
	End Function
	Public Function selectAll_ByCustomer(customerID As String, ByRef receipts As List(Of ReceiptDTO)) As Result
		Return receiptDAL.selectAll_ByCustomer(customerID, receipts)
	End Function

	Public Function update(newReceipt As ReceiptDTO) As Result
		Dim result As Result

		Dim oldReceipt As ReceiptDTO
		result = receiptDAL.select_ByID(newReceipt.ID, oldReceipt)

		If (result.FlagResult = False) Then
			Return New Result(False, $"Cannot get receipt {newReceipt.ID}", "")
		End If

		result = IsValidToUpdate(oldReceipt, newReceipt)

		If (result.FlagResult = False) Then
			Return result
		End If

		Dim customer As CustomerDTO
		result = customerBUS.select_ByID(newReceipt.CustomerID, customer)

		If (result.FlagResult = True) Then
			customer.CurrentDebt -= (newReceipt.CollectedAmount - oldReceipt.CollectedAmount)
			customerBUS.update(customer)
		Else
			Return New Result(False, $"Cannot load customer for receipt {newReceipt.ID}", "")
		End If

		Return receiptDAL.update(newReceipt)
	End Function

	Public Function delete(receiptID As String) As Result
		Return receiptDAL.delete(receiptID)
	End Function
End Class

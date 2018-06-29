Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class ReceiptBUS
	Private receiptDAL As ReceiptDAL

	Public Sub New()
		receiptDAL = New ReceiptDAL()
	End Sub

	Public Sub New(connectionStr As String)
		receiptDAL = New ReceiptDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return receiptDAL.getNextId(nextId)
	End Function

	Public Function insert(receipt As ReceiptDTO) As Result
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

	Public Function update(receipt As ReceiptDTO) As Result
		Return receiptDAL.update(receipt)
	End Function

	Public Function delete(receiptID As String) As Result
		Return receiptDAL.delete(receiptID)
	End Function
End Class

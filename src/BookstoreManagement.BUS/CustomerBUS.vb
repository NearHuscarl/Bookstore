Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class CustomerBUS
	Private customerDAL As CustomerDAL

	Public Sub New()
		customerDAL = New CustomerDAL()
	End Sub

	Public Sub New(connectionStr As String)
		customerDAL = New CustomerDAL(connectionStr)
	End Sub

	Public Function getNextId(ByRef nextId As String) As Result
		Return customerDAL.getNextId(nextId)
	End Function

	Public Function insert(customer As CustomerDTO) As Result
		Return customerDAL.insert(customer)
	End Function

	Public Function selectAll(ByRef customers As List(Of CustomerDTO)) As Result
		Return customerDAL.selectAll(customers)
	End Function

	Public Function selectAll_BySearch(name As String, ByRef customers As List(Of CustomerDTO)) As Result
		Return customerDAL.selectAll_BySearch(name, customers)
	End Function

	Public Function select_ByID(customerID As String, ByRef customer As CustomerDTO) As Result
		Return customerDAL.select_ByID(customerID, customer)
	End Function

	Public Function update(customer As CustomerDTO) As Result
		Return customerDAL.update(customer)
	End Function

	Public Function delete(customerID As String) As Result
		Return customerDAL.delete(customerID)
	End Function
End Class

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

	Public Function getNextId(ByRef nextId As Integer) As Result
		Return customerDAL.getNextId(nextId)
	End Function

	Public Function insert(customer As CustomerDTO) As Result
		Return customerDAL.insert(customer)
	End Function

	Public Function sellectALL(ByRef customers As List(Of CustomerDTO)) As Result
		Return customerDAL.sellectALL(customers)
	End Function

	Public Function update(customer As CustomerDTO) As Result
		Return customerDAL.update(customer)
	End Function

	Public Function delete(customerID As String) As Result
		Return customerDAL.delete(customerID)
	End Function
End Class

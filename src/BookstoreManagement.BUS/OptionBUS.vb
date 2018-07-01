Imports BookstoreManagement.DAL
Imports BookstoreManagement.DTO
Imports Utility

Public Class OptionBUS
	Private optionDAL As OptionDAL

	Public Sub New()
		optionDAL = New OptionDAL()
	End Sub

	Public Sub New(connectionStr As String)
		optionDAL = New OptionDAL(connectionStr)
	End Sub

	Public Function selectAll(ByRef _option As OptionDTO) As Result
		' Validate here
		Return optionDAL.selectAll(_option)
	End Function

	Public Function update(_option As OptionDTO) As Result
		Return optionDAL.update(_option)
	End Function
End Class

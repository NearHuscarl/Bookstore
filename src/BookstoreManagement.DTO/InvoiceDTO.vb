﻿Public Class InvoiceDTO
	Private _ID As String
	Private _customerID As String
	Private _dateCreate As DateTime
	Private _amount As Integer
   Private _debtBeforeSales As Integer

   Public Sub New()
   End Sub

   Public Sub New(
        ID As String,
        customerID As String,
        dateCreate As DateTime,
        amount As Integer,
        debtBeforeSales As Integer)

      Me._ID = ID
      Me._customerID = customerID
      Me._dateCreate = dateCreate
      Me._amount = amount
      Me._debtBeforeSales = debtBeforeSales
   End Sub

   Property ID() As String
      Get
         Return _ID
      End Get
      Set(ByVal Value As String)
         _ID = Value
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

   Property DateCreate() As DateTime
      Get
         Return _dateCreate
      End Get
      Set(ByVal Value As DateTime)
         _dateCreate = Value
      End Set
   End Property

   Property Amount() As Integer
      Get
         Return _amount
      End Get
      Set(ByVal Value As Integer)
         _amount = Value
      End Set
   End Property

   Property DebtBeforeSales() As Integer
      Get
         Return _debtBeforeSales
      End Get
      Set(ByVal Value As Integer)
         _debtBeforeSales = Value
      End Set
   End Property
End Class

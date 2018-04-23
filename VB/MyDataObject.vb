Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.ObjectModel
Imports System.Windows.Controls

Namespace FilterRuntime
	Public Class MyDataObject
		Public Shared Function GetDemoData() As ObservableCollection(Of MyDataObject)
			Dim list As New ObservableCollection(Of MyDataObject)()
			list.Add(New MyDataObject() With {.Item = "SD970 IS", .Price = 379.99D, .Discontinued = False, .Announced = New DateTime(2009, 2, 18)})
			list.Add(New MyDataObject() With {.Item = "G10", .Price = 419.99D, .Discontinued = False, .Announced = New DateTime(2008, 9, 17)})
			list.Add(New MyDataObject() With {.Item = "A580", .Price = 118.00D, .Discontinued = False, .Announced = New DateTime(2008, 1, 24)})
			list.Add(New MyDataObject() With {.Item = "EOS D30", .Price = 275.00D, .Discontinued = True, .Announced = New DateTime(2000, 5, 17)})
			Return list
		End Function

		Private privateItem As String
		Public Property Item() As String
			Get
				Return privateItem
			End Get
			Set(ByVal value As String)
				privateItem = value
			End Set
		End Property
		Private privatePrice As Decimal
		Public Property Price() As Decimal
			Get
				Return privatePrice
			End Get
			Set(ByVal value As Decimal)
				privatePrice = value
			End Set
		End Property
		Private privateAnnounced As DateTime
		Public Property Announced() As DateTime
			Get
				Return privateAnnounced
			End Get
			Set(ByVal value As DateTime)
				privateAnnounced = value
			End Set
		End Property
		Private privateDiscontinued As Boolean
		Public Property Discontinued() As Boolean
			Get
				Return privateDiscontinued
			End Get
			Set(ByVal value As Boolean)
				privateDiscontinued = value
			End Set
		End Property
	End Class
End Namespace

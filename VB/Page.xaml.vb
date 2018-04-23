Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.ObjectModel
Imports System.Windows.Controls
Imports DevExpress.Data.Filtering

Namespace FilterRuntime
	Partial Public Class Page
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			AgDataGrid1.DataSource = MyDataObject.GetDemoData()

			' set filter
			Dim filter As CriteriaOperator = (New OperandProperty("Price") < 400)
			AgDataGrid1.FilterCriteria = filter
			AgDataGrid1.ActiveFilterEnabled = True

			TextBlockFilter.Text = AgDataGrid1.FilterCriteria.ToString()
		End Sub
	End Class
End Namespace
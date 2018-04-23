Imports DevExpress.Data.Filtering

Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()

        AgDataGrid1.DataSource = MyDataObject.GetDemoData()

        ' set filter
        Dim filter As CriteriaOperator
        filter = (New OperandProperty("Price") < 400)
        AgDataGrid1.FilterCriteria = filter

        TextBlockFilter.Text = AgDataGrid1.FilterCriteria.ToString()
    End Sub

End Class
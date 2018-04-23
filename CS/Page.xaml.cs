using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using DevExpress.Data.Filtering;

namespace FilterRuntime {
    public partial class Page : UserControl {
        public Page() {
            InitializeComponent();

            AgDataGrid1.DataSource = MyDataObject.GetDemoData();

            // set filter
            CriteriaOperator filter = (new OperandProperty("Price") < 400);
            AgDataGrid1.FilterCriteria = filter;
            AgDataGrid1.ActiveFilterEnabled = true;

            TextBlockFilter.Text = AgDataGrid1.FilterCriteria.ToString();
        }
    }
}
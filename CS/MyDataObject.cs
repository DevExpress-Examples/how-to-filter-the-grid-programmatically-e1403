using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace FilterRuntime {
    public class MyDataObject {
        public static ObservableCollection<MyDataObject> GetDemoData() {
            ObservableCollection<MyDataObject> list = new ObservableCollection<MyDataObject>();
            list.Add(new MyDataObject() {
                Item = "SD970 IS",
                Price = 379.99m,
                Discontinued = false,
                Announced = new DateTime(2009, 2, 18)
            });
            list.Add(new MyDataObject() {
                Item = "G10",
                Price = 419.99m,
                Discontinued = false,
                Announced = new DateTime(2008, 9, 17)
            });
            list.Add(new MyDataObject() {
                Item = "A580",
                Price = 118.00m,
                Discontinued = false,
                Announced = new DateTime(2008, 1, 24)
            });
            list.Add(new MyDataObject() {
                Item = "EOS D30",
                Price = 275.00m,
                Discontinued = true,
                Announced = new DateTime(2000, 5, 17)
            });
            return list;
        }

        public string Item { get; set; }
        public decimal Price { get; set; }
        public DateTime Announced { get; set; }
        public bool Discontinued { get; set; }
    }
}

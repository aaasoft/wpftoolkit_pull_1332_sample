using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Sample.Model
{
    public class Model_1
    {
        public ObservableCollection<Model_2> Model2List { get; set; } = new ObservableCollection<Model_2>();
    }
}

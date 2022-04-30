using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MobileAPIFelix.Model
{
    public class RootModel
    {
        public int count { get; set; }
        public ObservableCollection<EntrieModel> entries { get; set; }
    }
}

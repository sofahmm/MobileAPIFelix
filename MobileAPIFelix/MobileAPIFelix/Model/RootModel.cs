using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAPIFelix.Model
{
    public class RootModel
    {
        public int count { get; set; }
        public List<EntrieModel> entries { get; set; }
    }
}

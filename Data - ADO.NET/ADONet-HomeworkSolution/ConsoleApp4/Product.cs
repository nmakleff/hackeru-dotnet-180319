using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Product
    {
        public int? ProductID { get; set; }  // int? is the same as Nullable<int>
        public string Name { get; set; }
        public double? Price { get; set; }
        public string SerialNumber { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sample1
{
    public class Employee: IIsLoaded
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public bool IsLoaded()
        {
            if (ID == string.Empty)
                return false;
            else
                return true;
        }
    }
}

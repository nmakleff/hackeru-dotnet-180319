using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sample1
{
    public class Monkey: Mamal, IIsLoaded
    {
        public Monkey()
        {
            Name = "Monkey";
        }

        public bool IsLoaded()
        {
            return true;
        }
    }
}

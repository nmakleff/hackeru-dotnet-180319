using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Sample
{
    class Human
    {
        private string _name;
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value >= 0)
                    if (value >= _age)
                        if (value < 120)
                            _age = value;
            }
        }

        public Human(string name)
        {
            _name = name;
            _age = 0;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyClass
    {
        private int _data;

        public int Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
                if (OnDataChanged != null)
                {
                    OnDataChanged(_data);
                }
            }
        }

        public delegate void DataChanged(int newValue);

        public event DataChanged OnDataChanged;
    }

    class Program
    {
        static void PrintNewValue(int newValue)
        {
            Console.WriteLine("My new value is " + newValue);
        }

        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.OnDataChanged += new MyClass.DataChanged(PrintNewValue);
        }
    }
}


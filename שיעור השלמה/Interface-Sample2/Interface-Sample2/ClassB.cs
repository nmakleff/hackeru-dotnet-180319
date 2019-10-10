using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sample2
{
    public class ClassB : IMonitoredComponent
    {
        public ClassB()
        {
            Status = EnumStatus.OK;
        }

        public EnumStatus Status { get; set; }

        public string GetComponentName()
        {
            return "ClassB";
        }

        public EnumStatus GetStatus()
        {
            return Status;
        }
    }
}

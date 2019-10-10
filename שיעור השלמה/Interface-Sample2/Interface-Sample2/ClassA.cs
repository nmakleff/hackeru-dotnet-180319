using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sample2
{
    public class ClassA : IMonitoredComponent
    {
        public ClassA()
        {
            Status = EnumStatus.OK;
        }

        public EnumStatus Status { get; set; }

        public string GetComponentName()
        {
            return "ClassA";
        }

        public EnumStatus GetStatus()
        {
            return Status;
        }
    }
}

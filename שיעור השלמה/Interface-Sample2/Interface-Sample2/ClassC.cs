using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sample2
{
    public class ClassC : IMonitoredComponent
    {
        public ClassC()
        {
            Status = EnumStatus.OK;
        }

        public EnumStatus Status { get; set; }

        public string GetComponentName()
        {
            return "ClassC";
        }

        public EnumStatus GetStatus()
        {
            return Status;
        }

    }
}

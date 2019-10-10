using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sample2
{
    public class ClassD : IMonitoredComponent
    {
        public ClassD()
        {
            Status = EnumStatus.OK;
        }

        public EnumStatus Status { get; set; }

        public string GetComponentName()
        {
            return "ClassD";
        }

        public EnumStatus GetStatus()
        {
            return Status;
        }

    }
}

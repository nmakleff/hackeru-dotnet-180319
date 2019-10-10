using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sample2
{
    public interface IMonitoredComponent
    {
        EnumStatus GetStatus();
        string GetComponentName();
    }

    public enum EnumStatus
    {
        OK,
        Error
    }
}

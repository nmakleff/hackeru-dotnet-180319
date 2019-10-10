using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sample1
{
    public class LoadingMonitor
    {
        private IIsLoaded[] _classesToMonitor;

        public LoadingMonitor(IIsLoaded[] classesToMonitor)
        {
            _classesToMonitor = classesToMonitor;
        }

        public int LoadingPercentage()
        {
            double loadedCount = 0;
            for (int i = 0; i < _classesToMonitor.Length; i++)
                if (_classesToMonitor[i].IsLoaded() == true)
                    loadedCount++;

            return (int)(loadedCount / (double)_classesToMonitor.Length) * 100;
        }
    }
}

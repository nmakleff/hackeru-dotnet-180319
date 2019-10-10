using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Interface_Sample2
{
    class Monitor
    {
        private List<IMonitoredComponent> _monitoredComponents = new List<IMonitoredComponent>();

        public delegate void Error(string componentName);
        public event Error OnError;

        public void AddMonitoredComponent (IMonitoredComponent comp)
        {
            _monitoredComponents.Add(comp);
        }

        public void Start()
        {
            Thread MonitoringThread = new Thread(Run);
            MonitoringThread.Start();
        }

        private void Run()
        {
            while (true)
            {
                for (int i = 0; i < _monitoredComponents.Count; i++)
                    if (_monitoredComponents[i].GetStatus() == EnumStatus.Error)
                        if (OnError != null)
                            OnError(_monitoredComponents[i].GetComponentName());

                Thread.Sleep(1000);
            }
        }

    }
}

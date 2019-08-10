using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AlarmClock
{
    class Alarm
    {
        private Thread _thread;
        private bool _isThreadRunning;

        private void Worker()
        {
            int counter = 0;

            while (_isThreadRunning)
            {
                Thread.Sleep(1000);
                counter++;
                if (counter % 60 == 0)
                    Console.WriteLine(counter / 60 + " minutes has passed");
            }
        }

        public void Start()
        {
            _isThreadRunning = true;
            _thread = new Thread(Worker);
            _thread.Start();
        }

        public void Stop()
        {
            _isThreadRunning = false;
            _thread.Join();
        }
    }
}

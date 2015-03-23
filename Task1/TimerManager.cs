using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    public class TimerManager
    {
        public delegate void NewTimerEventHandler(object sender, NewTimerEventArgs e);

        public event NewTimerEventHandler NewTimer;

        public void SimulateCountDown(int time)
        {
            Thread.Sleep(time * 1000);
            OnNewTimer(this, new NewTimerEventArgs(time));
        }

        protected virtual void OnNewTimer(object sender, NewTimerEventArgs e)
        {
            if (NewTimer != null)
            {
                NewTimer(sender, e);
            }
        }
    }
}

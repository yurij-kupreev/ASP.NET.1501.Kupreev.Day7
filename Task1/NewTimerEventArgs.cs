using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class NewTimerEventArgs : EventArgs
    {
        private readonly int time;

        public NewTimerEventArgs(int time)
        {
            this.time = time;
        }

        public int Time { get { return time; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    public class TimerImitation
    {
        public void Imitation(TimerManager manager, int countdown)
        {
            Thread.Sleep(countdown * 1000);
            manager.SimulateCountDown(countdown);  
        }
    }
}

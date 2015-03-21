using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public sealed class SignedClassNumber1 : SignedTypesBase
    {
        public override void Register(TimerManager timer)
        {
            timer.NewTimer += SignedTypeNumber1Msg;
        }

        public override void Unregister(TimerManager timer)
        {
            timer.NewTimer -= SignedTypeNumber1Msg;
        }

        public override String GetMsg()
        {
            String returnedMsg = message;
            message = String.Empty;
            if (returnedMsg != String.Empty)
            {
                return returnedMsg;
            }
            else throw new Exception("SignedClassNumber1: This type did't get the message.");
        }

        private void SignedTypeNumber1Msg(Object sender, NewTimerEventArgs eventArgs)
        {
            message = "SignedClassNumber1: Timer worked " + eventArgs.Time + " second(s).";
        }
    }

    public sealed class SignedClassNumber2 : SignedTypesBase
    {
        public override void Register(TimerManager timer)
        {
            timer.NewTimer += SignedTypeNumber2Msg;
        }

        public override void Unregister(TimerManager timer)
        {
            timer.NewTimer -= SignedTypeNumber2Msg;
        }

        public override String GetMsg()
        {
            String returnedMsg = message;
            message = String.Empty;
            if (returnedMsg != String.Empty)
            {
                return returnedMsg;
            }
            else throw new Exception("SignedClassNumber2: This type did't get the message.");
        }

        private void SignedTypeNumber2Msg(Object sender, NewTimerEventArgs eventArgs)
        {
            message = "SignedClassNumber2: Timer worked " + eventArgs.Time + " second(s).";
        }
    }
}

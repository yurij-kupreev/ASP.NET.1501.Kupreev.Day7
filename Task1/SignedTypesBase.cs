using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class SignedTypesBase
    {
        protected String message = String.Empty;
        public virtual String GetMsg() { return String.Empty; }
        public virtual void Register(TimerManager timer) { }
        public virtual void Unregister(TimerManager mail) { }
    }
}

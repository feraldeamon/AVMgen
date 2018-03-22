using System;
using System.Collections.Generic;
using System.Text;

namespace AVMgen
{
    class AVM
    {
        public RegisterSet set = new RegisterSet();     //The list of registers for the machine
        public Register32 currentRegister = null;         //Hold the current register being looked at

        public AVM()
        {
            set.SetValue("EAX", Int32.MaxValue);
            set.SetValue("EBX", Int32.MinValue);
        }
    }
}

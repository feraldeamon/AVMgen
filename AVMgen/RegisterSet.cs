using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AVMgen
{
    class RegisterSet
    {
        List<Register32> reg = new List<Register32>();
        private Register32 register1;

        public RegisterSet()
        {
            register1 = new Register32("EAX", "General");
            reg.Add(register1);
            Register32 register2 = new Register32("EBX", "General");
            reg.Add(register2);
        }

        public void setValue(int val)
        {
            Register32 temp = reg[0];
            temp.RegisterValue = val;
            Console.WriteLine(temp.RegisterValue);
        }

        public void SetValue(String literal, int val)
        {
            Register32 temp = findRegisterByRegisterLiteral(literal);
            if (!(temp == null))
            {
                temp.RegisterValue = val;
            }
            else
            {
                throw new SyntaxErrorException("Invalid Register");
            }
            
        }

        private Register32 findRegisterByRegisterLiteral(String literal)
        {
            Register32 temp = null;
            foreach (Register32 tp in reg)
            {
                if (literal.Equals(tp.RegisterLiteral))
                    temp = tp;
            }
            return temp;
        }

        private Register32 findRegisterByRegisterName(String name)
        {
            Register32 temp = null;
            foreach (Register32 tp in reg)
            {
                if (name.Equals(tp.RegisterLiteral))
                    temp = tp;
            }
            return temp;
        }

        private Register32 findRegisterByRegisterValue(int value)
        {
            Register32 temp = null;
            foreach (Register32 tp in reg)
            {
                if (value == tp.RegisterValue)
                    temp = tp;
            }
            return temp;
        }
    }
}

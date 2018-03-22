using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AVMgen
{
    public enum ValueType
    {
        Integer,
        Double,
        Character,
        String
    };

    public enum GeneralRegisterType
    {
        Accumulator,
        Counter,
        Base,
        StackPointer,
        StackBasePointer,
        SourceIndex,
        DestinationIndex

    }

    interface IRegister
    {
        String RegisterName { get; set; }
        String RegisterLiteral { get; set; }
        byte[] Storage { get; }
        GeneralRegisterType Type { get; set; }
        UInt64 RegisterSize { get; set; }
    }

    public class Register32 : IRegister
    {

        private Int32 value;
        private Int32 _RegisterValue;

        public Register32()
        {

        }

        public Register32(String literal, String name)
        {
            this.RegisterName = name;
            this.RegisterLiteral = literal;
            this.RegisterSize = 32;
            this.Storage = new byte[(32 / 8)];
            
        }

        public Int32 RegisterValue
        {
            get { return _RegisterValue; }
            set {
                    _RegisterValue = value;
                    Storage = BitConverter.GetBytes(value);
                    Array.Reverse(Storage);
                }

        }

        public String RegisterName { get; set; }


        public String RegisterLiteral { get; set; }
       

        public byte[] Storage { get; private set; }

        public GeneralRegisterType Type { get; set; }

        public UInt64 RegisterSize { get; set; }

        /*

        public void SetRegisterName(String name)
        {
            RegisterName = name;
        }

        public void SetRegisterLiteral(String literal)
        {
            RegisterLiteral = literal;
        }

        public void SetRegisterSize(int val)
        {
            RegisterSize = (UInt64) val;
        }

        public String GetRegisterName()
        {
            return RegisterName;
        }

        public String GetRegisterLiteral()
        {
            return RegisterLiteral;
        }

        public UInt64 GetRegisterSize()
        {
            return RegisterSize;
        }

        public void SetRegisterValue(int val)
        {
            value = val;
            Storage = ConvertInt32ToByteArray(value);
            Array.Reverse(Storage);
            PrintByteInBinary();
            PrintByteInHex();
        }

        public int GetRegisterValue()
        {
            return value;
        }

        public void PrintByteInBinary()
        {
            string s = string.Join(" ", Storage.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
            Console.WriteLine(s);
        }

        public void PrintByteInHex()
        {
            Console.WriteLine(BitConverter.ToString(Storage));
        }

        private void SetStorageRegister()
        {

        }

        private byte[] ConvertInt32ToByteArray(Int32 I32)
        {
            return BitConverter.GetBytes(I32);
        }

        private byte[] ConvertIntToByteArray(Int16 I16)
        {
            return BitConverter.GetBytes(I16);
        }

        private byte[] ConvertIntToByteArray(Int64 I64)
        {
            return BitConverter.GetBytes(I64);
        }

        private byte[] ConvertIntToByteArray(int I)
        {
            return BitConverter.GetBytes(I);
        } */
    }
}

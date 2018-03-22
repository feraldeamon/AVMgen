using System;

namespace AVMgen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AVM avm = new AVM();
            Code cd = new Code();
            cd.readFile(" ");

            String temp = cd.GetNextLine();
            Console.WriteLine(temp);
            
            while(temp != null)
            {
                Console.WriteLine(temp);
                temp = cd.GetNextLine();
            }

            Console.ReadKey();
        }
    }
}

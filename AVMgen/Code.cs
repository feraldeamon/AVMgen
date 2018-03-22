using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;

namespace AVMgen
{
    class Code
    {
        private List<String> code = new List<String>();
        IEnumerator<String> codeIterator;
        private int index = 0;

        public Code()
        {

        }

        public void readFile(String fileName)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\David\source\repos\AVMgen\AVMgen\Test\Test1.txt");
            String line;
            while ((line = file.ReadLine()) != null)
            {
                code.Add(line);
                System.Console.WriteLine(line);
            }
            codeIterator = GetNext();
        }

        public IEnumerator<String> GetNext()
        {
            foreach(String temp in code)
            {
                yield return temp;
            }
        }

        public String ShowNext()
        {
            return null;
        }

        public String GetNextLine()
        {
            if (codeIterator.MoveNext())
                return codeIterator.Current;
            else
                return null;
        }


    }
}

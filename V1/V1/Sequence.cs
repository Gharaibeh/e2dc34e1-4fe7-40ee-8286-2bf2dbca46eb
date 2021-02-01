using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1
{
    class Sequence
    {
        string[] array;
        List<string> myList;
        List<string> resultList1;
        List<string> resultList2;

        public Sequence()
        {
            Console.WriteLine("Constructor");
            myList = new List<string>();
            resultList1 = new List<string>();
            resultList2 = new List<string>();
            fun1("6 1 5 9 2");

           
        }
        public void print()
        {
            Console.WriteLine("Testing Class");
        }
    }
}

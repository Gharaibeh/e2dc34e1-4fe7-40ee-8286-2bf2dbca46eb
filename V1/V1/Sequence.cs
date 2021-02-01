﻿using System;
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
          

           
        }

        public void fun1(string _inputString)
        {

            myList = _inputString.Split(' ').ToList();



            int fromIndex = 0;
            int toIndex = 0;
            bool toCheck = true;
            fromIndex = 0;
            resultList1.Add(myList[fromIndex]);

            while (fromIndex < myList.Count - 1)
            {
                if (int.Parse(myList[fromIndex]) < int.Parse(myList[fromIndex + 1]))
                {
                    fromIndex++;
                    resultList1.Add(myList[fromIndex]);
                }
                else
                {
                    if (resultList1.Count > resultList2.Count)
                    {
                        resultList2.Clear();
                        foreach (string x in resultList1)
                            resultList2.Add(x);
                    }
                    fromIndex++;
                    resultList1.Clear();
                    resultList1.Add(myList[fromIndex]);
                }
            }

            if (resultList1.Count > resultList2.Count)
            {
                resultList2.Clear();
                foreach (string x in resultList1)
                    resultList2.Add(x);
            }
            Console.WriteLine("the longest sequence is :  ");
            foreach (string aa in resultList2)
                Console.WriteLine(aa);




        } 
    }
}

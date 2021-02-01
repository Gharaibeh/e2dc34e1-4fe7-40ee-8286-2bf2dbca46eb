using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace V1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sequence seq = new Sequence();
                /* Input sample examples:
                 printResult(seq.returnSubsequence("6 2 4 6 1 5 9 2"));
                 printResult(seq.returnSubsequence("6 1 5 9 2"));
                 printResult(seq.returnSubsequence("6 2 4 3 1 5 9"));*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();

        }

        /// <summary>
        /// PrintOut Function
        /// </summary>
        /// <param name="output"></param>
        static void printResult(string output)
        {
            Console.WriteLine("The longest subsequence is:\n" + output);
        }
    }
}

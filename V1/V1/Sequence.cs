using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace V1
{
   public class Sequence
    {

        List<string> splittedList;
        List<string> originalList;
        List<string> comparableList;

        StringBuilder resultString;
       
        /// <summary>
        /// Constructor
        /// </summary>
        public Sequence()
        {
            InitializeComponents();
        }
       
        /// <summary>
        /// Initializer
        /// </summary>
        void InitializeComponents()
        {
            splittedList = new List<string>();
            originalList = new List<string>();
            comparableList = new List<string>();
            resultString = new StringBuilder();
        }

        /// <summary>
        /// Split long string into structured list of strings
        /// </summary>
        /// <param name="_inputString"></param>
        /// <returns></returns>
        List<string> inputStreamSplitter(string _inputString)
        {
            List<string> _list = new List<string>();
            _list = _inputString.Split(' ').ToList();
            return _list;
        }

        public string returnSubsequence(string _inputString)
        {

            splittedList = inputStreamSplitter(_inputString);
             
            int fromIndex = 0;
           
            fromIndex = 0;
            originalList.Add(splittedList[fromIndex]);

            while (fromIndex < splittedList.Count - 1)
            {
                if (int.Parse(splittedList[fromIndex]) < int.Parse(splittedList[fromIndex + 1]))
                {
                    fromIndex++;
                    originalList.Add(splittedList[fromIndex]);
                }
                else
                {
                    if (originalList.Count > comparableList.Count)
                    {
                        comparableList.Clear();
                        foreach (string x in originalList)
                            comparableList.Add(x);
                    }
                    fromIndex++;
                    originalList.Clear();
                    originalList.Add(splittedList[fromIndex]);
                }
            }

            if (originalList.Count > comparableList.Count)
            {
                comparableList.Clear();
                foreach (string x in originalList)
                    comparableList.Add(x);
            }

            foreach (string element in comparableList)
                resultString.Append(element + " ");



            return resultString.ToString();  

        } 
    }
}

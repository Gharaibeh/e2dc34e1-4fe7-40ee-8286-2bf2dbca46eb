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
        List<string> comparatorList;
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
        private void InitializeComponents()
        {
            splittedList = new List<string>();
            comparatorList = new List<string>();
            comparableList = new List<string>();
            resultString = new StringBuilder();
        }

        /// <summary>
        /// Split long string into structured list of strings
        /// </summary>
        /// <param name="_inputString"></param>
        /// <returns></returns>
        private List<string> inputStreamSplitter(string _inputString)
        {
            List<string> _list = new List<string>();
            _list = _inputString.Split(' ').ToList(); // Assuming the split char is one space.

            if (validateInput(_list))
                return _list;
            else
                return null;
        }

        /// <summary>
        /// Validate if digits only
        /// </summary>
        /// <param name="_list"></param>
        /// <returns></returns>
        private bool validateInput(List<string> _list)
        {
            foreach (string portion in _list)
            {
                if (!portion.All(c => char.IsDigit(c)))
                {
                    throw new Exception("All should be digits, Bad input format!");
                }
            }
            return true;
        }

        /// <summary>
        /// Return the longest subsequence
        /// </summary>
        /// <param name="_inputString"></param>
        /// <returns></returns>
        public string returnSubsequence(string _inputString)
        {
            splittedList = inputStreamSplitter(_inputString);
            int index = 0;
            comparatorList.Add(splittedList[index]);

            while (index < splittedList.Count - 1)
            {
                if (int.Parse(splittedList[index]) < int.Parse(splittedList[index + 1]))
                {
                    index++;
                    comparatorList.Add(splittedList[index]);
                }
                else
                {
                    compareLongestSequence();
                    index++;
                    comparatorList.Clear();
                    comparatorList.Add(splittedList[index]);
                }
            }
            // Last check after exit loop
            compareLongestSequence();

            //return result
            return convertIntoString(comparableList);
        }

        /// <summary>
        /// Compare lists to save the longest subsequence
        /// </summary>
        private void compareLongestSequence()
        {
            if (comparatorList.Count > comparableList.Count)
            {
                comparableList.Clear();
                foreach (string element in comparatorList)
                    comparableList.Add(element);
            }
        }

        /// <summary>
        /// Convert from list into string (proposed output)
        /// </summary>
        /// <param name="_comparableList"></param>
        /// <returns></returns>
        private string convertIntoString(List<string> _comparableList)
        {
            foreach (string element in comparableList)
                resultString.Append(element + " ");
            
            return resultString.ToString().Trim();
        }
    }
}

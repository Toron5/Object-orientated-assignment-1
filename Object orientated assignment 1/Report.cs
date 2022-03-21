using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        public void reportOutput(List<int> parameters)
        {
            Console.WriteLine("Sentences used --> = {0}", parameters[0]);
            Console.WriteLine("Vowels used --> = {0}", parameters[1]);
            Console.WriteLine("Consonants used --> = {0}", parameters[2]);
            Console.WriteLine("Upper case letters used --> = {0}", parameters[3]);
            Console.WriteLine("Lower case letters used --> = {0}", parameters[4]);
        }
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void outputDictionary(Dictionary<char, int> dict)
        {
            foreach (KeyValuePair<char, int> entry in dict)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
        }
        public void writeListToFile(List<string> list, string fileName)
        {
            File.WriteAllLines(fileName, list);
        }
    }
}
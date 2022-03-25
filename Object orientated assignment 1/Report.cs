using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        // takes in the splitted values from the input that have gone through the Analyse text function
        public void reportOutput(List<int> sorted_text)
        {
            // splits each value individualy and outputs their meaning 
            //Console.WriteLine("Sentences used --> = {0}", sorted_text[0] + "\n Vowels used --> = {0}", sorted_text[1] + "\n Consonants used --> = {0}", sorted_text[2] + "\n Upper case letters used --> = {0}", sorted_text[3] + "\n Lower case letters used --> = {0}", sorted_text[4]);
            Console.WriteLine("Sentences used --> = {0}", sorted_text[0]);
            Console.WriteLine("Vowels used --> = {0}", sorted_text[1]);
            Console.WriteLine("Consonants used --> = {0}", sorted_text[2]);
            Console.WriteLine("Upper case letters used --> = {0}", sorted_text[3]);
            Console.WriteLine("Lower case letters used --> = {0}", sorted_text[4]);
        }
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        //this outputs the Dictonary in a readable way for the user
        public void Print_Dictionary(Dictionary<char, int> dict)
        {
            // key value pair checks for each matching pair 
            foreach (KeyValuePair<char, int> entry in dict)
            {
                // prints the letter and the value 
                Console.WriteLine("{0}--> {1}", entry.Key, entry.Value);
            }
        }

        //creates a long words file
        public void WriteToFile(List<string> list, string fileName)
        {
            File.WriteAllLines(fileName, list);
        }
    }
}
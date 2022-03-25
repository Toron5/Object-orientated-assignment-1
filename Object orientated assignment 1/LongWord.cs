using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class LongWord
    {
        public void LongWordChoice(string text)
        {
            Analyse analyse = new Analyse();
            Report report = new Report();                       
            List<string> longWords = analyse.text_LongWords(text);
            report.WriteToFile(longWords, "LongWords.txt");
            Console.WriteLine("Text has been written into a long text file");

            return ;
        }
    }
}

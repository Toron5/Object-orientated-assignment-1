//Base code project for CMP1903M Assessment 1

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            bool End = false;
            while (End != true)
            {
                Console.WriteLine("Pick a number:");
                Console.WriteLine("----------------------");
                Console.WriteLine(" 1: User Input ");
                Console.WriteLine(" 2: File Input");
                Console.WriteLine(" 3: Quit");
                Console.WriteLine("----------------------");
                string Option = Console.ReadLine();
                if (Option == "3")
                {
                    End = true;
                }

                Input input = new Input();
                Analyse analyse = new Analyse();
                Report report = new Report();
                string text = "";
                if (Option == "1")
                {
                    text = input.manualTextInput();
                    Console.WriteLine(text);
                    List<int> parameters = analyse.analyseText(text);
                    report.reportOutput(parameters);

                    Dictionary<char, int> letterCounts = analyse.countLetters(text);
                    report.outputDictionary(letterCounts);

                    string userLongWordsReportChoice = Console.ReadLine();
                    if (userLongWordsReportChoice.ToLower() == "y")
                    {
                        //Write report of long words to LongWords.txt
                        List<string> longWords = analyse.extractLongWords(text);
                        report.writeListToFile(longWords, "LongWords.txt");
                        Console.WriteLine("Long words have been written to: LongWords.txt");
                    }
                }
                if (Option == "2")
                {
                    Console.WriteLine(" 2: File Input chosen");
                    text = input.fileTextInput("./TestFile.txt");
                    Console.WriteLine("");
                    Console.WriteLine("Input read from file:");
                    Console.WriteLine("----------");
                    Console.WriteLine(text);
                    Console.WriteLine("----------");
                    Console.WriteLine("");
                    List<int> parameters = analyse.analyseText(text);
                    report.reportOutput(parameters);

                    Dictionary<char, int> letterCounts = analyse.countLetters(text);
                    report.outputDictionary(letterCounts);

                    string userLongWordsReportChoice = Console.ReadLine();
                    if (userLongWordsReportChoice.ToLower() == "y")
                    {
                        //Write report of long words to LongWords.txt
                        List<string> longWords = analyse.extractLongWords(text);
                        report.writeListToFile(longWords, "LongWords.txt");
                        Console.WriteLine("Long words have been written to: LongWords.txt");
                    }
                }
                Console.WriteLine("out");
                //Local list of integers to hold the first five measurements of the text

            }



            //Create 'Input' object
            //Get either manually entered text, or text from a file


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }



    }
}
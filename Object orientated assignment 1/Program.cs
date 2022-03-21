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
                Start start = new Start();
                string Choice = "";
                string Option = start.UserInput(Choice);
                
                if (Option == "3")
                {
                    End = true;
                }

                Input input = new Input();
                //Create 'Input' object
                //Get either manually entered text, or text from a file
                Analyse analyse = new Analyse();
                Report report = new Report();
                string text = "";
                if (Option == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Enter the text passage and end it with an *");
                    text = input.manualTextInput();
                    Console.Clear();
                    Console.WriteLine(text);
                    List<int> parameters = analyse.analyseText(text);
                    report.reportOutput(parameters);

                    Dictionary<char, int> letterCounts = analyse.countLetters(text);
                    report.outputDictionary(letterCounts);
                    Console.WriteLine("do you want a long text file y/n");
                    
                    string LongText = Console.ReadLine();
                    if (LongText.ToLower() == "y")
                    {
                        Console.Clear();
                        //Write report of long words to LongWords.txt
                        List<string> longWords = analyse.extractLongWords(text);
                        report.writeListToFile(longWords, "LongWords.txt");
                        Console.WriteLine("Long words have been written to: LongWords.txt");
                    }
                }
                if (Option == "2")
                {
                    Console.Clear();
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
                    Console.WriteLine("do you want a long text file y/n");
                    string userLongWordsReportChoice = Console.ReadLine();
                    if (userLongWordsReportChoice.ToLower() == "y")
                    {
                        //Write report of long words to LongWords.txt
                        List<string> longWords = analyse.extractLongWords(text);
                        report.writeListToFile(longWords, "LongWords.txt");
                        Console.WriteLine("Long words have been written to: LongWords.txt");
                    }
                }
                
                
                //Local list of integers to hold the first five measurements of the text

            }



            


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }



    }
}
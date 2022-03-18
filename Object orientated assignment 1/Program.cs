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


                if (Option == "1")
                {
                    string text = input.manualTextInput();
                    Console.WriteLine(text);
                    List<int> parameters = analyse.analyseText(text);

                }
                if (Option == "2")
                {
                    Console.WriteLine(" 2: File Input chosen");
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
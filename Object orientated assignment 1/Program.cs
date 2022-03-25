//Base code project for CMP1903M Assessment 1



namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        // Start of the Program Code
        static void Main()
        {
            // defines an end bool to keep the program looping untill quit is chosen
            bool End = false;
            while (End != true)
            {
                LongWord longWord = new LongWord();
                
                //creates start as an object 
                Start start = new Start();
                //define the string choice as blank 
                string Choice = "";
                // creates option variable where the number choice of what the code does is chosen
                // goes into the start class and runs though 
                //Get either manually entered text or text from a file
                string Option = start.UserInput(Choice);
                // returns the Option value which will be 1 ,2 or 3

                // if option 3 is chosen the program will end
                if (Option == "3")
                {
                    // changes the value of end to true and will end the code loop
                    End = true;
                }

                //Creates Input, analyse and report object
                Input input = new Input();
                Analyse analyse = new Analyse();
                Report report = new Report();
                // defines text
                string text = "";

                // checks if option 1 was selected 
                if (Option == "1")
                {
                    // clears the console to make it easier to read
                    Console.Clear();
                    Console.WriteLine("Enter the text passage and end it with an *");
                    // goes to input class to redefine text variable
                    text = input.manualTextInput();
                    Console.Clear();
                    //prints out the text so the user can see what they wrote
                    Console.WriteLine(text);
                    // creates a list that has all the processed text in it
                    List<int> sorted_text = analyse.analyseText(text);
                    // prints out the information about the text as a whole e.g number of sentenes used, capital letters used. (not counting each letter)
                    report.reportOutput(sorted_text);
                    // creates a dictonary that will hold the indivdual letters after it has been process through the text_letters class
                    Dictionary<char, int> counted_text = analyse.text_letters(text);
                    //prints out the dictonary
                    report.Print_Dictionary(counted_text);
                    // asks the user if they want a long text file 
                    Console.WriteLine("do you want a long text file y/n");

                    string LongText = Console.ReadLine();

                    // checks if the user chose y
                    if (LongText.ToLower() == "y")
                    {
                        longWord.LongWordChoice(text);
                        //Console.Clear();
                        //Writes a report of long words to LongWords.txt
                        //List<string> longWords = analyse.text_LongWords(text);
                        //processes the longwords list writes it into a file
                        //report.WriteToFile(longWords, "LongWords.txt");
                        //Console.WriteLine("Long words have been written to: LongWords.txt");
                    }
                }
                // checks if option 2 is selectd
                if (Option == "2")
                {
                    // clears console
                    Console.Clear();
                    Console.WriteLine(" 2: File Input chosen");
                    // defines text as the file input 
                    text = input.fileTextInput("./TestFile.txt");
                    Console.WriteLine("");
                    Console.WriteLine("Input read from file:");
                    Console.WriteLine("----------");
                    Console.WriteLine(text);
                    Console.WriteLine("----------");
                    Console.WriteLine("");

                    // creates a list that has all the processed text in it 
                    List<int> sorted_text = analyse.analyseText(text);
                    report.reportOutput(sorted_text);
                    // creates a dictonary that will hold the indivdual letters after it has been process through the text_letters class
                    Dictionary<char, int> counted_text = analyse.text_letters(text);
                    //prints out the dictonary
                    report.Print_Dictionary(counted_text);
                    // asks the user if they want a long text file 
                    Console.WriteLine("do you want a long text file y/n");
                    
                    string LongWordFileChoice = Console.ReadLine();
                    while (LongWordFileChoice != "y" && LongWordFileChoice != "n" )
                       
                           LongWordFileChoice = Console.ReadLine();

                    if (LongWordFileChoice.ToLower() == "y")
                    {
                        longWord.LongWordChoice(text);
                        //Write report of long words to LongWords.txt
                        //List<string> longWords = analyse.text_LongWords(text);
                        //processes the longwords list writes it into a file
                        //report.WriteToFile(longWords, "LongWords.txt");
                        //Console.Clear();
                        //Console.WriteLine("Long words have been written to: LongWords.txt");
                    }
                    
                    
                    


                }

                Console.Clear();

            }



        }



    }
}
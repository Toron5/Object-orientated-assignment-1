using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_Assessment_1_Base_Code
{
    class Start
    {

        public string UserInput()
        {
            
        // Asks the User what option they want to choose
            Console.WriteLine("Pick a number: \n ---------------------- \n 1. Do you want to enter the text via the keyboard? \n 2. Do you want to read in the text from a file?\n 3: Quit \n ----------------------");
            string Option = Console.ReadLine();
            // reads the option and defines it 

            try
            {
                if (Option != "1" && Option != "2" && Option != "3")
                {
                    throw new InvalidInputException(Option);
                }

                return Option;
            }
            catch (Exception ex)
            {
                Console.WriteLine("invalid choice try again",ex.Message);

                return UserInput();

            }
            
            while (Option != "1" && Option != "2" && Option != "3" )
            {
                // if there isn't a valid input it will loop untill there is
                Console.WriteLine("Incorrect Input try again \nPick a number: \n---------------------- \n 1.Do you want to enter the text via the keyboard ? \n 2.Do you want to read in the text from a file?\n 3: Quit \n----------------------");              
                Option = Console.ReadLine();
            }
                // returns the value    
                return Option;
            



            
          
        }


    }
}

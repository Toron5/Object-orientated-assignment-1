using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_Assessment_1_Base_Code
{
    class Start
    {

        public string UserInput(string Option)
        {
        // Asks the User what option they want to choose
            Console.WriteLine("Pick a number:");
            Console.WriteLine("----------------------");
            Console.WriteLine(" 1: User Input\n 2: File Input\n 3: Quit");
            Console.WriteLine("----------------------");
        // reads the option and defines it 
        
            Option = Console.ReadLine();
            while (Option != "1" && Option != "2" && Option != "3" )
            {
                // if there isn't a valid input it will loop untill there is
                Console.WriteLine("Incorrect Input try again");
                Console.WriteLine(" 1: User Input\n 2: File Input\n 3: Quit");
                Option = Console.ReadLine();
            }
                // returns the value    
                return Option;
            



            
          
        }


    }
}

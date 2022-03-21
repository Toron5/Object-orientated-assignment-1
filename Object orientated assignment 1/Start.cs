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

            Console.WriteLine("Pick a number:");
            Console.WriteLine("----------------------");
            Console.WriteLine(" 1: User Input\n 2: File Input\n 3: Quit");
            Console.WriteLine("----------------------");
            Option = Console.ReadLine();
            //try
            //{
            //    if (Option != "1" && Option != "2" && Option != "3")
            //    {
            //        throw new IncorrectInputHandling(Option);
            //    }
            return Option;
            //}



            //catch (Exception ex)
            //{

            //    Console.WriteLine("'{0}' is not a valid choice. Please try again.", ex.Message);

            //    return UserInput();
            //}
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            //checks to see if the input ends with an *

            while(!text.EndsWith('*'))
            {
                // keeps adding on text untill it reads an *
                text = text + Console.ReadLine();
            }
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            text = File.ReadAllText(fileName);
            //Get text leading up to the first '*'
            text = text.Split('*')[0];
            // returns text back to the Program
            return text;
        }

    }
}
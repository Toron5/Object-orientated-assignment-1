using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                // Creates the different sections of the list
                values.Add(0);

            }
            // goes through tht efirst section of the list and counts for every sentence.
            for (int i = 0; i < input.Length; i++)
            {
                //Checks for a full stop or question mark or exclamation mark
                if (input[i] == '.' || input[i] == '?' || input[i] == '!')
                {
                    // Adds values to the 1st element of the list
                    values[0]++;
                }

            // Checks for a lower case vowel or an upper case vowel
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    // Adds the value to the 2nd element of the list 
                    values[1]++;
                }
                else if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
            // After it has checked for vowels it will check for any character that is inbetween A and Z both upper and lower case
                {
                    //Adds values to the 3rd element of the list
                    values[2]++;
                }
            //checks each character to see if it is upper case
                if (Char.IsUpper(input[i]))
                {
                    //Adds values to the 4th element of the list
                    values[3]++;
                }
             //checks each character to see if it is lower case
                else if (Char.IsLower(input[i]))
                {
                    //Adds values to the 5th element of the list
                    values[4]++;
                }
            }
            //returns the list back to the Program
            return values;
        }
        public Dictionary<char, int> text_letters(string input)
        {
            //Creates a dictonary that will count how many times a letter was used and record the letter and amount
            Dictionary<char, int> letters = new Dictionary<char, int>();

            // goes through every character in the text input
            foreach (char letter in input)
            {
                // checks to see if the character is in the dictonary
                if (!letters.ContainsKey(letter))
                {
                    // if it is not in the dictonary then it will create a new value and assign its number to 0 then add one 
                    letters.Add(letter, 0);
                }
                // if there is a match then the dictonary value will increment by one
                letters[letter]++;
            }
            // this will return the Dictonary to the Program
            return letters;
        }

        // this will check for long words by the length of 7 or more characters
        public List<string> text_LongWords(string text, int minLength = 7)
        {
            //creating a list to store the long words in to it can be made into a long words file
            List<string> longWords = new List<string>();

            // put a space between each of the words in the list making it legable
            List<string> words = text.Split(" ").ToList();
            //this will run through the entire input and check for large words
            foreach (string word in words)
            {
                //if the words length is bigger then the minimum length set it will be added to the list
                if (word.Length >= minLength)
                {
                    longWords.Add(word);
                }
            }

            // returns the long word list
            return longWords;
        }
    }
}
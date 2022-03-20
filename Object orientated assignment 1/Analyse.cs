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
                values.Add(0);

            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.' || input[i] == '?' || input[i] == '!')
                {
                    values[0]++;
                }


                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                {
                    values[1]++;
                }
                else if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                {
                    values[2]++;
                }
                if (Char.IsUpper(input[i]))
                {
                    values[3]++;
                }
                else if (Char.IsLower(input[i]))
                {
                    values[4]++;
                }
            }
            return values;
        }
        public Dictionary<char, int> countLetters(string input)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();

            //For each letter in the input, increment its count
            foreach (char letter in input)
            {
                if (!letters.ContainsKey(letter))
                {
                    letters.Add(letter, 0);
                }

                letters[letter]++;
            }

            return letters;
        }
        public List<string> extractLongWords(string text, int minLength = 7)
        {
            List<string> longWords = new List<string>();

            //Split text into list of words
            List<string> words = text.Split(" ").ToList();
            foreach (string word in words)
            {
                //If word length is at least minLength, add it to the long words list
                if (word.Length >= minLength)
                {
                    longWords.Add(word);
                }
            }

            return longWords;
        }
    }
}
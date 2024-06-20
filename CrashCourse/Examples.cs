using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    public class Examples
    {
        public Examples()
        {

            int number = 15; //Integers are whole numbers
            double money = 0.15; //You can use doubles when you're dealing with comma separated values

            string text = "this is some text";
            char letter = 'A'; //strings are made up of chars, the first char in 'text' is 't'

            bool isActive = false; //booleans are used to describe a true or false statement

            // && is AND
            // || is OR
            // ! is not true

            List<ActionItem> actionItems = new List<ActionItem>();
            //This is how you create a list that may contain ActionItems, note that right now the list is empty

            int[] numbers = { 1, 2, 3, 4, 5 };
            //This is how you make an integer array
            //the [] defines an array

            string[] letters = { "a", "b", "12351", "text" };
            //This is how you would define a string array for example

            Dictionary<int, ActionItem> actionDictionary = new Dictionary<int, ActionItem>();
            //This is how you define a dictionary. The first variable type (int) is used as a key, and the second variable type (ActionItem) is the pair
            //You can use dictionaries by using the key to look for a pair

            List<List<string>> Board = new List<List<string>>();
            //This is a 2-dimensional List
            //it has an X (the first list), and a Y (the second list), that are basically your Rows and Columns just like excel
            //Say for example you want to get the first string from the 4 row you could use: (whilst programming you start counting from 0)
            string foundString = Board[0][3];
            //The list is obviously empty so the program will throw an exception here, an index out of bounds exception

        
        }
        //This is a simple example of a function to add two numbers together
        //Note that the return type is an integer
        private int Add(int x, int y)
        {
            return x + y;   
        }

        //Here we add two strings together and return them as one.
        //Note that the return type is a string
        private string CombineTwoStringsTogether(string a, string b)
        {
            return a + b;
        }

        private static bool StringHasOnlyNumbers(string inputString)
        {
            // Check if the string is not empty and all characters are digits
            return !string.IsNullOrEmpty(inputString) && inputString.All(char.IsDigit);
        }

        private static int[] SolveFibonacciSequence(int length)
        {
            //If statements get executed when the value between the brackets is true
            if (length <= 0)
            {
                return new int[0];
            }

            int[] fibonacci = new int[length];
            if (length > 0)
            {
                fibonacci[0] = 0;
            }
            if (length > 1)
            {
                fibonacci[1] = 1;
            }

            //This is a classic for loop (int i = 2) defines and integer named 'i' that starts with a value of 2
            //i < length is the condition for the for loop, as long as this is true it will execute the code
            //i++ increments the integer 'i' with 1 everytime the code in the for loop is executed
            for (int i = 2; i < length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            return fibonacci;
        }

        private static int[] SolveFibonacciSequence_Alt(int length)
        {
            if (length <= 0)
            {
                return new int[0];
            }

            int[] fibonacci = new int[length];

            if (length > 0)
            {
                fibonacci[0] = 0;
            }

            if (length > 1)
            {
                fibonacci[1] = 1;
            }

            //A while loop does effectively the same as a for loop, it will execute the code in it only while the condition is true
            int index = 2;
            while (index < length)
            {
                fibonacci[index] = fibonacci[index - 1] + fibonacci[index - 2];
                index++;
            }

            return fibonacci;
        }



    }
}

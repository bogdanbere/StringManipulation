using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StringManipulation
{
    internal class StringToManipulate
    {
        public string UserString { get; set; }

        /// <summary> a method to ask users if they want to continue performing operations on the same string </summary>
        /// <param name="enteredString"> the string that the user enters </param>
        public void ContinueMethod(string enteredString)
        {
            string continueString;
            char continueChar;

            Console.WriteLine("Do you want to continue? (Y/N)");
            continueString = Console.ReadLine();
            continueChar = char.Parse(continueString);
            if (char.ToUpper(continueChar) == 'Y')
            {
                StringManipulationSwitch(enteredString);
            }
        }
        
        /// <summary>Switch method for the menu</summary>
        /// <param name="enteredString"> enteredString is the string that the user enters </param>
        /// <param name="userInput">Gets what user entered as a string</param>
        /// <param name="userInputChar">Converts userInput to char and uses the value to select from the switch menu</param>        

        public void StringManipulationSwitch(string enteredString)
        {
            Console.Write("Chose an operation for your string by entering a number, or enter Q to quit.\n" +
               "1. Convert string to uppercase\n" +
               "2. Reverse the string\n" +
               "3. Count the number of vowels in the string\n" +
               "4. Count the number of words in a string\n" +
               "5. Convert string to title case\n" +
               "6. Check if the string is a palindrome\n");
            string userInput = Console.ReadLine();
            char userInputChar = char.Parse(userInput);
            if (userInputChar == 'q')
                userInputChar = 'Q';
            switch (userInputChar)
            {
                case '1': // string to uppercase
                    Console.WriteLine("Uppercase string: {0}.", enteredString.ToUpper());

                    ContinueMethod(enteredString);
                    break;


                case '2': // reverse string by parsing to char array and using the reverse method
                    char[] charString = enteredString.ToCharArray();
                    Array.Reverse(charString);
                    Console.WriteLine("Reversed string: {0}.", new string(charString));

                    ContinueMethod(enteredString);
                    break;

                case '3': // count the vowels using the Contains method
                    int vowelsCounter = 0;
                    enteredString.ToLower();
                    if (enteredString.Contains("a") || enteredString.Contains("e") || enteredString.Contains("i") || enteredString.Contains("o") || enteredString.Contains("u"))
                    {
                        vowelsCounter++;
                    }
                    Console.WriteLine("Your string has {0} vowels.", vowelsCounter);

                    ContinueMethod(enteredString);
                    break;


                case '4': // count the number of words by counting the white spaces between them
                    int counter = 1, i = 0;
                    while (i <= enteredString.Length)
                    {
                        if (enteredString[i] == ' ' || enteredString[i] == '\n' || enteredString[i] == '\t')
                        {
                            counter++;
                        }
                        i++;
                    }
                    Console.WriteLine("Your string has {0} words.", counter);

                    ContinueMethod(enteredString);
                    break;

                case '5': // string to title case by using totitle case method from system.globalization
                    TextInfo text = CultureInfo.CurrentCulture.TextInfo;
                    Console.WriteLine("Your string to title case: {0}.", text.ToTitleCase(enteredString));

                    ContinueMethod(enteredString);
                    break;

                case '6': // checks if string is palindrome by comparing the letters of the string 
                    string lowString = enteredString.ToLower();
                    bool isPalindrome = true;
                    for (int j = 0; j < lowString.Length / 2; j++)
                    {
                        if (lowString[j] != lowString[lowString.Length - 1 - j])
                            isPalindrome = false;
                    }
                    Console.WriteLine(isPalindrome ? "Your string is a palindrome." : "Your string is not a palidnrome");

                    ContinueMethod(enteredString);
                    break;

                case 'Q': // Quit program
                    break;

                default: // Asks user to select a valid menu item and calls the method again
                    Console.WriteLine("Please select a valid menu item.");

                    StringManipulationSwitch(enteredString);
                    break;

            }
        }
    }
}

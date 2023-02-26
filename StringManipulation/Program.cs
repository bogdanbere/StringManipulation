namespace StringManipulation
{
    class Program
    {
        static void Main()
        {
            /// <summary>A program to perform multiple operations on a user entered string</summary>
            /// <param name="stringToManupulate.UserString">Stores the user entered string</param>
            /// <returns>The result of the operation chosen by the user from the switch menu. Checks if string is empty and asks user to enter a valid string if empty</returns>
            StringToManipulate stringToManipulate = new StringToManipulate();
            Console.WriteLine("Enter a string:");
            stringToManipulate.UserString = Console.ReadLine();
            if (string.IsNullOrEmpty(stringToManipulate.UserString))
            {
                Console.WriteLine("String can not be empty. Please enter a string:");
                stringToManipulate.UserString = Console.ReadLine();
            }

            stringToManipulate.StringManipulationSwitch(stringToManipulate.UserString);
        }
    }
}

using System;

namespace PROGRAM1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Ask the user for input
                Console.Write("Enter an Integer value between 1 and 20 to execute an iterative statement: ");
                /*
                   Use the try catch block to validate user input.
                   If the user provides bad input, the catch block
                   will handle the error and a message will be displayed.
                */
                try
                {
                    // This variable will gather data from user input
                    string input = Console.ReadLine();
                    // This variable will be used to perform the various iterative statements and is parsed as an integer
                    int value_of_input = int.Parse(input);
                    /* 
                       This conditional IF/ELSE IF/ELSE statement is used to test the values of user input.
                       Depending on the value of the user input between 1 and 20, a different type of 
                       iterative statement will execute. 
                    */
                    // If the value of user input is between 1 and 5, execute a For Loop
                    if ((value_of_input > 0) && (value_of_input <= 5))
                    {
                        Console.WriteLine("Executing a For Loop!");
                        Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times.");
                        // Here is the For Loop
                        for (int i = 0; i < value_of_input; i++)
                        {
                            Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                        }
                        Console.WriteLine("Press any key to exit the program ...");
                        // Pause the program and await the user to press a key to end the program
                        Console.ReadKey(true);
                    }
                    // If the value of user input is between 6 and 10, execute a While Loop
                    else if ((value_of_input > 5) && (value_of_input <= 10))
                    {
                        Console.WriteLine("Executing a While Loop!");
                        Console.WriteLine("The While Loop will iterate " + value_of_input.ToString() + " times.");
                        // Here is the While Loop
                        while (value_of_input > 0)
                        {
                            Console.WriteLine("The value of the iterative variable is: " + value_of_input.ToString());
                            value_of_input--;
                        }
                        Console.WriteLine("Press any key to exit the program ...");
                        Console.ReadKey(true);
                    }
                    // If the value of user input is between 11 and 20, execute a Do While Loop
                    else if ((value_of_input > 10) && (value_of_input <= 20))
                    {
                        Console.WriteLine("Executing a Do While Loop!");
                        Console.WriteLine("The Do While Loop will iterate " + value_of_input.ToString() + " times.");
                        // Here is the Do While Loop
                        do
                        {
                            Console.WriteLine("The value of the iterative variable is: " + value_of_input.ToString());
                            value_of_input--;
                        } while (value_of_input > 0);
                        Console.WriteLine("Press any key to exit the program ...");
                        Console.ReadKey(true);
                    }
                    // If the user does not enter a value between 1 and 20, display a message
                    else
                    {
                        Console.WriteLine("Please enter an integer between 1 and 20 and try again ...");
                        Console.WriteLine("Press any key to exit the program and try again ...");
                        Console.ReadKey(true);
                    }
                } // End of try
                catch
                {
                    Console.WriteLine("Please enter an integer value and try running the program again ...");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                } // End of catch
            }
    }
}

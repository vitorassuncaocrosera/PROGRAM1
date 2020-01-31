/*
 Author: Vitor Assuncao Crosera
 Date: 1/28/2020
 Comments: This C# Console application code demonstrates the use of 
           conditional statements after getting input from users
*/
using System;

namespace PROGRAM1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("What grade do you expect to get in ISM 4300 from 1 to 100?");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather the user input
                string input = Console.ReadLine();
                
                // This variable will be used to calculate the grade 
                decimal grade = decimal.Parse(input);
                                
                if ((grade >= 98) && (grade <=100))
                {
                    //grade A+
                    Console.WriteLine("Your Letter grade will be A+");
                    


                }
                else if ((grade >= 92) && (grade <= 97))
                {
                    //grade A
                    Console.WriteLine("Your Letter grade will be A");
                }
                else if ((grade >= 90) && (grade <= 91))
                {
                    //grade A-
                    Console.WriteLine("Your Letter grade will be A-");
                }
                else if ((grade >= 88) && (grade <= 89))
                {
                    //grade B+
                    Console.WriteLine("Your Letter grade will be B+");
                }
                else if ((grade >= 82) && (grade <= 87))
                {
                    //grade B
                    Console.WriteLine("Your Letter grade will be B");
                }
                else if ((grade >= 80) && (grade <= 81))
                {
                    //grade B-
                    Console.WriteLine("Your Letter grade will be B-");
                }
                else if ((grade >= 78) && (grade <= 79))
                {
                    //grade C+
                    Console.WriteLine("Your Letter grade will be C+");
                }
                else if ((grade >= 72) && (grade <= 77))
                {
                    //grade C
                    Console.WriteLine("Your Letter grade will be C");
                }
                else if ((grade >= 70) && (grade <= 71))
                {
                    //grade C-
                    Console.WriteLine("Your Letter grade will be C-");
                }
                else if ((grade >= 68) && (grade <= 69))
                {
                    //grade D+
                    Console.WriteLine("Your Letter grade will be D+");
                }
                else if ((grade >= 62) && (grade <= 69))
                {
                    //grade D
                    Console.WriteLine("Your Letter grade will be D");
                }
                else if ((grade >= 60) && (grade <= 61))
                {
                    //grade D-
                    Console.WriteLine("Your Letter grade will be D-");
                }
                else if ((grade < 60) && (grade >= 0))
                {
                    //grade F
                    Console.WriteLine("Your Letter grade will be F");
                }
                else
                {
                    // error message display
                    Console.WriteLine("Enter number between 1 and 100");
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // end of catch     
        } // end of Main
    } // end of class
} // end of namespace
        
    


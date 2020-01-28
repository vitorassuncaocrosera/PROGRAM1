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
                /* 
                   This variable will be used to store sales
                   after the input variable is parsed to decimal
                 */
                // This variable will be used to calculate the bonus
                decimal grade = decimal.Parse(input);
                /* 
                    This IF/ELSE IF/ELSE statement is used to conditionally
                    test the users input. Various options are available
                    depending on the amount entered by the user. Then, insde of each IF/ELSE IF/ELSE
                    there is a switch conditional statement that displays a message depending
                    on the number of years experience in sales entered by the user. 
                 */
                if (grade >= 98)
                {

                    Console.WriteLine("Your Letter grade will be A+");
                    // Now get the number of years the user has been in sales


                }
                else if ((grade >= 92) && (grade <= 97))
                {
                    Console.WriteLine("Your Letter grade will be A");
                }
                else if ((grade >= 90) && (grade <= 91))
                {
                    Console.WriteLine("Your Letter grade will be A-");
                }
                else if ((grade >= 88) && (grade <= 89))
                {
                    Console.WriteLine("Your Letter grade will be B+");
                }
                else if ((grade >= 82) && (grade <= 87))
                {
                    Console.WriteLine("Your Letter grade will be B");
                }
                else if ((grade >= 80) && (grade <= 81))
                {
                    Console.WriteLine("Your Letter grade will be B-");
                }
                else if ((grade >= 78) && (grade <= 79))
                {
                    Console.WriteLine("Your Letter grade will be C+");
                }
                else if ((grade >= 72) && (grade <= 77))
                {
                    Console.WriteLine("Your Letter grade will be C");
                }
                else if ((grade >= 70) && (grade <= 71))
                {
                    Console.WriteLine("Your Letter grade will be C-");
                }
                else if ((grade >= 68) && (grade <= 69))
                {
                    Console.WriteLine("Your Letter grade will be D+");
                }
                else if ((grade >= 62) && (grade <= 69))
                {
                    Console.WriteLine("Your Letter grade will be D");
                }
                else if ((grade >= 60) && (grade <= 61))
                {
                    Console.WriteLine("Your Letter grade will be D-");
                }
                else if (grade < 60)
                {
                    Console.WriteLine("Your Letter grade will be F");
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please use a decimal data type for your sales amount next time...");
                Console.WriteLine("--- OR ---");
                Console.WriteLine("Please use an integer data type for your number of years in sales next time ...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // end of catch     
        } // end of Main
    } // end of class
} // end of namespace
        
    


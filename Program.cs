using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for expected grade
            Console.WriteLine("What grade do you expect to earn from ISM 4300?");
            // try catch block to validate user input
            try
            {
                //user input as string
                string input = Console.ReadLine();
                //parse string input to decimal
                decimal grade = decimal.Parse(input);

                //default grade to F
                string letter = "F";

                //asssigning letter to given expected grade based on syllabus
                if (grade >= 98)
                {
                    letter = "A+";
                }
                else if (grade >= 92)
                {
                    letter = "A";
                }
                else if (grade >= 90)
                {
                    letter = "A-";
                }
                else if (grade >= 88)
                {
                    letter = "B+";
                }
                else if (grade >= 82)
                {
                    letter = "B";
                }
                else if (grade >= 80)
                {
                    letter = "B-";
                }
                else if (grade >= 78)
                {
                    letter = "C+";
                }
                else if (grade >= 72)
                {
                    letter = "C";
                }
                else if (grade >= 70)
                {
                    letter = "C-";
                }
                else if (grade >= 68)
                {
                    letter = "D+";
                }
                else if (grade >= 62)
                {
                    letter = "D";
                }
                else if (grade >= 60)
                {
                    letter = "D-";
                }

                if (grade >= 90)
                {
                    Console.WriteLine("So you are expected to earn an " + letter + " for the course.");
                }
                else
                {
                    Console.WriteLine("So you are expected to earn a " + letter + " for the course");
                }

                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please use a decimal data type for your expected grade next time...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }
    }
}

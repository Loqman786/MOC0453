using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Mohammed Loqman 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("              BMI by Mohammed Loqman                        ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            BMI converter = new BMI();
            DistanceConverter distance=new DistanceConverter();
            StudentGrades studentGrades = new StudentGrades();
            Console.WriteLine("Distance Converter (1)");
            Console.WriteLine("BMI (2)");
            Console.WriteLine("Student Marks (3)");

            Console.Write(" Use the numbers >");

            string choice = Console.ReadLine();



            if (Double.TryParse(choice, out double option))

            {

                option = Convert.ToDouble(choice);

                if (option == 1)

                {

                    distance.Run();

                }

                else if (option == 2)

                {

                    converter.Main();

                }

                else if (option == 3)

                {

                    studentGrades.Run();

                }

                else

                {

                    Console.WriteLine("That was not an option");

                }

            }

            else

            {

                Console.WriteLine(" pick number to pick your choice ");

            }


        }
    }
}

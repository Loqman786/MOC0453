﻿using System;



namespace ConsoleAppProject.App01

{

    /// <summary>

    /// This app does distance conversions between six diffrent units (to and from) being meters, kilometers, nanometers, miles, feet and inches

    /// </summary>

    /// <author>

    /// Mohammed Loqman

    /// </Me>

    public class DistanceConverter

    {

        private double inputvalue;



        private double outputvalue;



        private double middleLength;



        private string inputvalue;



        private string outputvalue;



        /// <summary>

        /// This will run the distance converter

        /// </summary>

        public void Run()

        {

            OutputHeading();

            InputUnits();

            InputLength();

            ConvertToMeters();

            ConvertFromMeters();

            OutputLength();



        }



        /// <summary>

        /// outputs a heading

        /// </summary>

        private void OutputHeading()

        {

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("          App02 BMI Cnvertor         ");

            Console.WriteLine("            By Mohammed Loqman             ");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine(" Which unit do you want to convery (hurry up):");

            Console.WriteLine("      Weight, Stones, Pounds,");

            Console.WriteLine("            Kilograms,Height

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");

        }



        /// <summary>

        /// input units that will be used

        /// </summary>

        private void InputUnits()

        {

            Console.Write(" enter the units you want to convert from > ");

            iI = Console.ReadLine();

            Console.Write(" enter the units you want to convert to > ");

            O = Console.ReadLine();

        }



        /// <summary>

        /// User inputs length that will be used 

        /// </summary>

        private void InputLength()

        {

            Console.Write(" enter " + iI + " to Convert to " + O + " NOW > ");

            string value = Console.ReadLine();

            if (Double.TryParse(value, out I))

            {

                I = Convert.ToDouble(value);

                if (I < 0)

                {

                    Console.WriteLine(" enter a correct value ");

                    InputLength();

                }

            }

            else

            {

                Console.WriteLine(" enter a correct value ");

                InputLength();

            }

        }



        /// <summary>

        /// This converts unit to meters

        /// </summary>

        private void ConvertToMeters()

        {

            ///meters to meters

            if (iI.Equals("meters", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = I;

            }

            ///meters to feet

            else if (iI.Equals("feet", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = I * 0.3048;

            }

            ///meters to kilometers

            else if (iI.Equals("kilometers", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = I * 1000;

            }

            ///meters to miles

            else if (iI.Equals("miles", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = I * 1609.35;

            }

            ///meters to inches

            else if (iI.Equals("inches", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = I * 0.0254;

            }

            ///meters to nanometers

            else if (iI.Equals("nanometers", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = I * 0.000000001;

            }

            else

            {

                O = 0;

            }

        }



        /// <summary>

        /// Converts units from meters

        /// </summary>

        private void ConvertFromMeters()

        {

            ///meters to feet

            if (O.Equals("feet", StringComparison.CurrentCultureIgnoreCase))

            {

                O = middleLength * 3.280839895;

            }

            ///meters to meters

            else if (O.Equals("meters", StringComparison.CurrentCultureIgnoreCase))

            {

                O = middleLength;

            }

            ///meters to kilometers

            else if (O.Equals("kilometers", StringComparison.CurrentCultureIgnoreCase))

            {

                O = middleLength * 0.001;

            }

            ///meters to miles

            else if (O.Equals("miles", StringComparison.CurrentCultureIgnoreCase))

            {

                O = middleLength * 0.0006213689;

            }

            ///meters to inches

            else if (O.Equals("inches", StringComparison.CurrentCultureIgnoreCase))

            {

                O = middleLength * 39.37007874;

            }

            ///meters to nanometers

            else if (O.Equals("nanometers", StringComparison.CurrentCultureIgnoreCase))

            {

                O = middleLength * 1000000000;

            }

        }



        /// <summary>

        /// Gives you the results

        /// </summary>

        private void OutputLength()

        {

            if (O == 0 && I != 0)

            {

                Console.WriteLine("Error Invalid Input");

                InputUnits();

                OutputLength();

            }

            else

            {

                Console.WriteLine(" " + I + " " + iI + " is " + O + " " + O);

            }

        }

    }

}








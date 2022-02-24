using System;

 

namespace ConsoleAppProject.App01

{

    /// <summary>

    /// This app does distance conversions between six diffrent units (to and from) being meters, kilometers, nanometers, miles, feet and inches

    /// </summary>

    /// <author>

    /// Mohammed Loqman

    /// </author>

    public class DistanceConverter

    {

        private double inputLength;



        private double outputLength;



        private double middleLength;



        private string inputUnit;



        private string outputUnit;



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

            Console.WriteLine("          App01 Distance Converter         ");

            Console.WriteLine("            By Mohammed Loqman             ");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine(" Which unit do you want to convery (hurry up):");

            Console.WriteLine("      Nanometers, Inches, Miles, Feet     ");

            Console.WriteLine("            Kilometers and Meters          ");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");

        }



        /// <summary>

        /// input units that will be used

        /// </summary>

        private void InputUnits()

        {

            Console.Write(" enter the units you want to convert from > ");

            inputUnit = Console.ReadLine();

            Console.Write(" enter the units you want to convert to > ");

            outputUnit = Console.ReadLine();

        }



        /// <summary>

        /// User inputs length that will be used 

        /// </summary>

        private void InputLength()

        {

            Console.Write(" enter " + inputUnit + " to Convert to " + outputUnit + " NOW > ");

            string value = Console.ReadLine();

            if (Double.TryParse(value, out inputLength))

            {

                inputLength = Convert.ToDouble(value);

                if (inputLength < 0)

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

            if (inputUnit.Equals("meters", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = inputLength;

            }

            ///meters to feet

            else if (inputUnit.Equals("feet", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = inputLength * 0.3048;

            }

            ///meters to kilometers

            else if (inputUnit.Equals("kilometers", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = inputLength * 1000;

            }

            ///meters to miles

            else if (inputUnit.Equals("miles", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = inputLength * 1609.35;

            }

            ///meters to inches

            else if (inputUnit.Equals("inches", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = inputLength * 0.0254;

            }

            ///meters to nanometers

            else if (inputUnit.Equals("nanometers", StringComparison.CurrentCultureIgnoreCase))

            {

                middleLength = inputLength * 0.000000001;

            }

            else

            {

                outputLength = 0;

            }

        }



        /// <summary>

        /// Converts units from meters

        /// </summary>

        private void ConvertFromMeters()

        {

            ///meters to feet

            if (outputUnit.Equals("feet", StringComparison.CurrentCultureIgnoreCase))

            {

                outputLength = middleLength * 3.280839895;

            }

            ///meters to meters

            else if (outputUnit.Equals("meters", StringComparison.CurrentCultureIgnoreCase))

            {

                outputLength = middleLength;

            }

            ///meters to kilometers

            else if (outputUnit.Equals("kilometers", StringComparison.CurrentCultureIgnoreCase))

            {

                outputLength = middleLength * 0.001;

            }

            ///meters to miles

            else if (outputUnit.Equals("miles", StringComparison.CurrentCultureIgnoreCase))

            {

                outputLength = middleLength * 0.0006213689;

            }

            ///meters to inches

            else if (outputUnit.Equals("inches", StringComparison.CurrentCultureIgnoreCase))

            {

                outputLength = middleLength * 39.37007874;

            }

            ///meters to nanometers

            else if (outputUnit.Equals("nanometers", StringComparison.CurrentCultureIgnoreCase))

            {

                outputLength = middleLength * 1000000000;

            }

        }



        /// <summary>

        /// Gives you the results

        /// </summary>

        private void OutputLength()

        {

            if (outputLength == 0 && inputLength != 0)

            {

                Console.WriteLine("check your spelling");

                InputUnits();

                OutputLength();

            }

            else

            {

                Console.WriteLine(" " + inputLength + " " + inputUnit + " is " + outputLength + " " + outputUnit);

            }

        }

    }

}








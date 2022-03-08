using System;



namespace ConsoleAppProject.App01

{

    /// <summary>

    /// This app does distance conversions between six diffrent units (to and from) being meters, kilometers, nanometers, miles, feet and inches

    /// </summary>

    /// <author>

    /// Mohammed Loqman

    /// </Me>

    public class BMI Converter : BMIConverterBase

    {

        private double inputvalue;



        private double outputvalue;



        private double middleLength;



        private string inputvalue;



        private string outputvalue;



        /// <summary>

        /// This will run the BMI Convertor

        /// </summary>

        public void Run()

        {

            OutputHeading();

            Inputheight();

            InputWeight();

            ConvertToFeet();

            ConvertFromStones();

            OutputStones();



        }

        private void ConvertFromStones()
        {
            throw new NotImplementedException();
        }



        /// <summary>

        /// outputs a heading

        /// </summary>

        private void BMIconvertor()

        {

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
                
            Console.WriteLine("          App02 BMI Cnvertor               ");

            Console.WriteLine("            By Mohammed Loqman             ");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine(" Which unit do you want to convery (hurry up):");

            Console.WriteLine("      Weight, Stones, Pounds,");

            Console.WriteLine("            Kilograms,Height");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");

        }



        /// <summary>

        /// input units that will be used

        /// </summary>

        private void InputHeight()

        {

            Console.Write(" enter the Height you want to convert from");

            iI = Console.ReadLine();
            
            Console.Write(" enter the Unit want to convert to> ");

            O = Console.ReadLine();

        }

        Console.Write(" enter " + iI + " to Convert to " + O + " NOW > ");

            string value = Console.ReadLine();

            if private string iI;

        (Double.TryParse(value, out I))

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

        /// Converts units from matrix

        /// </summary>

        private void ConvertFromMatrix()

        {

            ///Stone to feet

            if (O.Equals("feet", StringComparison.CurrentCultureIgnoreCase))

            {

                O = middleLength * 3.280839895;

            }

            ///Height to Weight

            else if (O.Equals("Height", StringComparison.CurrentCultureIgnoreCase))

            {

                O = middleLength;

            }

            ///Stones to kilograms

            else if (O.Equals("kilograms", StringComparison.CurrentCultureIgnoreCase))

            {

                O = middleLength * 0.001;

            }

            ///Stones

            else if (O.Equals("Stones", StringComparison.CurrentCultureIgnoreCase))

            {

                O = middleLength * 0.0006213689;

            }

            ///Feet

            else if (O.Equals("Feet", StringComparison.CurrentCultureIgnoreCase))

            {

                O = middleLength * 39.37007874;

            }

    ///Height

    else if (O.Equals("Height", StringComparison.CurrentCultureIgnoreCase))

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








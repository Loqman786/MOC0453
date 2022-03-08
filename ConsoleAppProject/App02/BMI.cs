namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app will allow student to enter their weight in 
    /// </summary>
    /// <author>
    /// Mohammed Loqman version 0.1
    /// </author>
    public class BMI
    {
        public const string METRIC = "METRIC";
        public const string IMPERIAL = "IMPERIAL";

        public double weight;
        public double height;

        public string SelectedUnit;

        public double bmiResult = 0;

        public string[] MenuChoices = { METRIC, IMPERIAL };

        public void OutputUnits()
        {
            Console.WriteLine("Please choose between: ");
            ConsoleHelper.OutputMenu(MenuChoices);
        }
        public string GetUnit()
        {
            SelectedUnit = System.Console.ReadLine().ToUpper();
            return SelectedUnit;
        }

        public double GetWeight()
        {
            if (SelectedUnit == METRIC)
            {
                System.Console.WriteLine("Please enter the weight in kgs:");
            }
            else
            {
                System.Console.WriteLine("enter the weight in Stones:");
                System.Console.WriteLine("enter the weight in Pounds:");
            }
            weight = System.Convert.ToDouble(System.Console.ReadLine());
            return weight;
        }

        public double GetHeight()
        {
            if (SelectedUnit == METRIC)
            {
                System.Console.WriteLine("Please enter the height in cms:");
            }
            else
            {
                System.Console.WriteLine("Please enter the height in Feet:");
                System.Console.WriteLine("Please enter the height in Inches:");
            }
            height = System.Convert.ToDouble(System.Console.ReadLine());
            return height;
        }

        public void CalculateBMI()
        {
            if (SelectedUnit == METRIC)
            {
                bmiResult = (weight / height / height) * 10000;
            }
            bmiResult = System.Math.Floor(bmiResult);
        }

        public string GetBMICategory()
        {
            if (bmiResult < 18.5)
                return "Underweight";
            else if (bmiResult <= 24.9)
                return "Normal";
            else if (bmiResult <= 29.9)
                return "Overweight";
            else if (bmiResult <= 34.9)
                return "Obese";
            return "35.0...";
        }

        public void OutputResult()
        {
            System.Console.WriteLine(SelectedUnit + " " + bmiResult + " " + GetBMICategory());
        }



    }
}
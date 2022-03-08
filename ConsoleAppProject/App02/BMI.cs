using System;

class BMI
    {
    private double bmi;
    private double weight, height;
    static void Main(string[] args)
    {
        BMI myBmi = new BMI();
        myBmi.getDetails();
        myBmi.calcBMI();
        myBmi.showBMI();
    }

    private void getDetails()
    {
        Console.Write("Enter your weight "); 
        weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height "); 
        height = double.Parse(Console.ReadLine());
    }

    private double calcBMI()
    {
        bmi = weight / height; 
        return bmi;
    }

    private void showBMI()
    {
        Console.Write("Your bmi value is : " + bmi);
        if (bmi < 18.5)
        {
            Console.Write("Underweight ");
        }
        else if (bmi > 18.5 && bmi <= 25)
        {
          Console.Write("Desirable weight for size "); 
        }
        else if (bmi > 25 && bmi <= 30)
        {
            Console.Write("Overweight ");
        }
        else if (bmi > 30 && bmi <= 40)
        {
            Console.Write("Obese ");
        }
        else if (bmi > 40)
        {
            Console.Write("Severly Obese ");
        }
        Console.ReadLine();
    }
}

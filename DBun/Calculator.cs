using System;
using System.IO.Pipelines;
using Microsoft.Win32.SafeHandles;
namespace DBun
{
    public class Calculator
    {
        public static double Evaluate()
        {
            while(true)
            {
                Messages.Calculator();
                double number;
                double number2;
                System.Console.WriteLine("Please enter a value");
                bool isValid = double.TryParse(Console.ReadLine() ?? "" ,out number);
                System.Console.WriteLine("Please enter a second value");
                bool isValid2 = double.TryParse(Console.ReadLine()?? "", out number2);
                if (isValid == true && isValid2 == true)
                {  
                    Console.WriteLine("Please enter an operator (+, -, *, /)");
                    string? op = Console.ReadLine();
                    double resultplus = number + number2;
                    double resultminus = number - number2;
                    double resultm = number - number2;
                    double resiltminus = number - number2; 
                    double resultdiv = number / number2;
                    double resultmult = number * number2;
                    switch(op)
                    {
                        case "+":
                        System.Console.WriteLine($"Result: {number + number2}");
                        return resultplus;
                        case "-":
                        //System.Console.WriteLine($"Result: {1}", number - number2);
                        System.Console.WriteLine($"Result: {number - number2}");
                        return resultminus; ;
                        case "*":
                        System.Console.WriteLine($"Result: {number * number2}");
                        return resultmult;
                        case "/":
                        System.Console.WriteLine($"Result: {number / number2}");
                        if (number2 != 0)
                        {
                            System.Console.WriteLine($"Result: {number / number2}");
                            return resultdiv;
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        break;
                        }
                        default:
                        Console.WriteLine("Invalid operator. Please enter one of the following: +, -, *, /");
                        break;
                    }
                }
                else
                {
                    System.Console.WriteLine("Not woring");
                }
                return Evaluate();
        }
        }
    }
}
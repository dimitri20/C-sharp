using System;

namespace calcDavaleba
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculator();
            //checkEven();
        }

        static void calculator()
        {

            string num1;
            string num2;
            string operation;

            Console.WriteLine("Type 'q' to quit or click ctrl+c");

            while (true)
            { 
                Console.Write("first number:  ");
                num1 = Console.ReadLine();
                Console.Write("operacia:  ");
                operation = Console.ReadLine();
                Console.Write("second number:  ");
                num2 = Console.ReadLine();

                if (num1 == "q" || num2 == "q" || operation == "q")
                {
                    break;
                }

                try
                {
                    Console.WriteLine(calculate(Convert.ToDouble(num1), Convert.ToDouble(num2), operation));
                    Console.ReadLine();
                } catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                
            }
        }

        static double calculate(double number1, double number2, string operation)
        {

            double answer = 0;
            switch (operation)
            {
                case "+":
                    answer = add(number1, number2);
                    break;
                case "-":
                    number2 = -number2;
                    answer = add(number1, number2);
                    break;
                case "*":
                    answer = multiply(number1, number2);
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        number2 = 1 / number2;
                        answer = multiply(number1, number2);
                    }
                    break;

                default:
                    break;
            }

            return answer;
        }

        static double add(double firstNum, params double[] arr)
        {
            double val = firstNum;
            foreach (int i in arr)
            {
                val += i;
            }
            return val;
        }

        static double multiply(double firstNum, params double[] arr)
        {
            double val = firstNum;
            foreach (int i in arr)
            {
                val *= i;
            }
            return val;
        }
    }
}

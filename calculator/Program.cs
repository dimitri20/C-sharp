using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operation:  ");
            string operation = Console.ReadLine();

            Console.Write("Enter Second Number: ");
            double second = Convert.ToDouble(Console.ReadLine());

            double answer = 0;
            bool isZero = false;

            if(operation == "+"){
                answer = first + second;
            } else if(operation == "-"){
                answer = first - second;
            } else if (operation == "*"){
                answer = first * second;
            } else if(operation == "/"){
                if(second != 0){
                    answer = first/second;
                    isZero = false;
                } else {
                    isZero = true;
                }
            }

            if(isZero){
                Console.WriteLine("You cannot divide by zero");
            } else {
                Console.WriteLine("{0} {1} {2} = {3} ", first, operation, second, answer);
            }

        }
    }
}

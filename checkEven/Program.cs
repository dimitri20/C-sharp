using System;

namespace checkEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            string input = Console.ReadLine();
            int convertedInput = Convert.ToInt32(input);
            if(convertedInput % 2 == 0){
                Console.WriteLine("even");
            } else if(convertedInput % 2 == 1){
                Console.WriteLine("odd");
            }
        }
    }
}

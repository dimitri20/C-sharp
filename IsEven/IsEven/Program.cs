using System;

namespace IsEven
{
    class Program
    {
        static void Main(string[] args)
        {
            checkEven();
        }

        static void checkEven()
        {
            Console.Write("Enter Number: ");
            string input = Console.ReadLine();
            try
            {
                if (Convert.ToInt32(input) % 2 == 0)
                {
                    Console.WriteLine("it's even");
                }
                else
                {
                    Console.WriteLine("it's odd");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

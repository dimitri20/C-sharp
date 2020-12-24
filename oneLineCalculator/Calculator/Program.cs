using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calculateWithRecursion(convertInsideBracket("2+2+3+4-2-1"))); 
        }

        static double value1;

        static double calculateWithRecursion(List<string> lst, int i = 0)
        {
            try
            {
                value1 = calculate(Convert.ToDouble(lst[i]), Convert.ToDouble(lst[i + 2]), lst[i + 1]);
                lst.RemoveAt(i);
                lst.RemoveAt(i);
                lst.RemoveAt(i);
                lst = addToBeggining(lst, Convert.ToString(value1));
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                return value1;
            }

            return calculateWithRecursion(lst, 0);
        }

        static List<string> convertInsideBracket(string st)
        {
            st = removeSpaces(st);
            List<string> formatted = new List<string>();
            string temp = "";
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == '+' || st[i] == '-' || st[i] == '*' || st[i] == '/')
                {
                    formatted.Add(temp);
                    temp = "";
                    formatted.Add(Convert.ToString(st[i]));
                }
                else
                {
                    temp += st[i];
                }

            }
            formatted.Add(temp);
            return formatted;
        }

        static string removeSpaces(string st)
        {
            string convertedString = "";
            foreach (char ch in st)
            {
                if (ch != ' ')
                {
                    convertedString += ch;
                }
            }
            return convertedString;
        }
        static List<string> addToBeggining(List<string> arr, string st)
        {
            List<string> arr1 = new List<string>();
            arr1.Add(st);
            foreach (string s in arr)
            {
                arr1.Add(s);
            }

            return arr1;
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

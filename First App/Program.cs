using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
            string action;
            string another;
            bool innerloop = true;
            bool exit = false;
            Console.WriteLine("Welcome to the calculator!\n");
            while (!exit)
            {
                Console.WriteLine("Please Enter The First Number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter Second Number");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What would you like to do?\na - Add\ns - Subtract\nm - Multiply\nd - Divide");
                action = Console.ReadLine();
                switch (action.ToLower())
                {
                    case "a":
                        num3 = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {num3}");
                        break;

                    case "s":
                        num3 = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {num3}");
                        break;

                    case "m":
                        num3 = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = {num3}");
                        break;

                    case "d":
                        num3 = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {num3}");
                        break;
                }

                Console.WriteLine("Would you like to do another?\nYes/No");
                while (innerloop)
                {
                    another = Console.ReadLine();
                    another.ToLower();
                    Console.WriteLine(another);
                    if (another != "yes" && another != "no")
                    {
                        Console.WriteLine("Please Enter a Valid Response");
                    }
                    else
                    {
                        if(another == "no")
                        {
                            Console.WriteLine("Goodbye");
                            exit = true;
                        }
                        innerloop = false;
                    }
                }     
            }
        }
    }
}

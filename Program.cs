using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double FirstValue, SecondValue;
                string Action;

                try
                {
                    Console.WriteLine("Write FirstValue");
                    FirstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Select an Action: '+' '-' '*' '/' '%' ");
                    Action = Console.ReadLine();

                    Console.WriteLine("Write SecondValue");
                    SecondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Unknown Value");
                    Console.ReadLine();
                    continue;
                }

                switch (Action)
                {
                    case "+":
                        Console.WriteLine($"{"AddValue"} {'='} {FirstValue + SecondValue}");
                        break;

                    case "-":
                        Console.WriteLine($"{"SubValue"} {'='} {FirstValue - SecondValue}");
                        break;

                    case "*":
                        Console.WriteLine($"{"MulValue"} {'='} {FirstValue * SecondValue}");
                        break;

                    case "/":
                        if (SecondValue == 0)
                            Console.WriteLine("Cannot be divided by 0");
                        else
                            Console.WriteLine($"{"DivValue"} {'='} {FirstValue / SecondValue}");
                        break;

                    case "%":
                        Console.WriteLine($"{"RestValue"} {'='} {FirstValue % SecondValue}");
                        break;

                    default:
                        Console.WriteLine("Unknown Action");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcServiceAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorService service = new CalculatorService();

            Console.WriteLine("Enter params for calculation in (operation) (x) (y) format:");
            Console.WriteLine("e.g. add 3 2");
            string input = Console.ReadLine();

            do
            {
                string[] parts = input.Split(' ');

                string result = service.Calc(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                Console.WriteLine(result);
            }
            while ((input = Console.ReadLine()) != "");
        }
    }
}

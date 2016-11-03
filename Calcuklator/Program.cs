using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcuklator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Provide first value:");
            var firstvalue = int.Parse(Console.ReadLine());
            Console.WriteLine("Provide second value:");
            var secondvalue = int.Parse(Console.ReadLine());

            Calculator calcul = new Calculator(firstvalue, secondvalue);

            Console.WriteLine("Provide operation:");
            Console.WriteLine("1 - addition(+)");
            Console.WriteLine("2 - subtraction(-)");
            Console.WriteLine("3 - multiplication(*)");
            Console.WriteLine("4 - division(/)");
            var operation = int.Parse(Console.ReadLine());
            var result = 0;
            switch (operation)
            {
                case 1:
                    
                    result = calcul.Add();
                    break;

                case 2:
                    result = calcul.Sub();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("This operation is not supported");
                    break;

            }
            Console.WriteLine("Result:" + result);
            //Console.WriteLine("Result:" + result);
            Console.ReadKey();

        }
    }
}

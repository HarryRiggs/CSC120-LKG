using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base10ToBase8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 8;
                decimalNumber /= 8;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Octal base 8: {0}", result);
            Console.ReadLine();


        }
    }
}

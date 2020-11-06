using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office.CustomUI;

namespace Week1_DecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var decimalNumber = 345790;

            var characterArray = decimalNumber.ToString().ToCharArray();

            foreach(var item in characterArray);

                    Console.WriteLine(items);
        }
    }
}

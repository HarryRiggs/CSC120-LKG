using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new List<IdentityInputB>
            {
                new IdentityInputB(){X=false,Y= false},
                new IdentityInputB(){X=false, Y=true},
                new IdentityInputB(){X=true, Y=false},
                new IdentityInputB(){X=true, Y= true}
            };
            foreach (var item in inputs)
            {
                var identity = new IdentityB
                {
                    SetInputX = item.X,
                    SetInputY = item.Y
                };
                var output = identity.Validate();
                Console.WriteLine($"X={identity.SetInputX}," + $"Y={identity.SetInputY}," + $"Output=({output}),");

            }
        }
    }
}

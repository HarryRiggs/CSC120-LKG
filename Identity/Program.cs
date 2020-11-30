using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PartA
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = new List<IdentityInput>
            {   new IdentityInput() { A = false, D = false, X = false },
                new IdentityInput() { A = false, D = false, X = true },
                new IdentityInput() { A = false, D = true, X = false },
                new IdentityInput() { A = false, D = true, X = true },
                new IdentityInput() { A = true, D = false, X = false },
                new IdentityInput() { A = true, D = true, X = false },
                new IdentityInput() { A = true, D = true, X = true }
            };

            foreach (var item in inputs)
            {
                var identity = new Identity
                {
                    SetInputD = item.D,
                    SetInputA = item.A,
                    SetInputX = item.X
                };

                var output = identity.Validate();
                Console.WriteLine($"D={identity.SetInputD}," + $"A={identity.SetInputA}," + $"X={identity.SetInputX}," + $"Output ={ output},");

            }
        }
    }
}

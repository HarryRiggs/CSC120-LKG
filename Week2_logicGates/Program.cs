using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicCircuit.Gates.Simple;

namespace Week2_logicGates
{
    class Program
    {
        static void Main(string[] args)
        {
            var logicCircuit = new AND();

            logicCircuit.SetInputA(false);
            logicCircuit.SetInputB(false);
            var output = logicCircuit.Output.State;
            Console.WriteLine(output);


            logicCircuit.SetInputA(true);
            logicCircuit.SetInputB(false);
            var output1 = logicCircuit.Output.State;
            Console.WriteLine(output1);


            logicCircuit.SetInputA(false);
            logicCircuit.SetInputB(true);
            var output2 = logicCircuit.Output.State;
            Console.WriteLine(output2);


            logicCircuit.SetInputA(true);
            logicCircuit.SetInputB(true);
            var output3 = logicCircuit.Output.State;
            Console.WriteLine(output3);



            var logicCircuit1 = new NOT();

            logicCircuit1.SetInputA(false);
            var result00 = logicCircuit1.Output;
            Console.WriteLine(result00.State);

            logicCircuit1.SetInputA(true);
            var result01 = logicCircuit1.Output;
            Console.WriteLine(result01.State);


            var logicCircuit2 = new OR();

            logicCircuit2.Equals(false);
            var result1= logicCircuit2.Equals;
            Console.WriteLine(result1.State);

            logicCircuit2.Equals(false, true);
            var result2= logicCircuit2.Equals;
            Console.WriteLine(result2.State);

            logicCircuit2.Equals(true, false);
            var result3= logicCircuit2.Equals;
            Console.WriteLine(result3.State);

            logicCircuit2.Equals(true, true);
            var result4 = logicCircuit2.Equals;
            Console.WriteLine(result4.State);
        }



    }
}

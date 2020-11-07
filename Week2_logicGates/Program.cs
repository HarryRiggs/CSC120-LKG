using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicCircuit.Gates.Composite;
using LogicCircuit.Gates.Simple;

namespace Week2_logicGates
{
    class Program
    {
        public static void Main(string[]args)
        {
            OR1();
            OR2();
            OR3();
            OR4();

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
        }

        public static void OR1()
        {
            var tester = new OR();

            tester.SetInputA(false);
            tester.SetInputB(false);
            var result = tester.Output;
            Console.WriteLine(result.State);
        }
        public static void OR2()
        {
            var tester = new OR();
            tester.SetInputA(false);
            tester.SetInputB(true);
            var result = tester.Output;
            Console.WriteLine(result.State);
        }
        public static void OR3()
        {
            var tester = new OR();
            tester.SetInputA(true);
            tester.SetInputB(false);
            var result = tester.Output;
            Console.WriteLine(result.State);
        }
        public static void OR4()
        {
            var tester = new OR();
            tester.SetInputA(true);
            tester.SetInputB(true);
            var result = tester.Output;
            Console.WriteLine(result.State);
        }
        public static void NAND()
        {
            var norGate = new NOR();

        }
    }
}

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
        public static void Main(string[] args)
        {
            OR1();
            OR2();
            OR3();
            OR4();
            TestCaseMixed1();
            TestCaseMixed2();
            TestCaseMixed3();
            TestCaseMixed4();



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
        public static void TestCaseMixed1()
        {
            var myNandInput = new List<Input>();
            myNandInput.Add(new Input() { InputA = true, InputB = true });
            myNandInput.Add(new Input() { InputA = false, InputB = true });
            myNandInput.Add(new Input() { InputA = true, InputB = false });
            myNandInput.Add(new Input() { InputA = false, InputB = false });
            Console.WriteLine("NANDGate results");
            foreach (var i in myNandInput)
            {
                var nandGate = new NAND();
                nandGate.InputA.State = i.InputA;
                nandGate.InputB.State = i.InputB;
                var result = nandGate.Output.State;
                Console.WriteLine(result.ToString());
            }
        }
        public static void TestCaseMixed2()
        {
            var myNorInput = new List<Input>();
            myNorInput.Add(new Input() { InputA = true, InputB = true });
            myNorInput.Add(new Input() { InputA = false, InputB = true });
            myNorInput.Add(new Input() { InputA = true, InputB = false });
            myNorInput.Add(new Input() { InputA = false, InputB = false });
            Console.WriteLine("NORGate results");
            foreach (var i in myNorInput)
            {
                var norGate = new NOR();
                norGate.InputA.State = i.InputA;
                norGate.InputB.State = i.InputB;
                var result = norGate.Output.State;
                Console.WriteLine(result.ToString());
            }
        }
        public static void TestCaseMixed3()
        {
            var myXnorInput = new List<Input>();
            myXnorInput.Add(new Input() { InputA = true, InputB = true });
            myXnorInput.Add(new Input() { InputA = false, InputB = true });
            myXnorInput.Add(new Input() { InputA = true, InputB = false });
            myXnorInput.Add(new Input() { InputA = false, InputB = false });
            Console.WriteLine("XNORGate results");
            foreach (var i in myXnorInput)
            {
                var xnorGate = new XNOR();
                xnorGate.InputA.State = i.InputA;
                xnorGate.InputB.State = i.InputB;
                var result = xnorGate.Output.State;
                Console.WriteLine(result.ToString());
            }
        }
        public static void TestCaseMixed4()
        {
        var myXorInput = new List<Input>();
            myXorInput.Add(new Input() { InputA = true, InputB = true });
            myXorInput.Add(new Input() { InputA = false, InputB = true });
            myXorInput.Add(new Input() { InputA = true, InputB = false });
            myXorInput.Add(new Input() { InputA = false, InputB = false });
            Console.WriteLine("XORGate results");
            foreach(var i in myXorInput)
            {
                var xorGate = new XOR();
                xorGate.InputA.State = i.InputA;
                xorGate.InputB.State = i.InputB;
                var result = xorGate.Output.State;
                Console.WriteLine(result.ToString());
            }
        }

    }
}

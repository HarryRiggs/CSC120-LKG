using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicCircuit.Gates.Composite;
using LogicCircuit.Gates.Simple;

namespace PartB
{
    class IdentityB
    {
        public bool SetInputX { get; set; }
        public bool SetInputY { get; set; }

        public bool Validate()
        {
            var result = true;

            var or = new OR();
            var and = new AND();
            var not = new NOT();
            var nor = new NOR();
            var nand = new NAND();
            var xnor = new XNOR();
            var xor = new XOR();

            or.SetInputA(SetInputX);
            or.SetInputB(SetInputY);
            var outputFromOR = or.Output.State;
            not.SetInputA(outputFromOR);
            result = not.Output.State;

            //and.SetInputA(SetInputX);
            //and.SetInputB(SetInputY);
            //var outputFromAND = and.Output.State;
            //not.SetInputA(outputFromAND);
            //result = not.Output.State;

            xnor.XNOR(SetInputX);

            //not.SetInputA(SetInputX);
            //var xnot = not.Output.State;
            //not.SetInputA(SetInputY);
            //var xxnot = not.Output.State;
            //or.SetInputA(xnot);
            //or.SetInputB(xxnot);
            //result = or.Output.State;

            //not.SetInputA(SetInputX);
            //var xnot = not.Output.State;
            //not.SetInputA(SetInputY);
            //var xxnot = not.Output.State;
            //and.SetInputB(xnot);
            //and.SetInputB(xxnot);
            //var outPutFromand = and.Output.State;
            //not.SetInputA(SetInputX);
            //var Xnot = not.Output.State;
            //not.SetInputA(SetInputY);
            //var XXnot = not.Output.State;
            //or.SetInputB(Xnot);
            //or.SetInputB(XXnot);



            return result;
        }
    }
}

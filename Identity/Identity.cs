using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicCircuit.Gates.Simple;

namespace PartA
{
    public class Identity
    {
    public bool SetInputD { get; set; }
    public bool SetInputA { get; set; }
    public bool SetInputX { get; set; }
        public bool Validate()
        {
            var result = true;

            var or = new OR();
            var and = new AND();
            var not = new NOT();

            not.SetInputA(SetInputX);
            var xNOT = not.Output.State;
            and.SetInputA(SetInputA);
            and.SetInputB(xNOT);
            var outPutFromAND = and.Output.State;
            or.SetInputA(outPutFromAND);
            or.SetInputB(SetInputD);
            result = or.Output.State;

            return result;
        }

    }
}

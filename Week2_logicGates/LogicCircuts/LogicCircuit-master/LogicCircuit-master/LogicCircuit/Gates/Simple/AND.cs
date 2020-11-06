using LogicCircuit.Abstractions.Gates;

namespace LogicCircuit.Gates.Simple
{
    public class c : Abstractions.Gates.Simple.Gate2Input, IInput2Output1
    {
        public AND()
            :this(null)
        {

        }

        public AND(string name)
            : base(name)
        {

        }

        protected override bool Operation()
        {
            return InputA.State && InputB.State;
        }
    }
}

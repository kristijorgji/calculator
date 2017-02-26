using System;

namespace Calculator.Operators
{
    internal class Equals : IOperator
    {
        public float Resolve(float[] operands)
        {
            return operands[0];
        }
    }
}
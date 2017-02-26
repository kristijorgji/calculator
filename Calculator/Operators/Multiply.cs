using System;
using System.Linq;

namespace Calculator.Operators
{
    internal class Multiply : IOperator
    {
        public float Resolve(float[] operands)
        {
            return operands.Aggregate(1, (float a, float b) => a * b);
        }
    }
}
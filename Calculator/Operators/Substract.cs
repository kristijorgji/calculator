using System;

namespace Calculator.Operators
{
    internal class Substract : IOperator
    {
        public float Resolve(float[] operands)
        {
            float res = operands[0];
            for (int i = 1; i < operands.Length; i++)
            {
                res -= operands[i];
            }

            return res;
        }
    }
}
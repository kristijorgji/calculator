using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class Add : IOperator
    {
        public float Resolve(float[] operands)
        {
            return operands.Sum();
        }
    }
}

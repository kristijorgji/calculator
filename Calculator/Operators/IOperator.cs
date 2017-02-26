using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    interface IOperator
    {
        float Resolve(float[] operands);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    class OperandFactory
    {
        public IOperator Build(char operand)
        {
            switch(operand)
            {
                case '+':
                    return new Add();
                case '-':
                    return new Substract();
                case '*':
                    return new Multiply();
                case '\\': 
                    return new Divide();
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }
    }
}

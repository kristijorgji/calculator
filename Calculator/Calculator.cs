using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Operators;

namespace Calculator
{
    class Calculator
    {
        float currentResult = 0;
        Queue<char> inputs = new Queue< char >();
        Queue<Object> calculations = new Queue<Object>();
        readonly char[] allowedInputs = { '.', '+', '-', '*', '\\', '=', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        readonly char[] operands = { '+', '-', '*', '\\', '=' };

        public float GetResult()
        {
            return this.currentResult;
        }

        public void AddInput(char input)
        {
            if (!this.IsValidInput(input))
            {
                throw new ArgumentException(String.Format("The entered input is not allowed. Allowed values are: {0}", String.Join(" ", allowedInputs)));
            }

            if (IsOperand(input))
            {
                HandleOperation(input);
                return;
            }

            this.inputs.Enqueue(input);
        }

        void HandleOperation(char operand)
        {
            PushInputToCalculation();    
            ReduceCalculations();
            if (operand == '=')
            {
                currentResult = (float)calculations.Peek();
            }
            else
            {
                calculations.Enqueue(new OperandFactory().Build(operand));
            }
        }

        void PushInputToCalculation()
        {
            float inputValue = 0;
            int c = 0;
            bool foundDot = false;
            List<char> read = new List<char>();

            while (inputs.Count > 0)
            {
                char input = inputs.Dequeue();

                if (c++ == 0 && input == '.')
                    continue;

                if (input == '.' && foundDot == true)
                    continue;

                if (input == '.')
                    foundDot = true;

                read.Add(input);
                c++;
            }

            if (!float.TryParse(new String(read.ToArray()), out inputValue))
            {
                throw new Exception("An operation must be declared only after inputing the operands!");
            }

            calculations.Enqueue(inputValue);
        }

        void ReduceCalculations()
        {
            IOperator currentOperator = null;
            Queue<Object> localCalcs = new Queue<Object>(calculations);
            List<float> currentOperands = new List<float>();

            if (calculations.Peek() is IOperator)
            {
                throw new Exception("An operation must be declared only after inputing the operands!");
            }

            while (localCalcs.Count > 0)
            {
                var calcStackItem = localCalcs.Dequeue();

                if (calcStackItem is IOperator)
                {
                    currentOperator = (IOperator)calcStackItem;                 
                }
                else
                {
                    currentOperands.Add((float)calcStackItem);
                }
            }

            if (currentOperator != null)
            {
                calculations.Clear();
                calculations.Enqueue(currentOperator.Resolve(currentOperands.ToArray()));
            }
        }

        bool IsValidInput(char input)
        {
            if (!allowedInputs.Contains(input))
            {
                return false;
            }
             
            return true;
        }

        bool IsOperand(char input)
        {
            return operands.Contains(input);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] operands)
        {
            Calculator calc = new Calculator();
            calc.AddInput('1');
            calc.AddInput('.');
            calc.AddInput('2');
            calc.AddInput('+');
            calc.AddInput('3');
            calc.AddInput('=');

            if (calc.GetResult() != 4.2F)
                throw new Exception();

            calc = new Calculator();
            calc.AddInput('1');
            calc.AddInput('2');
            calc.AddInput('+');
            calc.AddInput('3');
            calc.AddInput('=');

            if (calc.GetResult() != 15F)
                throw new Exception();

            calc = new Calculator();
            calc.AddInput('1');
            calc.AddInput('2');
            calc.AddInput('+');
            calc.AddInput('3');
            calc.AddInput('1');
            calc.AddInput('=');

            if (calc.GetResult() != 43F)
                throw new Exception();


            calc = new Calculator();
            calc.AddInput('1');
            calc.AddInput('2');
            calc.AddInput('+');
            calc.AddInput('3');
            calc.AddInput('.');
            calc.AddInput('1');
            calc.AddInput('=');

            if (calc.GetResult() != 15.1F)
                throw new Exception();


            calc = new Calculator();
            calc.AddInput('1');
            calc.AddInput('2');
            calc.AddInput('+');
            calc.AddInput('3');
            calc.AddInput('1');
            calc.AddInput('-');
            calc.AddInput('2');
            calc.AddInput('=');

            if (calc.GetResult() != 41F)
                throw new Exception();


            calc = new Calculator();
            calc.AddInput('1');
            calc.AddInput('2');
            calc.AddInput('*');
            calc.AddInput('1');
            calc.AddInput('0');
            calc.AddInput('\\');
            calc.AddInput('2');
            calc.AddInput('=');

            if (calc.GetResult() != 60F)
                throw new Exception();

            calc = new Calculator();
            calc.AddInput('0');
            calc.AddInput('2');
            calc.AddInput('+');
            calc.AddInput('4');
            calc.AddInput('=');

            if (calc.GetResult() != 6F)
                throw new Exception();
        }
    }
}

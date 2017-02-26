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

            Tests tests = new Tests();

            try
            {
                tests.AdditionTest();
                tests.AdditionTwoDigitTest();
                tests.AdditionTwoDigitsBothSidesTest();
                tests.AdditionFloatTest();
                tests.AdditionSubstractionTogetherTest();
                tests.MultiplyAndDivideTest();
                tests.LeadingZeroTest();
            }
            catch(Exception e)
            {
                Console.WriteLine(String.Format("One test failed, Stack trace: {0}", e.StackTrace));
            }
        }
    }
}

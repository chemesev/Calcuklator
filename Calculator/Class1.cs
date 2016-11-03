using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public class Calculator
    {
        public Calculator()
        {

        }
        public Calculator(int value1, int value2)
        {
           Value1 = value1;
           Value2 = value2;

        }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Add()
        {
            return Value1 + Value2;
        }
        public int Sub()
        {
            return Value1 - Value2;
        }
    }
}
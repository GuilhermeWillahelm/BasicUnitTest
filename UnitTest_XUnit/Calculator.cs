using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_XUnit
{
    public class Calculator
    {
        public int Value { get; set; }

        public int Add(int number)
        {
            return Value += number;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorViewModel
    {
        public double DisplayValue { get; set; }

        public CalculatorViewModel()
        {
            DisplayValue = 0.0123;
        }
    }
}

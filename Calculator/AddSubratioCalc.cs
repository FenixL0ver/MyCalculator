using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class AddSubratioCalc:RatioCalc
    {
        public void Minus()
        {
            PerformOp();
            fCalcOp = () => fResult -= fOperand;
        }
    }
}

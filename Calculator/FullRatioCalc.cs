using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class FullRatioCalc:AddSubratioCalc
    {
        private bool flag = false;
        public override string ToString()
        {
            if (flag)
                return "ERROR";
            else
                return base.ToString();
        }
        public void Divide()
        {
            PerformOp();
            PerformOp();
            fCalcOp = () =>
            {
                if (fOperand == 0)
                {
                    flag = true;
                    return;
                }
                else
                    fResult /= fOperand;
            };
        }
        public void Multiply()
        {
            PerformOp();
            fCalcOp = () => fResult *= fOperand;
        }
    }
}

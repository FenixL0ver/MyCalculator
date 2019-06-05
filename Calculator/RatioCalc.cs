using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class RatioCalc: AddCalculator
    {
        private int fDigitsAfterDot;
        public void DecDot()
        {
            fDigitsAfterDot = 0;
            fLastCommand = Command.Dot;
            fLastButton = BtnType.ComB;
        }
        public override void Digit(int d)
        {
            if (fLastCommand == Command.Dot)
            {
                fDigitsAfterDot += 1;
                fOperand += d * Math.Pow(10, fDigitsAfterDot * (-1));
                fLastButton = BtnType.DigitB;
                fShowing = ShowNum.OperS;
            }
            else
                base.Digit(d);
        }
    }
}

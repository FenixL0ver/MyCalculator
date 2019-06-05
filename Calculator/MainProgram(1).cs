using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Calculator
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            var Calc= new AddCalculator();
            Calc.CE();
            Debug.Assert(Calc.ToString() == "0");
            Calc.Digit(5);
            Debug.Assert(Calc.ToString() == "5");
            Calc.Digit(2);
            Debug.Assert(Calc.ToString() == "52");
            Calc.Digit(4);
            Debug.Assert(Calc.ToString() == "524");
            Calc.CE();

            Calc.Digit(7);
            Calc.Plus();
            Calc.Digit(1);
            Calc.Result();
            Debug.Assert(Calc.ToString() == "8");
            Calc.Result();
            Debug.Assert(Calc.ToString() == "9");
            Calc.Result();
            Debug.Assert(Calc.ToString() == "10");
            Calc.CE();

            Calc.Digit(1);
            Calc.Plus();
            Calc.Digit(2);
            Calc.Plus();
            Calc.Digit(3);
            Calc.Result();
            Debug.Assert(Calc.ToString() == "6");

            var Ratio = new RatioCalc();
            Ratio.Digit(3);
            Ratio.DecDot();
            Ratio.Digit(2);
            Ratio.Plus();
            Ratio.Digit(1);
            Ratio.DecDot();
            Ratio.Digit(2);
            Ratio.Result();
            Debug.Assert(Ratio.ToString() == "4,4");

            var SubRat = new AddSubratioCalc();
            SubRat.Digit(5);
            SubRat.DecDot();
            SubRat.Digit(7);
            SubRat.Minus();
            SubRat.Digit(3);
            SubRat.DecDot();
            SubRat.Digit(1);
            SubRat.Result();
            Debug.Assert(SubRat.ToString() == "2,6");

            var FullCalc = new FullRatioCalc();
            FullCalc.Digit(6);
            FullCalc.Divide();
            FullCalc.Digit(2);
            FullCalc.Result();
            Console.WriteLine(FullCalc.ToString());
            FullCalc.CE();
            FullCalc.Digit(6);
            FullCalc.Divide();
            FullCalc.Digit(0);
            FullCalc.Result();
            Console.WriteLine(FullCalc.ToString());
            Console.ReadLine();
        }
    }
}

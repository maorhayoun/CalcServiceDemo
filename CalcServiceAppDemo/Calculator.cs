using MyCalcTestLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcServiceAppDemo
{
    public class CalculatorService
    {
        ICalcUtils _calcUtils;
        public CalculatorService()
            : this (new CalcUtils())
        {
        }

        public CalculatorService(ICalcUtils calcUtils)
        {
            _calcUtils = calcUtils;
        }

        public string Calc(string operation, int x, int y)
        {
            switch (operation)
            {
                case "add": return string.Format("result was: {0}", _calcUtils.Add(x, y));
                //case "sub": return string.Format("result was: {0}", _calcUtils.Subtract(x, y));

                default:
                    return "not a valid operation";
            }
        }
    }
}

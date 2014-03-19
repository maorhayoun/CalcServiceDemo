using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcTestLib;
using Rhino.Mocks;
using CalcServiceAppDemo;

namespace CalcServiceDemo.Tests
{
    [TestClass]
    public class CalcControllerTests
    {
        [TestMethod]
        public void CalculatorService_SmokeTest()
        {
            // mock utils inteface
            ICalcUtils utils = MockRepository.GenerateStub<ICalcUtils>();
            utils.Stub(x => x.Add(2, 2)).Return(4);

            CalculatorService calc = new CalculatorService(utils);
            Assert.AreEqual("result was: 4", calc.Calc("add", 2, 2));
        }
    }
}

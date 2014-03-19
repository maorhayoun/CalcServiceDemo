using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcTestLib;
using Rhino.Mocks;
using CalcServiceDemo.Controllers;

namespace CalcServiceDemo.Tests1
{
    [TestClass]
    public class CalcControllerTests
    {
        [TestMethod]
        public void GetAdd_SmokeTest()
        {
            // mock utils inteface
            ICalcUtils utils = MockRepository.GenerateStub<ICalcUtils>();
            utils.Stub(x => x.Add(2, 2)).Return(4);

            CalcController calc = new CalcController(utils);
            Assert.AreEqual("result was: 4", calc.GetAdd(2, 2));
        }
    }
}

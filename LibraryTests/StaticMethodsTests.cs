using Microsoft.VisualStudio.TestTools.UnitTesting;
using Meth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meth.Tests
{
    [TestClass()]
    public class StaticMethodsTests
    {
        [TestMethod()]
        public void CalcPlusShowTest()
        {
            // arrange
            var calc = new StaticMethods();

            // act
            var res = calc.CalcPlus(2, 5);

            // assert
            Assert.AreEqual(7, res);
        }
    }
}
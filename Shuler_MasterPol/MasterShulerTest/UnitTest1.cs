using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shuler_MasterPol.Services;
using Shuler_MasterPol.Models.Services;

namespace MasterPolUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// PKGH
        /// Проверка метода CalculateMaterialAmount.
        /// </summary>

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(MaterialManager.CalculateMaterialAmount(2, 3, 8, 1.4, 6.8), 393);
        }
    }
}

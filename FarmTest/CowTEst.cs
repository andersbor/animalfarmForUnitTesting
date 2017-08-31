using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmTest
{
    [TestClass]
    public class CowTest
    {
        private Cow ko;
        [TestInitialize]
        public void SetUpCow()
        {
            ko = new Cow();
        }
        [TestMethod]
        public void TestMethod1()
        {
            ko.Weight = 80;
            try
            {
                ko.Weight = 73;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            { }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestWeight()
        {
            ko.Weight = 73;
            Assert.AreEqual(73, ko.Weight);
        }
    }
}

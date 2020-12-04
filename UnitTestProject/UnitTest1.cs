using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRentalSys;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        Rental obj_main = new Rental();
        [TestMethod]
        public void MovieRentUnitTest1()
        {
            var actual = obj_main.year(3);
            Assert.AreEqual(expected: 5, actual);
        }

        [TestMethod]
        public void MovieRentUnitTest2()
        {
            var actual = obj_main.year(6);
            Assert.AreEqual(expected: 2, actual);
        }
    }
}

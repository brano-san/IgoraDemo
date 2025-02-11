using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestIgora
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestZeroDiscount()
        {
            var discount = DiscountCalculationLibrary.DiscountCalculation.calculateDiscount(10_000);
            Assert.AreEqual(discount, 0);
        }

        [TestMethod]
        public void TestOneDiscount()
        {
            var discount = DiscountCalculationLibrary.DiscountCalculation.calculateDiscount(50_000);
            Assert.AreEqual(discount, 1);
        }

        [TestMethod]
        public void TestThreeDiscount()
        {
            var discount = DiscountCalculationLibrary.DiscountCalculation.calculateDiscount(100_000);
            Assert.AreEqual(discount, 3);
        }

        [TestMethod]
        public void TestFiveDiscount()
        {
            var discount = DiscountCalculationLibrary.DiscountCalculation.calculateDiscount(500_000);
            Assert.AreEqual(discount, 5);
        }
    }
}

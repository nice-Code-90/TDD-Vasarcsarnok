using VasarcsarnokApp;

namespace VasarcsarnokTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEgyKilo()
        {
            Vasarcsarnok target = new Vasarcsarnok(200);
            double expected = 200;
            double actual = target.GetAlmaAr(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestOtKilo()
        {
            Vasarcsarnok target = new Vasarcsarnok(200);
            double expected = 900;
            double actual = target.GetAlmaAr(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNyolcKilo()
        {
            Vasarcsarnok target = new Vasarcsarnok(200);
            double expected = 1360; // 8 * 200 * 0.85 = 1360
            double actual = target.GetAlmaAr(8);
            Assert.AreEqual(expected, actual);
        }
    }
}
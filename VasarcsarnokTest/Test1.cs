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
    }
}
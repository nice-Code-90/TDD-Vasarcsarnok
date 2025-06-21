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
    }
}
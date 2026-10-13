using Tyuiu.KashinaVE.Sprint2.Task7.V14.Lib;

namespace Tyuiu.KashinaVE.Sprint2.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.2;
            double y = -0.8;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}

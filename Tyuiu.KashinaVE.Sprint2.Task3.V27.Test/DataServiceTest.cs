using Tyuiu.KashinaVE.Sprint2.Task3.V27.Lib;

namespace Tyuiu.KashinaVE.Sprint2.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConditional1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 1.491;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConditional2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.25;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConditional3()
        {
            DataService ds = new DataService();
            double x = -5;
            double res = ds.Calculate(x);
            double wait = 1.082;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConditional4()
        {
            DataService ds = new DataService();
            double x = -40;
            double res = ds.Calculate(x);
            double wait = -64040.834;
            Assert.AreEqual(wait, res);
        }
    }
}
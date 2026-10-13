using Tyuiu.KashinaVE.Sprint2.Task6.V10.Lib;

namespace Tyuiu.KashinaVE.Sprint2.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            string res1 = ds.FindDateOfPreviousDay(2023, 6, 15);
            Assert.AreEqual("14.06.2023", res1);

            string res2 = ds.FindDateOfPreviousDay(2023, 1, 1);
            Assert.AreEqual("31.12.2022", res2);
        }
    }
}

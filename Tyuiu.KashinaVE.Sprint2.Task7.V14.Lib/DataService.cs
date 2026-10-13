using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KashinaVE.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && ((y >= -x) || (x >= 0)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}

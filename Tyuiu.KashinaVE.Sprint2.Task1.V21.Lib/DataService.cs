using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KashinaVE.Sprint2.Task1.V21.Lib
{
    public class DataService : ISprint2Task1V21
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == c) ^ (b > d);
            res[1] = (a != b) && (c < d);
            res[2] = (a >= b) || (c <= d);
            res[3] = (a != c) & (b > d);
            res[4] = !(a != c) | (a > b);
            res[5] = (a <= d) & (c >= b);

            return res;
        }
    }
}

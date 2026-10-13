using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KashinaVE.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n > 1)
            {
                n = n - 1;
            }
            else
            {
                m = m switch
                {
                    1 => 12,
                    _ => m - 1
                };
                n = m switch
                {
                    2 => 28,
                    4 or 6 or 9 or 11 => 30,
                    _ => 31
                };

                if(m == 12)
                {
                    g = g - 1;
                }
            }
            return  $"{n:D2}.{m:D2}.{g}";

        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BelovaEA.Sprint3.TaskReview.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x!=2)
                {
                    y = Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + 2 * x;
                }
                else
                {
                    y = 0;
                }
                y = Math.Round(y, 2);
                
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}

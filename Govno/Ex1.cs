using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govno
{
        public class Ex1
        {
            double x = -15.246;
            double y = 4.642 * Math.Pow(10, -2);
            double z = 20.001 * Math.Pow(10, 2);
            
        /// <summary>
        /// Производит вычесления заданной функции.
        /// </summary>
        /// <returns>Возвращает ответ</returns>
            public double Solve()
            {
                double ans;
                return ans = Math.Log(Math.Pow(y, -1 * Math.Sqrt(Math.Abs(x)))) * (x - y / 2) + Math.Pow(Math.Sin(Math.Atan(z)), 2);
            }

            public override string ToString()
            {
                return $"Ответ {Solve():0.###}";
            }
        }
}

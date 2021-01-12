using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govno
{
    public class Ex2
    {
        double a;
        int n;
        double num;

        public Ex2(double a, int n)
        {
            this.a = a;
            this.n = n;
            this.num = a;
        }

        /// <summary>
        /// Перемножает число a, n раз.
        /// </summary>
        /// <returns></returns>
        public double Solve()
        {
            for (int i = 0; i < n; i++)
            {
                a = a * a;
            }
            return a;
        }

        public override string ToString()
        {
            return $"Число {num} перемноженное {n} раз:{Solve()}";
        }
    }
}

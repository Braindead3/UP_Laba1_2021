using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govno
{
    public class Ex3
    {
        int n;
        int k = 1;

        public Ex3(int n)
        {
            this.n = n;
        }


        /// <summary>
        /// Считает число , которое при возведении в квадрат будет меньше чем n.
        /// </summary>
        /// <returns></returns>
        public int Solve()
        {
            while (Math.Pow(k, 2) < n)
            {
                k++;
            }
            k--;
            return k;
        }

        public override string ToString()
        {
            return $"Наибольшее число,квадрат которого меньше чем {n}:{Solve()}";
        }
    }
}

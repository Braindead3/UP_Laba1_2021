using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govno
{
    public class Ex4
    {
        int leftBorder = 1000;
        int rightBorder = 9999;
        int num1 = 1000;


        /// <summary>
        /// Находит и выводит дружественные числа на отрезке от leftBorder до rightBorder.
        /// </summary>
        public void Solve()
        {
            int counter = 0;
            int num;
            int num1SumLeft, num1SumRight;
            while (num1 <= rightBorder)
            {
                num = num1;
                num1SumRight = num % 10;
                num = num / 10;
                num1SumRight += num % 10;
                num = num / 10;
                num1SumLeft = num % 10;
                num = num / 10;
                num1SumLeft += num % 10;
                num = num / 10;
                if (num1SumLeft == num1SumRight)
                {
                    if (counter == 20)
                    {
                        Console.WriteLine();
                        counter = 0;
                    }
                    Console.Write(num1 + " ");
                    counter++;
                }
                num1++;
            }
        }
    }
}

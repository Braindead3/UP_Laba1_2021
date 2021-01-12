using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Govno;

namespace UP_Laba1_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution1();
            Solution2();
            Solution3();
            Solution4();
            Solution5();

            Console.ReadLine();
        }

        private static void Solution5()
        {
            PerestanovkiHipa ex = new PerestanovkiHipa(1234);
            ex.Solve();
        }

        private static void Solution4()
        {
            Ex4 ex4 = new Ex4();
            ex4.Solve();
        }

        private static void Solution3()
        {
            Ex3 ex3 = new Ex3(45);
            Console.WriteLine(ex3);
        }

        private static void Solution2()
        {
            Ex2 ex2 = new Ex2(3.54, 6);
            Console.WriteLine(ex2);
        }

        private static void Solution1()
        {
            Ex1 ex1 = new Ex1();
            Console.WriteLine(ex1);
        }
    }
}

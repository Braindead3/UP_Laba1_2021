using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Govno
{
    public class PerestanovkiHipa
    {
        int num;
        int[] nums;
        List<string> permutations = new List<string>();
        char[] charArray;
        
        public PerestanovkiHipa(int num)
        {
            this.num = num;
            string str = Convert.ToString(num);
            nums = new int[str.Count()];
            int num1 = num;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = num1 % 10;
                num1 = num1 / 10;
            }
            Array.Reverse(nums);
            charArray = new char[nums.Count()];
            for (int i = 0; i < charArray.Count(); i++)
            {
                charArray[i] = Convert.ToChar(Convert.ToString(nums[i]));
            }
        }

        /// <summary>
        /// Метод перестановки,который заполняет список значениями.
        /// </summary>
        /// <param name="n">Кол-во элементов в колекции которые надо переставлять</param>
        /// <param name="charArray">Массив чаров,элементов которые надо переставлять</param>
        /// <param name="sList">Место для хранения результата</param>
        public void GenerateHeapPermutations(int n, char[] charArray, List<string> sList)
        {
            if (n == 1)
            {
                sList.Add(new string(charArray));
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    GenerateHeapPermutations(n - 1, charArray, sList);

                    int indexToSwapWithLast = (n % 2 == 0 ? i : 0);
                    // swap the positions of two characters
                    var temp = charArray[indexToSwapWithLast];
                    charArray[indexToSwapWithLast] = charArray[n - 1];
                    charArray[n - 1] = temp;
                }

                GenerateHeapPermutations(n - 1, charArray, sList);
            }
        }

        /// <summary>
        /// Заполняет и выводит список с новыми,комбинированными элементами.
        /// </summary>
        public void Solve()
        {
            GenerateHeapPermutations(nums.Count(), charArray, permutations);
            Console.WriteLine();
            Console.WriteLine("Перестановки:");
            foreach (var p in permutations)
            {
                Console.WriteLine(p);
            }
        }
    }
}

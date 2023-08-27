using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Algorithms
{
    public class Recursion
    {
        public Recursion() 
        {
            List<int> array = new() { 2, 4, 6, 10, 5, 12 };

            //Console.WriteLine(Sum(array));
            //Console.WriteLine(Count(array));
            Console.WriteLine(Max(array, array.First()));
        }

        int Sum(List<int> array) // рекурсия для суммы элементов в списке
        {
            if (array.Count == 0)
                return 0;
            else
            {
                var firstElem = array.First();
                array.RemoveAt(0);
                return firstElem + Sum(array);
            }
        }

        int Count(List<int> array) // рекурсивная функция для подсчета элементов в списке
        {
            if (!array.Any())
                return 0;
            else
            {
                array.RemoveAt(0);
                return 1 + Count(array);
            }
        }

        int Max(List<int> array, int max) // рекурсия для поиска наибольшего числа
        {
            if (array.Count == 1)
                return array.First();
            else
            {
                if (max <= array.Skip(1).First())
                {
                    max = array.Skip(1).First();
                    array.RemoveAt(0);
                }
                else
                    array.RemoveAt(1);
                return Max(array, max);
            }
        }
    }
}

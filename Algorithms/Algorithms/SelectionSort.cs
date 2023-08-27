using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Algorithms
{
    //O(n*n)
    public class SelectionSort
    {
        public SelectionSort() 
        {
            var array = new List<int>() { 5, 3, 6, 2, 10 };

            var sorted = SortSelection(array);

            Console.WriteLine(string.Join(", ", sorted));
        }

        private static int FindSmallest(List<int> array)
        {
            var smallest = array[0];
            var smallestIndex = 0;

            for (int i = 0; i < array.Count; i++) 
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        private static int[] SortSelection(List<int> array)
        {
            var result = new int[array.Count];
            
            for (int i = 0; i < result.Length; i++)
            {
                int smallest = FindSmallest(array);
                result[i] = array[smallest];
                array.RemoveAt(smallest);
            }
            return result;
        }
    }
}

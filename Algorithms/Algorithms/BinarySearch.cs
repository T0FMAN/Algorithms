using System.Collections.Generic;

namespace Algorithms.Algorithms
{
    public class BinarySearch
    {
        // O(log n)
        public BinarySearch()
        {
            int[] array = new int[] { 1, 2, 7, 9, 13 };

            var pos = Binary_search(array, 9);

            Console.WriteLine(pos);
        }

        static int? Binary_search(int[] array, int item)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = array[mid];

                if (guess == item)
                    return mid;
                if (guess > item)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return null;
        }
    }
}

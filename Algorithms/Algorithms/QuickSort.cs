using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Algorithms
{
    //O(n*logₙ)
    public class QuickSort
    {
        Random _random;
        public QuickSort() 
        {
            _random = new Random();
            var list = new List<int>() { 60, 2, 12, 44, 39, 6 };

            Sort(list, true).ForEach(x => Console.WriteLine(x));
        } 

        List<int> Sort(List<int> list, bool isMiddleCase)
        { 
            if (list.Count < 2)
                return list;
            else
            {
                int set;

                if (isMiddleCase) // Middle case: random element or middle of array
                    set = list[_random.Next(0, list.Count)];
                else // Worst case: Support element = firts element
                    set = list.First();

                var upper = list.Where(x => x >= set).ToList();
                var lower = list.Where(x => x < set).ToList();

                return Sort(lower, isMiddleCase).Union(new List<int>{set}).Union(Sort(upper, isMiddleCase)).ToList();
            }
        }
    }
}

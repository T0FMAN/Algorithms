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
        public QuickSort() 
        {
            var rand = new Random();
            var list = new List<int>();

            for (int i = 0; i < 5; i++)
                list.Add(rand.Next(10, 100));

            Sort(list, true).ForEach(x => Console.WriteLine(x));
        } 

        List<int> Sort(List<int> list, bool isMiddleCase)
        { 
            if (list.Count < 2)
                return list;
            else
            {
                var upper = new List<int>();
                var lower = new List<int>();

                var set = new List<int>();

                if (isMiddleCase)
                {
                    var rand = new Random();
                    set.Add(list[rand.Next(0, list.Count)]); // Middle case: random element or middle of array
                }
                else
                    set.Add(list[0]); // Worst case: Support element = firts element

                list.Remove(set[0]);

                foreach (var x in list)
                {
                    if (x >= set[0])
                        upper.Add(x);
                    else
                        lower.Add(x);
                }

                return Sort(lower, isMiddleCase).Union(set).Union(Sort(upper, isMiddleCase)).ToList();
            }
        }
    }
}

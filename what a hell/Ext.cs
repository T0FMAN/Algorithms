using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace what_a_hell
{
    public static class Ext
    {
        public static void Ret(this List<string> array)
        {
            array.Add("ds");
        }
    }
}

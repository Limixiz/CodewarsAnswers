using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata2
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            int count;
            foreach (var item in seq)
            {
                count = seq.Count(x => x == item);
                if (count % 2 != 0)
                {
                    return item;
                }
                
            }
            return -1;
        }
    }
}

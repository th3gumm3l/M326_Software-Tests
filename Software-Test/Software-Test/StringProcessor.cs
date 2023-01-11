using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Test
{
    public class StringProcessor
    {
        public int CountVowels(string s)
        {
            return s.Count(c => "aeiouAEIOU".Contains(c));
        }
    }

}
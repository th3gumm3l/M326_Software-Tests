using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Tests
{
    public class WordChecker
    {
        public bool IsPalindrome(string word)
        {
            return word.ToLower() == new string(word.ToLower().Reverse().ToArray());
        }
    }
}

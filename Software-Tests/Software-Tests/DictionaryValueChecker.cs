using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Tests
{
    public class DictionaryValueChecker
    {
        private readonly Dictionary<string, int> _dictionary;

        public DictionaryValueChecker(Dictionary<string, int> dictionary)
        {
            _dictionary = dictionary;
        }

        public int GetValue(string key)
        {
            return _dictionary[key];
        }
    }

}

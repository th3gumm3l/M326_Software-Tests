using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Tests
{
    public class PrimeChecker
    {
        public bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
                if (num % i == 0) return false;
            return true;
        }
    }
}

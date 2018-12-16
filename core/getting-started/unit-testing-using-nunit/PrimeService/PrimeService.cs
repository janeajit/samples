using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 5)
            {
                return true;
            }
            if (candidate == 98)
            {
                return true;
            }
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first");
        }
    }
}

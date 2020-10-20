using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab3
{
    class HashSumCounter
    {
        public static int sum = 0;

        public HashSumCounter() { }
        public static int Count(IEnumerable<int> sequence)
        {
            sequence.AsParallel().AsUnordered().ForAll(number =>
            {
                int initialValue, computedValue;
                do
                {
                    initialValue = sum;

                    computedValue = initialValue ^ number;
                }
                while (initialValue != Interlocked.CompareExchange(ref sum,
                    computedValue, initialValue));
            });

            return sum;
        }
    }
}

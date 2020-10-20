using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lab3
{

    class MinMaxWithIndexes
    {
        public int Min { get; set; } = int.MaxValue;
        public int MinIndex { get; set; }

        public int Max { get; set; } = int.MinValue;
        public int MaxIndex { get; set; }
    }
    class FindMinMax
    {
        public static int minIndex = 0;
        public static int maxIndex = 0;
        public static MinMaxWithIndexes FindMinMaxParallel(IList<int> sequence)
        {
            Enumerable.Range(0, sequence.Count())
                .AsParallel()
                .AsUnordered()
                .ForAll(index =>
                {
                    int oldValue;
                    int newValue;

                    // min
                    do
                    {
                        oldValue = minIndex;
                        newValue = index;

                        if (sequence[oldValue] <= sequence[newValue])
                        {
                            break;
                        }

                    } while (oldValue != Interlocked.CompareExchange(ref minIndex, newValue, oldValue));

                    // max
                    do
                    {
                        oldValue = maxIndex;
                        newValue = index;
                        if (sequence[oldValue] >= sequence[newValue])
                        {
                            break;
                        }

                    } while (oldValue != Interlocked.CompareExchange(ref maxIndex, newValue, oldValue));
                });

            return new MinMaxWithIndexes
            {
                MinIndex = minIndex,
                Min = sequence[minIndex],
                MaxIndex = maxIndex,
                Max = sequence[maxIndex]
            };

        }
    }
}
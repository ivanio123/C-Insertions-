using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if VALUE_IS_DOUBLE
	using ValueType = System.Double;
#else
#if VALUE_IS_SHORT
	using ValueType = System.Int16;
#else
#if VALUE_IS_LONG
	using ValueType = System.Int64;
#else
using ValueType = System.Int32;
#endif
#endif
#endif

namespace SortTest
{
    class StudSort
    {
        // You may add more method(s) here, if needed 
        // (f.e., for recursive quicksort or recursive mergesort)

        public static ValueType[] Sort(ValueType[] data) // DON'T CHANGE this line!!!
        {
            for (int i = 0; i < data.Length; i++)
            {
                ValueType key = data[i];
                int j;
                for (j = i - 1; j >= 0 && data[j] > key; j--)
                {
                    data[j + 1] = data[j];
                }
                data[j + 1] = key;
            }
            return data;
        }
    }
}

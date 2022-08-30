using System;
using System.Collections.Generic;
using System.Text;

namespace VSDevelopers.SlidingWindow
{
    public class MinSizeSubArray
    {
        public static int findMinSubArrayLen(int TargetSum, int[] arr)
        {
            int windowSum = 0;
            int minLengthSubarraysize = int.MaxValue;
            int windowStart = 0; int windowEnd = 0;
            for (windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd];
                while(windowSum >= TargetSum)
                {
                    minLengthSubarraysize = Math.Min(minLengthSubarraysize, windowEnd - windowStart + 1);
                    windowSum -= arr[windowStart]; 
                    windowStart++;
                }
            }
            return minLengthSubarraysize;
        }
    }
}

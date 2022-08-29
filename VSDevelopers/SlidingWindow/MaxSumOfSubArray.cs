using System;
using System.Collections.Generic;
using System.Text;

namespace VSDevelopers.SlidingWindow
{
    public class MaxSumOfSubArray
    {
        //Problem Statement#
        //Given an array of positive numbers and a positive number ‘k,’ find the maximum sum of any contiguous subarray of size ‘k’.
        //Input: [2, 1, 5, 1, 3, 2], k=3 
        //Output: 9
        //Explanation: Subarray with maximum sum is [5, 1, 3]

        public static int findMaxSumOfSubArray(int k, int[] arr)
        {
            int windowSum = 0, maxSum = 0;
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                windowSum += arr[windowEnd]; // add the next element
                                             // slide the window, we don't need to slide if we've not hit the required window size of 'k'
                if (windowEnd >= k - 1)
                {
                    maxSum = Math.Max(maxSum, windowSum);
                    windowSum -= arr[windowStart]; // subtract the element going out
                    windowStart++; // slide the window ahead
                }
            }
            return maxSum;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSDevelopers.LinkedList;
using VSDevelopers.SlidingWindow;

namespace TestVSDevelopers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLinkedList()
        {
            string[] words = { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            sentence.Display();
            int[] nums = { 2, 3, 5, 8 };
            LinkedList<int> numbers = new LinkedList<int>(nums);
            numbers.Display();
        }
        [TestMethod]
        public void TestfindMaxSumOfSubArray()
        {
            #region problem statement
            //Problem Statement# 
            //Given an array of positive numbers and a positive number ‘k,’ find the maximum sum of any contiguous subarray of size ‘k’.

            //Example 1
            //Input: [2, 1, 5, 1, 3, 2], k=3 
            //Output: 9
            //Explanation: Subarray with maximum sum is [5, 1, 3]

            // Example 2
            //Input: [2, 3, 4, 1, 5], k=2 
            //Output: 7
            //Explanation: Subarray with maximum sum is [3, 4]. 

            //Time Complexity : O(N), Space complexity: The algorithm runs in constant space O(1)
            #endregion
            System.Console.WriteLine($"Maximum sum of a subarray of size K: {MaxSumOfSubArray.findMaxSumOfSubArray(3, new int[] { 2, 1, 5, 1, 3, 2 })}");
            System.Console.WriteLine($"Maximum sum of a subarray of size K: {MaxSumOfSubArray.findMaxSumOfSubArray(2, new int[] { 2, 3, 4, 1, 5 })}");
        }
        [TestMethod]
        public void TestfindMinSizeSubArrayLen()
        {
            #region problem statement
            //Problem Statement:
            //Given an array of positive integers and a number ‘S,’ find the length of the smallest contiguous subarray whose sum is greater than or equal to ‘S’. Return 0 if no such subarray exists.

            //Examples:
            //arr[] = { 1, 4, 45, 6, 0, 19 }
            //   x = 51
            //Output: 3
            //Minimum length subarray is { 4, 45, 6 }

            //arr[] = { 1, 10, 5, 2, 7}
            //            x = 9
            //Output: 1
            //Minimum length subarray is { 10 }

            //arr[] = { 1, 11, 100, 1, 0, 200, 3, 2, 1, 250}
            //            x = 280
            //Output: 4
            //Minimum length subarray is { 100, 1, 0, 200 }

            //arr[] = { 1, 2, 4}
            //            x = 8
            //Output: Not Possible
            //Whole array sum is smaller than 8
            #endregion
            int result = MinSizeSubArray.findMinSubArrayLen(7, new int[] { 2, 1, 5, 2, 3, 2 });
            System.Console.WriteLine("Smallest subarray length: " + result);
            result = MinSizeSubArray.findMinSubArrayLen(8, new int[] { 3, 4, 1, 1, 6 });
            System.Console.WriteLine("Smallest subarray length: " + result);
            result = MinSizeSubArray.findMinSubArrayLen(8, new int[] { 2, 1, 5, 2, 3, 2 });
            System.Console.WriteLine("Smallest subarray length: " + result);
        }
    }
}

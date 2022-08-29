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
        public void TestfindMaxSumOfSubArray()
        {
            System.Console.WriteLine($"Maximum sum of a subarray of size K: {MaxSumOfSubArray.findMaxSumOfSubArray(3, new int[] { 2, 1, 5, 1, 3, 2 })}");
            System.Console.WriteLine($"Maximum sum of a subarray of size K: {MaxSumOfSubArray.findMaxSumOfSubArray(2, new int[] { 2, 3, 4, 1, 5 })}");
        }
    }
}

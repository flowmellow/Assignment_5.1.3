/* 
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

Example 1:
Input: nums = [1,2,3,1]
Output: true

Example 2:
Input: nums = [1,2,3,4]
Output: false

Example 3:
Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
*/

using System.Runtime.InteropServices;

namespace Assignment_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DuplicateCheck duplicateCheck = new DuplicateCheck();

            int[] numSet1 = { 1, 2, 3, 1 };
            int[] numSet2 = { 1, 2, 3, 4 };
            int[] numSet3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            Console.WriteLine(duplicateCheck.CheckDuplicates(numSet1));
            Console.WriteLine(duplicateCheck.CheckDuplicates(numSet2));
            Console.WriteLine(duplicateCheck.CheckDuplicates(numSet3));

            // Using the Dictionary Method for Set 1

            Dictionary<int, int> numbers1 = new Dictionary<int, int>();
            foreach (int number in numSet1)
            {
                if (numbers1.ContainsKey(number)) numbers1[number]++;
                else numbers1[number] = 1;
               
            }
            Console.WriteLine("Duplicate numbers in number set 1");

        }


        class DuplicateCheck
        {
            public bool CheckDuplicates(int[] nums)
            {

                if (nums.Length == 0)
                {
                    return false;
                }

                for (int i = 0; i < nums.Length; i++) // starts at index 0 until nested loop goes through remaining indexes then moves to index 1 if there is no true in if.
                    // Compares index 0 to 1,2,3....
                    // Compares inex 1 to 2,3....
                    // Compares index 2 to 3.....                
                {
                    for (int j = i + 1; j < nums.Length; j++) // iterates through indexes from 1 to n-1
                    {
                        if (nums[i] == nums[j]) 
                        {
                            return true;                           
                        }
                    }
                }
                return false;

            }
        }
    }
}

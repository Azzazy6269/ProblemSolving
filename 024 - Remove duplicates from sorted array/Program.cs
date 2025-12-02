
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
    }
}

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int pointer = 0;
        int numOfDublicates = 0;
        for (pointer = 1; pointer < nums.Length; pointer++)
        {
            if (nums[pointer] == nums[pointer - 1])
            {
                numOfDublicates++;
            }
            else
            {
                nums[pointer - numOfDublicates] = nums[pointer];
            }
        }
        return nums.Length - numOfDublicates;
    }
}
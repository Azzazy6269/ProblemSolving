using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] result = s.Intersection(new int[4] { 1, 2, 2, 1 }, new int[2] { 2, 2 });

        Console.WriteLine(string.Join(", ", result)); // Output: 2
    }
}

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        List<int> result = new List<int>();
        int i = 0, j = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] == nums2[j])
            {
                if (result.Count == 0 || result[result.Count - 1] != nums1[i])
                    result.Add(nums1[i]);

                i++;
                j++;
            }
            else if (nums1[i] < nums2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        return result.ToArray();
    }
}
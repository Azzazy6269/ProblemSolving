using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] n1 = new int[] { 1, 2, 3, 0, 0, 0 };
        int[] n2 = new int[] { 4, 5, 6 };
        s.Merge(n1, 3, n2, 3);
        foreach (int i in n1)
        {
            Console.WriteLine(i);
        }
    }
}

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (j >= 0)
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }
    }
}
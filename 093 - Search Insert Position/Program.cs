using System.Reflection.Metadata.Ecma335;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int min = 0;
        int max = nums.Length;
        int mid = 0;

        while(max > min)
        {
            mid = (max+min) / 2;
            if (nums[mid] >= target)
            {
                max = mid;
            }
            else
            {
                min = mid+1 ;
            }
        }
        return max;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.SearchInsert(new int[] { 1, 3, 5, 6 }, 3));
    }
}
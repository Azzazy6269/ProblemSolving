public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        Array.Sort(nums);
        return nums[nums.Length - k];
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}
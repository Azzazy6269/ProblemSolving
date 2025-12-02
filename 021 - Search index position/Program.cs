public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target || nums[i] > target)
            {
                return i;
            }
        }
        return nums.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
    }
}

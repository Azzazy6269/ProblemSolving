public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        bool firstfound = false;
        int[] indexes = [-1,-1];
        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                indexes[0] = i;
                firstfound = true;
                break;
            }
            
        }
        if (!firstfound)
            return [-1, -1];

        for (int i = nums.Length-1; i >= indexes[0]; i--)
        {
            if (nums[i] == target)
            {
                indexes[1] = i;
                break;
            }
        }
        return indexes;
    }
}

class Program
{
    static void Main(string[]args)
    {
        Solution s = new Solution();
        int[] nums = [5, 7, 7, 8, 8, 10];
        int[] res =(s.SearchRange(nums,8));
        foreach (int i in res)
            Console.WriteLine(i);
    }
}

using System.Reflection.Metadata.Ecma335;

public class Solution
{
    public int CountPairs(IList<int> nums, int target)
    {
        nums = nums.OrderBy(n => n).ToList();
        int count = 0;
        int i = nums.Count-1;
        int k = i-1;

        while ( i>0)
        {
            int x = nums[k] + nums[i];
            if (nums[k] + nums[i] < target)
            {
                count+= k+1;
                i--;
                k = i - 1;
            }
            else
            {
                k--;
                if(k < 0)
                {
                    i--;
                    k = i - 1;
                }
            }
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IList<int> numbers = new List<int> { -6, 2, 5, -2, -7, -1, 3 };
        Solution solution = new Solution();
        solution.CountPairs(numbers, -2);
    }
}
class Program
{
    public static void Main()
    {
        Test(new int[] { -1, 2, 1, -4 }, 1);
        Test(new int[] { 1, 1, 1, 0 }, 3);
        Test(new int[] { 2, 7, 11, 15 }, 20);
        Test(new int[] { -8, -6, -5, -3 }, -10);
        Test(new int[] { -3, -2, -5, 3, -4 }, -1);
        Test(new int[] { 0, 0, 0, 0 }, 1);
        Test(new int[] { 5, 1, 2, 7, 9 }, 100);
        Test(new int[] { 10, 22, 3, 1 }, -50);
        Test(new int[] { 1, 2, 3 }, 10);
        Test(new int[] { 1, 2, 4, 8, 16, 32 }, 13);
    }

    static void Test(int[] nums, int target)
    {
        Solution s = new Solution();
        int result = s.ThreeSumClosest(nums, target);
        Console.WriteLine($"nums = [{string.Join(", ", nums)}], target = {target} → result = {result}");
    }
}

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int closetSum = 0;
        bool isFirst=true;
        int closestDifference = 4001;
        int tempDifference;
        Array.Sort(nums);
        int left, right;
        //int CurrNum, leftNum, rightNum,
        int sum;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            left = i + 1;
            right = nums.Length - 1;
            while (left < right)
            {
                sum = nums[i] + nums[left] + nums[right];
                tempDifference = Math.Abs(sum-target);
                if (isFirst)
                {
                    isFirst = false;
                    closestDifference = tempDifference;
                    closetSum = sum;
                }
                if (tempDifference < closestDifference) 
                { 
                    closestDifference = tempDifference;
                    closetSum = sum;
                }
                if (tempDifference == 0)
                {
                    return sum;
                }
                else if (sum > target)
                {
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }

            }
        }
        return closetSum;
    }
}
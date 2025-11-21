public class Solution
{
    public int MaxArea(int[] height)
    {
        int left =0,right =height.Length-1;
        int maxArea = (right - left) * Math.Min(height[left], height[right]);
        int tempArea;
        while (right - left > 0)
        {
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
            tempArea = (right - left) * Math.Min(height[left], height[right]);
            if (maxArea < tempArea)
                maxArea = tempArea;
        }
        return maxArea;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));
    }
}
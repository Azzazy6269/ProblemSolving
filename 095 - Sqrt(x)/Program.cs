public class Solution
{
    public int MySqrt(int x)
    {
        int min = 0;
        int max = 46340;
        int mid = 0;
        int ans = 0;

        while (min <= max)
        {
            mid = min + (max - min) / 2;
            long square = mid * mid;
            if (square <= x)
            {
                min = mid + 1;
                ans = mid;
            }
            else
            {
                max = mid - 1;
            }
        }
        return ans;

    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        solution.MySqrt(8);
    }
}
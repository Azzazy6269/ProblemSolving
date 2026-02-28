public class Solution
{
    public int ShipWithinDays(int[] weights, int days)
    {
        int left = weights.Max();
        int right = weights.Sum();

        while (left < right) { 
            int mid = left + (right - left) / 2;
            if (IsFit(weights,days,mid))
            {
                right = mid;
            }
            else
            {
                left = mid+1;
            }
        }
        return left;
    }
    bool IsFit(int[] weights, int days, int mid)
    {
        int currentLoad = 0;
        int neededDays = 1;
        foreach (var weight in weights)
        {
            if (currentLoad+weight > mid)
            {
                neededDays++;
                currentLoad = 0;
            }
            currentLoad += weight;
        }
        return neededDays <= days;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        s.ShipWithinDays(new int[] { 3, 2, 2, 4, 1, 4 }, 3);
    }
}
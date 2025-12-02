
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] n1 = new int[] { 7, 1, 5, 3, 6, 4 };
        Console.Write(s.MaxProfit(n1));

    }
}

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int max_profit = 0;
        int min = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else if (prices[i] - min > max_profit)
            {
                max_profit = prices[i] - min;
            }
        }
        return max_profit;
    }
}
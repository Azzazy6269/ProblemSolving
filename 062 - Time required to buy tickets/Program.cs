public class Solution
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        int i = 0;
        int time = 0;
        while (true)
        {
            if (i == tickets.Length)
                i = 0;
            while (tickets[i] == 0)
            {
                i++;
                if (i == tickets.Length)
                    i = 0;
            }
            tickets[i]--;
            time++;
            if (i == k && tickets[i] == 0)
                break;
            i++;
        }
        return time;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        solution.TimeRequiredToBuy(new int[] { 5, 1, 1, 1 }, 0);
    }
}
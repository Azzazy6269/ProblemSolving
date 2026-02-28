class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        s.FindTheWinner(5, 2);
    }
}


public class Solution
{
    public int FindTheWinner(int n, int k)
    {
        Queue<int> q = new Queue<int>();
        for(int i = 1; i <= n; i++)
        {
            q.Enqueue(i);
        }
        while (q.Count > 1)
        {
            for (int j = 0; j < k - 1; j++)
            {
                q.Enqueue(q.Dequeue());
            }
            q.Dequeue();
        }
        
        return q.Dequeue();
    }
}
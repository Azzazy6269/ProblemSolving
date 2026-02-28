public class RecentCounter
{
    Queue<int> q;
    public RecentCounter()
    {
        q=new Queue<int>();
    }

    public int Ping(int t)
    {
        q.Enqueue(t);
        while(q.Peek() < t-3000)
            q.Dequeue();
        return q.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}
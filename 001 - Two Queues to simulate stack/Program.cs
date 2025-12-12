class Program
{
    static void Main(string[] args)
    {

    }
}
public class MyStack
{
    Queue<int> q;

    public MyStack()
    {
        q = new Queue<int>();
    }
    public int Pop()
    {
        var q2 = new Queue<int>();
        int count = q.Count;
        for (int i = 0; i < count - 1; i++)
        {
            q2.Enqueue(q.Dequeue());
        }
        int temp = q.Dequeue();
        q = q2;
        return temp;
    }
    public void Push(int element)
    {
        q.Enqueue(element);
    }

    public int Top()
    {
        var q2 = new Queue<int>();
        int count = q.Count;
        for (int i = 0; i < count - 1; i++)
        {

            q2.Enqueue(q.Dequeue());
        }
        int temp = q.Dequeue();
        q2.Enqueue(temp);
        q = q2;
        return temp;
    }

    public bool Empty() => q.Count == 0;

}


/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
class Program
{
    static void Main(string[] args)
    {

    }
}

public class Solution
{
    public int MaxDepth(string s)
    {
        int depth = 0;
        int max = 0;
        Stack<char> stack = new Stack<char>();
        foreach (char ch in s)
        {
            if (ch == '(')
            {
                depth++;
                stack.Push(ch);
            }
            else if (ch == ')')
            {
                if(depth > max)
                    max = depth;
                if (stack.Count > 0)
                {
                    depth--;
                    stack.Pop();
                }
            }
        }
        return max;
    }
}

class Progarm
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.IsValid("(([])){"));
    }

    
}

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        char temp;
        foreach(char ch in s)
        {
            if (ch=='[' || ch=='{' || ch == '(')
            {
                stack.Push(ch);
            }else if (ch == ']' || ch == '}' || ch == ')')
            {
                if (stack.Count == 0)
                    return false;
                temp = stack.Pop();
                if ((ch =='}' && temp=='{') || (ch == ']' && temp == '[') || (ch == ')' && temp == '(')  )
                    continue;
                return false;
            }
            else
            {
                return false;
            }
        }
        return stack.Count == 0 ? true : false;
        
    }
}
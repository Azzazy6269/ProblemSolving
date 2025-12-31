class Program
{
    static void Main(string[] args)
    {
        Solution s=new Solution();
        s.RemoveOuterParentheses("(()())(())");
    }
}

public class Solution
{
    public string RemoveOuterParentheses(string s)
    {
        Stack<char> st = new Stack<char>();
        string res = "";
        foreach(char ch in s)
        {
           if(ch == '(' )
            {
                if (st.Count > 0)
                    res += ch;
                st.Push(ch);
            }
            else if(ch ==')')
            {
                st.Pop();
                if (st.Count > 0)
                    res += ch;
            }
        }
        return res;

    }
}
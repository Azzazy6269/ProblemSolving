class Progarm
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        s.SmallestNumber("IIIDIDDD");
    }
}

public class Solution
{
    string res = "";
    Stack<int> st = new Stack<int>();

    public string SmallestNumber(string pattern)
    {
        int i;
        for ( i =0; i < pattern.Length; i++)
        {
            if (pattern[i]=='I' &&( i==0 || pattern[i - 1] == 'I'))
            {
                res += (i+1).ToString();
            }
            else if(pattern[i]=='I' && pattern[i - 1] == 'D')
            {
                res += (i + 1).ToString();
                while (st.Count > 0)
                {
                    res += st.Pop().ToString();
                }
            }else if (pattern[i] == 'D')
            {
                st.Push((i+1));
            }
        }
        if (pattern[i - 1] == 'D')
        {
            st.Push(i + 1);
        }
        while (st.Count > 0)
        {
            res += st.Pop().ToString();
        }
        if (pattern[i - 1] == 'I')
        {
            res += (i + 1).ToString();
        }
        return res;
    }
}
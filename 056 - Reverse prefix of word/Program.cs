class Program
{
    static void Main(string[] args)
    {

    }
}

public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        string res = "";
        int i = 0;
        Stack<char> st = new Stack<char>();
        while (i < word.Length && ch != word[i]) 
        {
            st.Push(word[i]);
            i++;
        }
        if (i >= word.Length)
            return word;
        res += word[i++];
        while(st.Count > 0)
        {
            res = res + st.Pop();
        }
        while(i < word.Length)
        {
            res = res + word[i];
            i++;
        }
        return res;
    }
}
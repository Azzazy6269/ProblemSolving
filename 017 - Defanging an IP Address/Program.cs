public class Solution
{
    public string DefangIPaddr(string address)
    {
        string result = "";
        int temp = 0;
        foreach(char ch in address)
        {
            

            if(ch>=48 && ch<=57)
            {
                result += ch;
            }
            else if (ch == '.')
            {
                result += "[.]";
            }
        }
        return result;
    }
}

class Program
{
    static void Main(string []args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.DefangIPaddr("255.100.50.0"));
    }
}
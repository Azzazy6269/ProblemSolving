using System.Collections.Specialized;

public class Program
{
    static void Main(string[]args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.IntToRoman(3749));
    }
}

public class Solution
{
    // 1 , 4 , 5 , 9 , 10 , 40 , 50 , 90 , 100 , 400 , 500 , 900 , 1000
    public string IntToRoman(int num)
    {
        string result = "";
        int temp = 0;
        temp = num / 1000;
        for(int i = 0; i < temp; i++)
        {
            result += 'M';
        }
        num -= temp*1000;

        temp = num / 900;
        for (int i = 0; i < temp; i++)
        {
            result += "CM";
        }
        num -= temp*900;

        temp = num / 500;
        for (int i = 0; i < temp; i++)
        {
            result += "D";
        }
        num -= temp*500;

        temp = num / 400;
        for (int i = 0; i < temp; i++)
        {
            result += "CD";
        }
        num -= temp*400;

        temp = num / 100;
        for (int i = 0; i < temp; i++)
        {
            result += "C";
        }
        num -= temp*100;

        temp = num / 90;
        for (int i = 0; i < temp; i++)
        {
            result += "XC";
        }
        num -= temp*90;

        temp = num / 50;
        for (int i = 0; i < temp; i++)
        {
            result += "L";
        }
        num -= temp*50;

        temp = num / 40;
        for (int i = 0; i < temp; i++)
        {
            result += "XL";
        }
        num -= temp*40;

        temp = num / 10;
        for (int i = 0; i < temp; i++)
        {
            result += "X";
        }
        num -= temp*10;

        temp = num / 9;
        for (int i = 0; i < temp; i++)
        {
            result += "IX";
        }
        num -= temp*9;

        temp = num / 5;
        for (int i = 0; i < temp; i++)
        {
            result += "V";
        }
        num -= temp*5;

        temp = num / 4;
        for (int i = 0; i < temp; i++)
        {
            result += "IV";
        }
        num -= temp*4;

        temp = num / 1;
        for (int i = 0; i < temp; i++)
        {
            result += "I";
        }
        num -= temp*1;
        return result;
    }
}
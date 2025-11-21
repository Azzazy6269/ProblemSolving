#include <iostream>
#include <string>
using namespace std;

class Solution
{
public:
    int myAtoi(string s)
    {
        long long res =0;
        int firstDigit =0;
        bool positive = true;
        int i =0;
        while(s[i]==' ')
        {
            i++;
        }
        if (s[i] == '-')
        {
            positive = false;
            i++;
        }
        else if(s[i]== '+')
        {
            positive =true;
            i++;
        }

        for(i ; i<s.size(); i++)
        {
            if(s[i]<'0'||s[i]>'9')
                return res;
            if(s[i]>'0' && s[i]<='9')
            {
                firstDigit = i;
                break;
            }

        }
        for(int i=firstDigit; i<s.size(); i++)
        {
            if(s[i]>'9'||s[i]<'0')
                break;
            res = res*10 +((int)s[i]-48);
            if (positive && res > 2147483647)
            {
                res =2147483647;
                return res;
            }
            else if(!positive && res > 2147483648)
            {
                res =2147483648;
                return -res;

            }

        }

        if(positive)
            return res;
        return -res;
    }
};


int main()
{
    Solution s;

    cout << "Input    : 42\n";
    cout << "Expected : 42\n";
    cout << "Result   : " << s.myAtoi("42") << "\n\n";

    cout << "Input    :    -42\n";
    cout << "Expected : -42\n";
    cout << "Result   : " << s.myAtoi("   -42") << "\n\n";

    cout << "Input    : 4193 with words\n";
    cout << "Expected : 4193\n";
    cout << "Result   : " << s.myAtoi("4193 with words") << "\n\n";

    cout << "Input    : words and 987\n";
    cout << "Expected : 0\n";
    cout << "Result   : " << s.myAtoi("words and 987") << "\n\n";

    cout << "Input    : -91283472332\n";
    cout << "Expected : -2147483648\n";
    cout << "Result   : " << s.myAtoi("-91283472332") << "\n\n";

    cout << "Input    : 91283472332\n";
    cout << "Expected : 2147483647\n";
    cout << "Result   : " << s.myAtoi("91283472332") << "\n\n";

    cout << "Input    : +1\n";
    cout << "Expected : 1\n";
    cout << "Result   : " << s.myAtoi("+1") << "\n\n";

    cout << "Input    : 00000-42a1234\n";
    cout << "Expected : 0\n";
    cout << "Result   : " << s.myAtoi("00000-42a1234") << "\n\n";

    cout << "Test 10\n";
    cout << "Input    : -000000000000001\n";
    cout << "Expected : -1\n";
    cout << "Result   : " << s.myAtoi("-000000000000001") << "\n\n";

    return 0;
}

#include <iostream>
#include <vector>

using namespace std;
class Solution
{
public:
    int lengthOfLongestSubstring(string s)
    {
        int max =0;
        int _start = 0;
        int _end = 0;
        char ch;
        int count = 0;
        int maxLength = 0;
        int i =0;
        for(_end; _end<s.size(); _end++)
        {
            ch = s[_end];
            for(int i =_start; i<_end; i++)
            {
                if(s[i]!=ch)
                {
                    continue;
                }
                else
                {
                    _start = i+1;
                    break;
                }
            }
                count = _end - _start +1;
                if(count>maxLength) maxLength = count;

        }

        return maxLength;
    }
};

int main()
{
    Solution s ;
    cout<<s.lengthOfLongestSubstring("tmzuxt");
    return 0;
}

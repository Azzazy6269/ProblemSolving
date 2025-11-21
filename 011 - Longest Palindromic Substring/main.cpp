#include <iostream>
#include <string>
using namespace std;

class Solution
{
public:
    string longestPalindrome(string s)
    {

        bool x =false;
        for(int i=0; i<s.size(); i++)
        {
            if(s[i]!=s[0])
            {
                x = true;
                break;
            }
        }
        if(!x) return s;


        int i=0,j=0,z=0;
        int start=0,end=0;
        int chainLength=0;
        bool br = false;
        for(int i=0; i<s.size(); i++)
        {
            j = i-1;
            z = i+1;
            br = false;
            while(1)
            {
                if(j>=0 && z<s.size() && s[i]==s[j] && s[i]==s[z])
                {
                    if(j>0)
                        j--;
                    if(z<s.size()-1)
                        z++;
                }
                else if(j>=0 && s[i]==s[j])
                {
                    if(j>=0)
                        j--;
                }
                else if(z<s.size() && s[i]==s[z])
                {
                    if(z<s.size())
                        z++;
                }else{
                    break;
                }
            }

            while(j>=0 && z<s.size() && !br)
            {
                if(s[j]==s[z])
                {
                    j--;
                    z++;
                }
                else
                {
                    br=true;
                }
            }
            int currentChainLength = (z-1) - (j+1) +1;
            if(currentChainLength>chainLength)
            {
                chainLength = currentChainLength;
                start = j+1;
                end = z-1;
            }
        }

        string res ;
        for(int y = start ; y<=end; y++)
        {
            res.push_back(s[y]);
        }
        return res;
    }
};


int main()
{
    Solution s ;
    cout << "Input: babad\n";
    cout << "result: " << s.longestPalindrome("babad") << " , expected: bab OR aba\n\n";

    cout << "Input: cbbd\n";
    cout << "result: " << s.longestPalindrome("cbbd") << " , expected: bb\n\n";

    cout << "Input: racecar\n";
    cout << "result: " << s.longestPalindrome("racecar") << " , expected: racecar\n\n";

    cout << "Input: abc\n";
    cout << "result: " << s.longestPalindrome("abc") << " , expected: a\n\n";

    cout << "Input: (empty string)\n";
    cout << "result: " << s.longestPalindrome("") << " , expected: \n\n";

    cout << "Input: a\n";
    cout << "result: " << s.longestPalindrome("a") << " , expected: a\n\n";

    cout << "Input: aaaaa\n";
    cout << "result: " << s.longestPalindrome("aaaaa") << " , expected: aaaaa\n\n";

    cout << "Input: forgeeksskeegfor\n";
    cout << "result: " << s.longestPalindrome("forgeeksskeegfor") << " , expected: geeksskeeg\n\n";

    cout << "Input: abacdfgdcaba\n";
    cout << "result: " << s.longestPalindrome("abacdfgdcaba") << " , expected: aba\n\n";

    cout << "Input: abcbaxyz\n";
    cout << "result: " << s.longestPalindrome("abcbaxyz") << " , expected: abcba\n\n";

    cout << "Input: abacdc\n";
    cout << "result: " << s.longestPalindrome("abacdc") << " , expected: aba OR cdc\n\n";

    cout << "Input: bb\n";
    cout << "result: " << s.longestPalindrome("bb") << " , expected: bb\n\n";

    cout << "Input: aaaa\n";
    cout << "result: " << s.longestPalindrome("aaaa") << " , expected: aaaa\n\n";

    cout << "Input: dddddddd\n";
    cout << "result: " << s.longestPalindrome("dddddddd") << " , expected: dddddddd\n\n";

    string test = "aaaabbbbbbbbbbccccccccccddddddddddeeeeeeeeeeffffffffffgggggggggghhhhhhhhhhiiiiiiiiiijjjjjjjjjjkkkkkkkkkkllllllllllmmmmmmmmmmnnnnnnnnnnooooooooooppppppppppqqqqqqqqqqrrrrrrrrrrssssssssssttttttttttuuuuuuuuuuvvvvvvvvvvwwwwwwwwwwxxxxxxxxxxyyyyyyyyyyzzzzzzzzzzyyyyyyyyyyxxxxxxxxxxwwwwwwwwwwvvvvvvvvvvuuuuuuuuuuttttttttttssssssssssrrrrrrrrrrqqqqqqqqqqppppppppppoooooooooonnnnnnnnnnmmmmmmmmmmllllllllllkkkkkkkkkkjjjjjjjjjjiiiiiiiiiihhhhhhhhhhggggggggggffffffffffeeeeeeeeeeddddddddddccccccccccbbbbbbbbbbaaaaaaaabbbbbbbbbbccccccccccddddddddddeeeeeeeeeeffffffffffgggggggggghhhhhhhhhhiiiiiiiiiijjjjjjjjjjkkkkkkkkkkllllllllllmmmmmmmmmmnnnnnnnnnnooooooooooppppppppppqqqqqqqqqqrrrrrrrrrrssssssssssttttttttttuuuuuuuuuuvvvvvvvvvvwwwwwwwwwwxxxxxxxxxxyyyyyyyyyyzzzzzzzzzzyyyyyyyyyyxxxxxxxxxxwwwwwwwwwwvvvvvvvvvvuuuuuuuuuuttttttttttssssssssssrrrrrrrrrrqqqqqqqqqqppppppppppoooooooooonnnnnnnnnnmmmmmmmmmmllllllllllkkkkkkkkkkjjjjjjjjjjiiiiiiiiiihhhhhhhhhhggggggggggffffffffffeeeeeeeeeeddddddddddccccccccccbbbbbbbbbbaaaa";
    cout << "Input: "<<test<<endl;
    cout << "result: " << s.longestPalindrome(test) << " , expected: whole string\n\n";
    return 0;
}

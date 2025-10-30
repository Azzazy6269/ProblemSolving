#include <iostream>
#include <stack>
#include <vector>
#include <string>


using namespace std;
class Solution
{
public:
    int evalRPN(vector<string>& tokens)
    {
        stack<int> s;
        int x;
        int y;
        int Result =0;
        if(tokens.size() == 1) return stoi(tokens[0]);
        for(string str : tokens)
        {
            if(str =="+" || str == "-" || str == "*" || str == "/" )
            {
                x = s.top();
                s.pop();
                y = s.top();
                s.pop();
                if(str == "+")
                {
                    Result = y+x;
                }
                else if(str == "-")
                {
                    Result = y-x;
                }
                else if(str == "*")
                {
                    Result = y*x;
                }
                else if(str == "/")
                {
                    Result = y/x;
                }
                s.push(Result);
            }
            else
            {
                s.push(stoi(str));
            }
        }
        return Result;
    }
};
int main()
{
    Solution sol ;
    vector<string> tokens = {"18"};
    cout << sol.evalRPN(tokens);

    return 0;
}

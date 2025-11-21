#include <iostream>

using namespace std;
class Solution {
public:
    int reverse(int x) {
        long y = 0;
        while(x != 0){
         y = y*10 + x%10 ;
        x= x/10;
        }
        if((int)y == y) return y;
        return 0;

    }
};
int main()
{
    Solution s;
    cout<<s.reverse(12345);
    return 0;
}

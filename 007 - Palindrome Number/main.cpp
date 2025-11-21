#include <iostream>

using namespace std;


class Solution {
public:
    bool isPalindrome(int x) {
        if(x<0) return false;
        long y =0 ;
        int temp =x;
        do{
            y = y*10 + temp%10;
            temp /= 10;
        }while(temp!=0);
        return (y == x);
    }
};
int main()
{

    return 0;
}

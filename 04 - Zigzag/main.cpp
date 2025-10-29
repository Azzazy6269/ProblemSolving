#include <iostream>
#include <string>
using namespace std;

class Solution {
public:
    string convert(string s, int numRows) {
        if (numRows == 1 || s.size() <= numRows)
            return s;

        string* rows = new string[numRows];
        int currRow = 0;
        bool goingDown = false;

        for (char c : s) {
            rows[currRow].push_back(c);
            if (currRow == 0 || currRow == numRows - 1)
                goingDown = !goingDown;
            if (goingDown)
                currRow = currRow + 1;
            else
                currRow = currRow - 1;
        }

        string result;
        for (int i = 0; i < numRows; ++i)
            result += rows[i];

        delete[] rows;
        return result;
    }
};

int main() {
    Solution sol;
    cout << sol.convert("PAYPALISHIRING", 3) << endl;
    return 0;
}

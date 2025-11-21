#include <iostream>
#include <vector>
using namespace std;

class Solution
{
public:
    double findMedianSortedArrays(vector<int>& nums1, vector<int>& nums2)
    {
        int i=0,j=0,k=0;
        int total =nums1.size()+nums2.size();
        int medIndex = total/2;
        if(total == 0) return 0;
        int* merged = new int [total];
        while(i<nums1.size() && j<nums2.size() && k<=medIndex)
        {
            if(nums1[i]<nums2[j])
            {
                merged[k++] = nums1[i++];
            }
            else
            {
                merged[k++] = nums2[j++];
            }
        }
        while(i<nums1.size()&& k<=medIndex)
        {
            merged[k++] = nums1[i++];
        }
        while(j<nums2.size()&& k<=medIndex)
        {
            merged[k++] = nums2[j++];
        }
        if(total%2==0){
            float result = ((float)merged[medIndex]+(float)merged[medIndex-1])/2;
            return result;
        }else{
            return merged[medIndex];
        }

    }
};

int main()
{
    Solution s;

    vector<int> nums1 = {1, 3};
    vector<int> nums2 = {2};
    cout << "Median = " << s.findMedianSortedArrays(nums1, nums2)
         << "  (Expected: 2)" << endl;

    nums1 = {1, 2, 3};
    nums2 = {1, 2, 3};
    cout << "Median = " << s.findMedianSortedArrays(nums1, nums2)
         << "  (Expected: 2)" << endl;

    nums1 = {5, 5, 5};
    nums2 = {5, 5};
    cout << "Median = " << s.findMedianSortedArrays(nums1, nums2)
         << "  (Expected: 5)" << endl;

    nums1 = {1, 2};
    nums2 = {3, 4, 5};
    cout << "Median = " << s.findMedianSortedArrays(nums1, nums2)
         << "  (Expected: 3)" << endl;
    nums1 = {};
    nums2 = {10, 20, 30};
    cout << "Median = " << s.findMedianSortedArrays(nums1, nums2)
         << "  (Expected: 20)" << endl;

    nums1 = {1, 2};
    nums2 = {3, 4};
    cout << "Median = " << s.findMedianSortedArrays(nums1, nums2)
         << "  (Expected: 2.5)" << endl;

    nums1 = {};
    nums2 = {1};
    cout << "Median = " << s.findMedianSortedArrays(nums1, nums2)
         << "  (Expected: 1)" << endl;

    nums1 = {1, 2, 3};
    nums2 = {10, 11, 12};
    cout << "Median = " << s.findMedianSortedArrays(nums1, nums2)
         << "  (Expected: 6.5)" << endl;

    nums1 = {1, 3, 8};
    nums2 = {7, 9, 10, 11};
    cout << "Median = " << s.findMedianSortedArrays(nums1, nums2)
         << "  (Expected: 8)" << endl;


    return 0;
}

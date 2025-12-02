using System.Collections;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> Res = new List<IList<int>>();
        Array.Sort(nums);
        int left,right;
        int CurrNum,leftNum,rightNum,sum;
        for(int i =0;i<nums.Length;i++)
        {
            if(i  >0 &&nums[i] == nums[i-1]  )
            {
                continue;
            }
            left = i + 1;
            right = nums.Length - 1;
            while (left < right)
            {
                 CurrNum = nums[i];
                 leftNum = nums[left];
                 rightNum = nums[right];
                sum = nums[i] + nums[left] + nums[right];
                if (sum==0)
                {
                    Res.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1] ) left++;
                    while (left < right && nums[right] == nums[right + 1] ) right--;
                }
                else if (sum>0)
                {
                    right--;
                }
                else if (sum<0)
                {
                    left++;
                        
                }
            }
        }
        return Res;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        // ---------- Test Case 1 ----------
        int[] test1 = { -1, 0, 1, 2, -1, -4 }; // مثال كلاسيكي
        PrintResult("Test Case 1", sol.ThreeSum(test1));

        // ---------- Test Case 2 ----------
        int[] test2 = { 0, 0, 0 }; // كل الأعداد صفر
        PrintResult("Test Case 2", sol.ThreeSum(test2));

        // ---------- Test Case 3 ----------
        int[] test3 = { -2, 0, 1, 1, 2 }; // مجموعات موجبة وسالبة
        PrintResult("Test Case 3", sol.ThreeSum(test3));

        // ---------- Test Case 4 ----------
        int[] test4 = { 3, -2, 1, 0 }; // لا يوجد مجموع صفر
        PrintResult("Test Case 4", sol.ThreeSum(test4));

        // ---------- Test Case 5 ----------
        int[] test5 = { }; // مصفوفة فارغة
        PrintResult("Test Case 5", sol.ThreeSum(test5));

        // ---------- Test Case 6 ----------
        int[] test6 = { 0, 1, 1 }; // لا يوجد مجموع صفر
        PrintResult("Test Case 6", sol.ThreeSum(test6));

        // ---------- Test Case 7 ----------
        int[] test7 = { -1, -1, 2 }; // ثلاثية واحدة فقط
        PrintResult("Test Case 7", sol.ThreeSum(test7));

        // ---------- Test Case 8 ----------
        int[] test8 = { -1, -1, -1, 2, 2, 2 }; // تكرارات
        PrintResult("Test Case 8", sol.ThreeSum(test8));

        // ---------- Test Case 9 ----------
        int[] test9 = { -2, -1, 0, 1, 2 }; // ثلاثيات متعددة
        PrintResult("Test Case 9", sol.ThreeSum(test9));

        // ---------- Test Case 10 ----------
        int[] test10 = { -3, -2, -1, 0, 1, 2, 3 }; // كل القيم من -3 إلى 3
        PrintResult("Test Case 10", sol.ThreeSum(test10));

        // ---------- Test Case 11 ----------
        int[] test11 = { 1, 2, -2, -1 }; // لا يوجد مجموع صفر
        PrintResult("Test Case 11", sol.ThreeSum(test11));

        // ---------- Test Case 12 ----------
        int[] test12 = { 0, 0, 0, 0 }; // جميعها صفر، يجب أن تنتج ثلاثية واحدة فقط
        PrintResult("Test Case 12", sol.ThreeSum(test12));

        // ---------- Test Case 13 ----------
        int[] test13 = { -5, 2, 3, 0, 1, 4, -2, -1 }; // مجموعة أعداد عشوائية
        PrintResult("Test Case 13", sol.ThreeSum(test13));

        // ---------- Test Case 14 ----------
        int[] test14 = { -1, 0, 1 }; // ثلاثية واحدة
        PrintResult("Test Case 14", sol.ThreeSum(test14));

        // ---------- Test Case 15 ----------
        int[] test15 = { -10, -3, -2, 0, 1, 2, 5, 8 }; // أعداد أكبر
        PrintResult("Test Case 15", sol.ThreeSum(test15));

        // ---------- Test Case 16 ----------
        int[] test16 = { 1, 1, -2 }; // ثلاثية واحدة
        PrintResult("Test Case 16", sol.ThreeSum(test16));

        // ---------- Test Case 17 ----------
        int[] test17 = { -1, -1, -1, 0, 1, 1, 1 }; // تكرارات متعددة
        PrintResult("Test Case 17", sol.ThreeSum(test17));

        // ---------- Test Case 18 ----------
        int[] test18 = { 2, -1, -1 }; // ثلاثية واحدة
        PrintResult("Test Case 18", sol.ThreeSum(test18));

        // ---------- Test Case 19 ----------
        int[] test19 = { -4, -2, -2, -2, 0, 1, 2, 2, 3 }; // تكرارات وصفر
        PrintResult("Test Case 19", sol.ThreeSum(test19));

        // ---------- Test Case 20 ----------
        int[] test20 = { 0, 0, 0, 1, -1 }; // صفراً وتوازن بسيط
        PrintResult("Test Case 20", sol.ThreeSum(test20));

        // ---------- Test Case 21 ----------
        int[] test21 = { 2, -3, 0, -2, -5, -5, -4, 1, 2, -2, 2, 0, 2, -4, 5, 5, -10 }; // -10 , -5 ,-5 ,-4 ,-4 , -3 , -3
        PrintResult("Test Case 21", sol.ThreeSum(test21));
    }
    static void PrintResult(string title, IList<IList<int>> result)
    {
        Console.WriteLine("---- " + title + " ----");
        if (result.Count == 0)
        {
            Console.WriteLine("No triplets found.");
        }
        else
        {
            foreach (var triplet in result)
            {
                Console.WriteLine($"[{triplet[0]}, {triplet[1]}, {triplet[2]}]");
            }
        }
        Console.WriteLine();
    }
}

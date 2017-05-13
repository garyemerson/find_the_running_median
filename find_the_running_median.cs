using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static void Main(string[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
        int n = int.Parse(Console.ReadLine());
        List<int> nums = new List<int>(n);
        for (int i = 0; i < n; i++) {
            int x = int.Parse(Console.ReadLine());
            // Console.WriteLine("inserting {0}", x);
            insertSorted(nums, x);
            // Console.WriteLine("nums is {0}", string.Join(" ", nums));
            Console.WriteLine("{0:0.0}", getMedian(nums));
        }
        // Console.WriteLine("nums is {0}", string.Join(" ", nums));
    }
    private static void insertSorted(List<int> nums, int x) {
        nums.Insert(getInsertIndex(nums, x, 0, nums.Count), x);
    }

    private static int getInsertIndex(List<int> nums, int x, int start, int end) {
        if (start == end) {
            return start;
        }
        int mid = start + ((end - start) / 2);
        if (x < nums[mid]) {
            if (mid == start) {
                return mid;
            } else {
                return getInsertIndex(nums, x, start, mid);
            }
        } else {
            if (mid == end) {
                return mid;
            } else {
                return getInsertIndex(nums, x, mid + 1, end);
            }
        }
    }

    private static double getMedian(List<int> nums) {
        if (nums.Count % 2 == 0) {
            int mid1 = (nums.Count / 2) - 1;
            int mid2 = nums.Count / 2;
            return (nums[mid1] + nums[mid2]) / 2.0;
        } else {
            return nums[nums.Count / 2];
        }
    }
}
}

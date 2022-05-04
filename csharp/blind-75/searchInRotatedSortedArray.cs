public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length is 0) {
            return -1;
        }
        
        int left = 0;
        int right = nums.Length - 1;
        
        while (left < right) {
            int middle = left + (right - left) / 2;
            
            if (nums[middle] > nums[right]) {
                left = middle + 1;
            } else {
                right = middle;
            }
        }
        
        int start = left;
        left = 0;
        right = nums.Length - 1;
        
        if (target >= nums[start] && target <= nums[right]) {
            left = start;
        } else {
            right = start;
        }
        
        while (left <= right) {
            int middle = left + (right - left) / 2;
            
            if (nums[middle] == target) {
                return middle;
            } else if (nums[middle] < target) {
                left = middle + 1;
            } else {
                 right = middle - 1;
            }
        }
        
        return -1;
    }
}

// Example 1:

// Input: nums = [4,5,6,7,0,1,2], target = 0
// Output: 4

// Example 2:

// Input: nums = [4,5,6,7,0,1,2], target = 3
// Output: -1

// Example 3:

// Input: nums = [1], target = 0
// Output: -1
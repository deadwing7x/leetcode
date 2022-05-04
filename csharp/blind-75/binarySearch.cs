public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 0) {
            return -1;
        }
        
        return binarySearch(nums, target, 0, nums.Length - 1);
    }
    
    int binarySearch(int[] nums, int target, int left, int right) {
        if (left > right) {
            return -1;
        }
        
        int middle = left + (right - left) / 2;
        
        if (nums[middle] == target) {
            return middle;
        }
        
        if (nums[middle] < target) {
            return binarySearch(nums, target, middle + 1, right);
        }
        
        return binarySearch(nums, target, left, middle - 1);
    }
}

// Example 1:

// Input: nums = [-1,0,3,5,9,12], target = 9
// Output: 4
// Explanation: 9 exists in nums and its index is 4

// Example 2:

// Input: nums = [-1,0,3,5,9,12], target = 2
// Output: -1
// Explanation: 2 does not exist in nums so return -1
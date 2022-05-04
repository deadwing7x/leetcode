public class Solution {
    public int FindMin(int[] nums) {
        if (nums.Length == 0) {
            return -1;
        }
        
        if (nums.Length == 1) {
            return nums[0];
        }
        
        int left = 0;
        int right = nums.Length - 1;

        while (left < right) {
            int middle = left + (right - left) / 2;
            if (middle > 0 && nums[middle] < nums[middle - 1]) {
                return nums[middle];                
            } else if (nums[left] <= nums[middle] && nums[middle] > nums[right]) {
                left = middle + 1;
            } else {
                right = middle - 1;
            }
        }
        
        return nums[left];
    }
}

// Example 1:

// Input: nums = [3,4,5,1,2]
// Output: 1
// Explanation: The original array was [1,2,3,4,5] rotated 3 times.

// Example 2:

// Input: nums = [4,5,6,7,0,1,2]
// Output: 0
// Explanation: The original array was [0,1,2,4,5,6,7] and it was rotated 4 times.

// Example 3:

// Input: nums = [11,13,15,17]
// Output: 11
// Explanation: The original array was [11,13,15,17] and it was rotated 4 times. 
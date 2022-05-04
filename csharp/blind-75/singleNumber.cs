public class Solution {
    public int SingleNumber(int[] nums) {
        if (nums.Length is 0) {
            return -1;
        }
        
        if (nums.Length is 1) {
            return nums[0];
        }
        
        int result = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            result ^= nums[i];
        }
        
        return result;
    }
}

// Example 1:

// Input: nums = [2,2,1]
// Output: 1

// Example 2:

// Input: nums = [4,1,2,1,2]
// Output: 4

// Example 3:

// Input: nums = [1]
// Output: 1
public class Solution {
    public void MoveZeroes(int[] nums) {
        if (nums.Length is 1) {
            return;
        }
        
        int lastNonZeroIndex = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] is not 0) {
                nums[lastNonZeroIndex] = nums[i];
                lastNonZeroIndex++;
            }
        }
        
        for (int i = lastNonZeroIndex; i < nums.Length; i++) {
            nums[i] = 0;
        }
    }
}

// Example 1:

// Input: nums = [0,1,0,3,12]
// Output: [1,3,12,0,0]

// Example 2:

// Input: nums = [0]
// Output: [0]
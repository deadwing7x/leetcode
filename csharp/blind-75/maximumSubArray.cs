public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxCurrentSum = nums[0];
        int maxGlobalSum = nums[0];
        
        for (int i = 1; i < nums.Length; i++) {
            maxCurrentSum = Math.Max(maxCurrentSum + nums[i], nums[i]);
            
            if (maxCurrentSum > maxGlobalSum) {
                maxGlobalSum = maxCurrentSum;    
            }
        }
        
        return maxGlobalSum;
    }
}

// Example 1:

// Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
// Output: 6
// Explanation: [4,-1,2,1] has the largest sum = 6.

// Example 2:

// Input: nums = [1]
// Output: 1

// Example 3:

// Input: nums = [5,4,-1,7,8]
// Output: 23


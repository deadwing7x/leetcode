public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> sum = new();
        
        for (int i = 0; i < nums.Length; i++) {
            if (sum.ContainsKey(target - nums[i])) {
                int index = sum[target - nums[i]];
                return new[] { i, index };
            }
            
            if (!sum.ContainsKey(nums[i])) {
                sum.Add(nums[i], i);
            }
        }
        
        return new int[2];
    }
}

// Example 1:

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

// Example 2:

// Input: nums = [3,2,4], target = 6
// Output: [1,2]

// Example 3:

// Input: nums = [3,3], target = 6
// Output: [0,1]
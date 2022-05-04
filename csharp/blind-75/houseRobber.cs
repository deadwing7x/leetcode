public class Solution {
    public int Rob(int[] nums) {
        int maxMoney = 0;
        
        Dictionary<int, int> memo = new Dictionary<int, int>();
        
        for (int i = nums.Length - 1; i >= 0; i--) {
            maxMoney = Math.Max(Rob(nums, i, memo), maxMoney);
        }
        
        return maxMoney;
    }
    
    private int Rob(int[] nums, int index, Dictionary<int, int> memo) {
        if (memo.TryGetValue(index, out int cached)) {
            return cached;
        }
        
        return memo[index] = index >= 0
            ? Math.Max(nums[index] + Rob(nums, index - 2, memo),
                       nums[index] + Rob(nums, index - 3, memo))
            : 0;
    }
}

// You are a professional robber planning to rob houses along a street.
// Each house has a certain amount of money stashed,
// the only constraint stopping you from robbing each of them is that
// adjacent houses have security systems connected and it will automatically contact the police
// if two adjacent houses were broken into on the same night.

// Given an integer array nums representing the amount of money of each house,
// return the maximum amount of money you can rob tonight without alerting the police.

// Example 1:

// Input: nums = [1,2,3,1]
// Output: 4
// Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
// Total amount you can rob = 1 + 3 = 4.

// Example 2:

// Input: nums = [2,7,9,3,1]
// Output: 12
// Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
// Total amount you can rob = 2 + 9 + 1 = 12.
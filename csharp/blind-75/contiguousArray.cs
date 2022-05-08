public class Solution {
    public int FindMaxLength(int[] nums) {
        if (nums.Length is 1) {
            return 0;
        }
        
        int maxLength = 0;
        int count = 0;
        
        Dictionary<int, int> index = new();
        index.Add(0, -1);
        
        for (int i = 0; i < nums.Length; i++) {
            count = count + (nums[i] == 1 ? 1 : -1);
            
            if (index.ContainsKey(count)) {
                maxLength = Math.Max(maxLength, i - index[count]);
            } else {
                index.Add(count, i);
            }
        }
        
        return maxLength;
    }
}

// Example 1:

// Input: nums = [0,1]
// Output: 2
// Explanation: [0, 1] is the longest contiguous subarray with an equal number of 0 and 1.

// Example 2:

// Input: nums = [0,1,0]
// Output: 2
// Explanation: [0, 1] (or [1, 0]) is a longest contiguous subarray with equal number of 0 and 1.
public class Solution {
    public void Rotate(int[] nums, int k) {
        if (k == 0 || (nums.Length < 2)) {
            return;
        }
        
        k = k % nums.Length;
        
        if(k > nums.Length){
            Array.Reverse(nums, 0, nums.Length - 1);
        }
        
        Array.Reverse(nums, 0, nums.Length);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, nums.Length - k);
    }
}

// Example 1:

// Input: nums = [1,2,3,4,5,6,7], k = 3
// Output: [5,6,7,1,2,3,4]
// Explanation:
// rotate 1 steps to the right: [7,1,2,3,4,5,6]
// rotate 2 steps to the right: [6,7,1,2,3,4,5]
// rotate 3 steps to the right: [5,6,7,1,2,3,4]

// Example 2:

// Input: nums = [-1,-100,3,99], k = 2
// Output: [3,99,-1,-100]
// Explanation: 
// rotate 1 steps to the right: [99,-1,-100,3]
// rotate 2 steps to the right: [3,99,-1,-100]
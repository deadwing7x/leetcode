public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        
        int[] leftArray = new int[n];
        int[] rightArray = new int[n];
        
        leftArray[0] = 1;
        rightArray[n - 1] = 1;
        
        for (int i = 1; i < n; i++) {
            leftArray[i] = leftArray[i - 1] * nums[i - 1];
        }
        
        for (int i = n - 2; i >= 0; i--) {
            rightArray[i] = rightArray[i + 1] * nums[i + 1];
        }
        
        int[] outputArray = new int[n];
        
        for (int i = 0; i < n; i++) {
            outputArray[i] = leftArray[i] * rightArray[i];
        }
        
        return outputArray;
    }
}

// Example 1:

// Input: nums = [1,2,3,4]
// Output: [24,12,8,6]

// Example 2:

// Input: nums = [-1,1,0,-3,3]
// Output: [0,0,9,0,0]
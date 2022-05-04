public class Solution {
    public int MaxProduct(int[] nums) {
        int maxCurrentProduct = 1;
        int maxGlobalProduct = nums[0];
        
        for (int i = 0; i < nums.Length; i++) {
            maxCurrentProduct *= nums[i];
            
            if (maxCurrentProduct > maxGlobalProduct) {
                maxGlobalProduct = maxCurrentProduct;
            }
            
            if (maxCurrentProduct is 0) {
                maxCurrentProduct = 1;
            }
        }
        
        maxCurrentProduct = 1;
        
        for (int i = nums.Length - 1; i >= 0; i--) {
            maxCurrentProduct *= nums[i];
            
            if (maxCurrentProduct > maxGlobalProduct) {
                maxGlobalProduct = maxCurrentProduct;
            }
            
            if (maxCurrentProduct is 0) {
                maxCurrentProduct = 1;
            }
        }
        
        return maxGlobalProduct;
    }
}

// Example 1:

// Input: nums = [2,3,-2,4]
// Output: 6
// Explanation: [2,3] has the largest product 6.

// Example 2:

// Input: nums = [-2,0,-1]
// Output: 0
// Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
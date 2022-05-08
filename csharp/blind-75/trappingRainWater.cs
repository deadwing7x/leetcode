public class Solution {
    public int Trap(int[] height) {
        if (height.Length < 2) {
            return -1;
        }
        
        int left = 0;
        int right = height.Length - 1;
        
        int maxLeft = height[0];
        int maxRight = height[height.Length - 1];
        
        int maxWater = 0;
            
        while (left < right) {
            if (height[left] < height[right]) {
                maxWater += (Math.Min(maxLeft, maxRight) - height[left]);
                left++;
                maxLeft = Math.Max(maxLeft, height[left]);
            } else {
                maxWater += (Math.Min(maxLeft, maxRight) - height[right]);
                right--;
                maxRight = Math.Max(maxRight, height[right]);
            }
        }
        
        return maxWater;
    }
}

// Trick is to find the min (Left, Right) on a particular element and subtract that from the minimum. That gives us the amount of rainwater that can be trapped in that position.

// Example 1:

// Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
// Output: 6
// Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.

// Example 2:

// Input: height = [4,2,0,3,2,5]
// Output: 9
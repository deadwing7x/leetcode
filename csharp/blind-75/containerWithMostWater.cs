public class Solution {
    public int MaxArea(int[] height) {
        if (height.Length < 2) {
            return -1;
        }
        
        int maxAmountOfWater = int.MinValue;
        
        int left = 0;
        int right = height.Length - 1;
        
        int distance = 0;
        int minHeight = 0;
        
        while (left < right) {
            distance = right - left;
            
            if (height[left] < height[right]) {
                minHeight = height[left];
                left++;
            } else {
                minHeight = height[right];
                right--;
            }
            
            maxAmountOfWater = Math.Max(maxAmountOfWater, minHeight * distance);
        }
        
        if (maxAmountOfWater is not int.MinValue) {
            return maxAmountOfWater;
        }
        
        return -1;
    }
}

// Use (right - left) * whichever value is lower to find the most amount of water.

// Example 1:

// Input: height = [1,8,6,2,5,4,8,3,7]
// Output: 49
// Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.

// Example 2:

// Input: height = [1,1]
// Output: 1
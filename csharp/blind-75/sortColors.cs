public class Solution {
    public void SortColors(int[] nums) {
        if (nums.Length is 1) {
            return;
        }
        
        int i = 0;
        int maxZeroIndex = 0;
        int minTwoIndex = nums.Length - 1;
        
        while (i <= minTwoIndex) {
            if (nums[i] is 0) {
                swapNumbers(ref nums[i], ref nums[maxZeroIndex]);
                maxZeroIndex++;
                i++;
            } else if (nums[i] is 1) {
                i++;
            } else {
                swapNumbers(ref nums[i], ref nums[minTwoIndex]);
                minTwoIndex--;
            }
        }
    }
    
    public void swapNumbers(ref int a, ref int b) {
        int temp = b;
        b = a;
        a = temp;
    }
}

// Example 1:

// Input: nums = [2,0,2,1,1,0]
// Output: [0,0,1,1,2,2]

// Example 2:

// Input: nums = [2,0,1]
// Output: [0,1,2]
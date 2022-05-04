// Using HashSet solves it in O(N) time but adds an O(N) space complexity too.

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        HashSet<int> numbers = new(nums);
        
        for (int i = 1; i <= nums.Length + 1; i++) {
            if (!numbers.Contains(i)) {
                return i;
            }
        }
        
        return -1;
    }
}

// Using the input array as our memory, solves the O(N) space complexity issue.

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;
        
        // If length is 0, return -1.
        if (n is 0) {
            return -1;
        }
        
        // If length is 1 and the element is not 1, then return 1.
        if (n is 1 && nums[0] is not 1) {
            return 1;
        }
        
        bool containsOne = false;
        
        // Iterate and find if the input array contains 1, and change all values less than or equal to 0
        // and all values greater than n to 1.
        for (int i = 0; i < n; i++) {
            if (nums[i] == 1) {
                containsOne = true;
            } else if (nums[i] <= 0 || nums[i] > n) {
                nums[i] = 1;
            }
        }
        
        // Return 1, since 1 is not present in input array.
        if (!containsOne) {
            return 1;
        }
        
        for (int i = 0; i < n; i++) {
            int index = Math.Abs(nums[i]) - 1;
            
            // Change the sign of the number at index, to signify that it is present in the input array.
            if (nums[index] > 0) {
                nums[index] *= -1;
            }
        }
        
        // The first positive integer over here should give us the result.
        for (int i = 0; i < n; i++) {
            if (nums[i] > 0) {
                return i + 1;
            }
        }
        
        return n + 1;
    }
}

// Example 1:

// Input: nums = [1,2,0]
// Output: 3

// Example 2:

// Input: nums = [3,4,-1,1]
// Output: 2

// Example 3:

// Input: nums = [7,8,9,11,12]
// Output: 1
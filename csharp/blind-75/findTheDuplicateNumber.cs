public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow = nums[0];
        int fast = nums[0];
        
        while (true) {
            slow = nums[slow];
            fast = nums[nums[fast]];
            
            if (slow == fast) {
                break;
            }
        }
        
        slow = nums[0];
        
        while (slow != fast) {
            slow = nums[slow];
            fast = nums[fast];
        }
        
        return slow;
    }
}

// Example 1:

// Input: nums = [1,3,4,2,2]
// Output: 2

// Example 2:

// Input: nums = [3,1,3,4,2]
// Output: 3
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> uniqueElements = new(nums);
        
        return uniqueElements.Count < nums.Length;
    }
}

// Another approach would be to use a dictionary and populate the count of each element along with the key.
// The key with value greater than 1 would be the answer.

// Example 1:

// Input: nums = [1,2,3,1]
// Output: true

// Example 2:

// Input: nums = [1,2,3,4]
// Output: false

// Example 3:

// Input: nums = [1,1,1,3,3,4,3,2,4,2]
// Output: true
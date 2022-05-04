public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numbers = new(nums);
        
        int maxSequence = 0;
        
        foreach (int num in nums) {
            if (!numbers.Contains(num - 1)) {
                int minimum = num + 1;
                while (numbers.Contains(minimum)) {
                    numbers.Remove(minimum);
                    minimum++;
                }
                
                maxSequence = Math.Max(maxSequence, minimum - num);
            }
        }
        
        return maxSequence;
    }
}

// Example 1:

// Input: nums = [100,4,200,1,3,2]
// Output: 4
// Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.

// Example 2:

// Input: nums = [0,3,7,2,5,8,4,6,0,1]
// Output: 9
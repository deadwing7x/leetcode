// Using Boyer - Moore Voting Algorithm.

public class Solution {
    public int MajorityElement(int[] nums) {
        int majorityCandidate = findMajorityCandidate(nums);
        
        int count = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == majorityCandidate) {
                count++;
            }
        }
        
        if (count > nums.Length / 2) {
            return majorityCandidate;
        }
        
        return 0;
    }
    
    public int findMajorityCandidate(int[] nums) {
        int majorityCandidateIndex = 0;
        int currentCount = 1;
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[majorityCandidateIndex] == nums[i]) {
                currentCount++;
            } else {
                currentCount--;
                
                if (currentCount is 0) {
                    majorityCandidateIndex = i;
                    currentCount = 1;
                }
            }
        }
        
        return nums[majorityCandidateIndex];
    }
}

// Example 1:

// Input: nums = [3,2,3]
// Output: 3

// Example 2:

// Input: nums = [2,2,1,1,1,2,2]
// Output: 2
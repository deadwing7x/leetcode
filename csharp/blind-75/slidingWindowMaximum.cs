using System.Text.Json;

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums.Length is 0) {
            return new int[0];
        }
        
        if (nums.Length is 1 || k is 1) {
            return nums;
        }
        
        LinkedList<int> dequeue = new();
        
        List<int> maxSlidingWindow = new();
        
        for (int i = 0; i < nums.Length; i++) {
            while (dequeue.Count > 0 && nums[i] >= nums[dequeue.Last.Value]) {
                dequeue.RemoveLast();
            }
            
            dequeue.AddLast(i);
            
            int left = i - k + 1;
            
            if (dequeue.First.Value < left) {
                dequeue.RemoveFirst();
            }
            
            if (left >= 0) {
                maxSlidingWindow.Add(nums[dequeue.First.Value]);
            }
        }
        
        return maxSlidingWindow.ToArray();
    }
}

// Example 1:

// Input: nums = [1,3,-1,-3,5,3,6,7], k = 3
// Output: [3,3,5,5,6,7]

// Explanation: 
// Window position                Max
// ---------------               -----
// [1  3  -1] -3  5  3  6  7       3
//  1 [3  -1  -3] 5  3  6  7       3
//  1  3 [-1  -3  5] 3  6  7       5
//  1  3  -1 [-3  5  3] 6  7       5
//  1  3  -1  -3 [5  3  6] 7       6
//  1  3  -1  -3  5 [3  6  7]      7

// Example 2:

// Input: nums = [1], k = 1
// Output: [1]
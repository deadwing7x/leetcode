public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new();
        
        foreach (int num in nums) {
            if (!frequency.ContainsKey(num)) {
                frequency.Add(num, 1);
            } else {
                int count = frequency[num];
                frequency[num] = count + 1;
            }
        }
        
        return frequency.OrderByDescending(x => x.Value).Take(k)
            .Select(x => x.Key).ToArray();
    }
}

// Example 1:

// Input: nums = [1,1,1,2,2,3], k = 2
// Output: [1,2]

// Example 2:

// Input: nums = [1], k = 1
// Output: [1]
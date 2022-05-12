public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        if (nums.Length is 1) {
            return new List<IList<int>>() { nums };
        }
        
        IList<IList<int>> result = new List<IList<int>>();
        
        Permutate(nums, result, 0, nums.Length - 1);
        
        return result;
    }
    
    private void Permutate(
        int[] nums, IList<IList<int>> result, int left, int right
    ) {
        if (left == right) {
            result.Add(nums.ToList());
        } else {
            for (int i = left; i <= right; i++) {
                (nums[left], nums[i]) = (nums[i], nums[left]);
                Permutate(nums, result, left + 1, right);
                (nums[left], nums[i]) = (nums[i], nums[left]);
            }
        }
    }
}

// Example 1:

// Input: nums = [1,2,3]
// Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]

// Example 2:

// Input: nums = [0,1]
// Output: [[0,1],[1,0]]

// Example 3:

// Input: nums = [1]
// Output: [[1]]
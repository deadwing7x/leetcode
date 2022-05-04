public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        
        IList<IList<int>> result = new List<IList<int>>();
        
        for (int i = 0; i < nums.Length -2; i++) {
            if (i == 0 || nums[i] != nums[i - 1]) {
                int left = i + 1;
                int right = nums.Length - 1;
                int sum = 0 - nums[i];
            
                while(left < right){
                    if (nums[left] + nums[right] < sum) {
                        left++;
                    } else if (nums[left] + nums[right] > sum) {
                        right--;
                    } else {
                        result.Add(new List<int>{nums[i], nums[left], nums[right]});
                        left++;
                        right--;
                        
                        while (left < right && nums[left] == nums[left - 1]) {
                            left++;
                        }
                        
                        while (left < right && nums[right] == nums[right + 1]) {
                            right--;
                        }   
                    }
                }
            }
        }
        
        return result;
    }
}

// Example 1:

// Input: nums = [-1,0,1,2,-1,-4]
// Output: [[-1,-1,2],[-1,0,1]]

// Example 2:

// Input: nums = []
// Output: []

// Example 3:

// Input: nums = [0]
// Output: []
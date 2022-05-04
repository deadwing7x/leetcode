public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longestSubstringCount = 0;
        
        int startIndex = 0;
        int windowIndex = 0;
        
        HashSet<char> visited = new(s.Length);
        
        while (windowIndex < s.Length) {
            if (!visited.Contains(s[windowIndex])) {
                visited.Add(s[windowIndex]);
                windowIndex++;
                longestSubstringCount
                    = Math.Max(longestSubstringCount, visited.Count);
            } else {
                visited.Remove(s[startIndex]);
                startIndex++;
            }
        }
        
        return longestSubstringCount;
    }
}

// Example 1:

// Input: s = "abcabcbb"
// Output: 3
// Explanation: The answer is "abc", with the length of 3.

// Example 2:

// Input: s = "bbbbb"
// Output: 1
// Explanation: The answer is "b", with the length of 1.

// Example 3:

// Input: s = "pwwkew"
// Output: 3
// Explanation: The answer is "wke", with the length of 3.
// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
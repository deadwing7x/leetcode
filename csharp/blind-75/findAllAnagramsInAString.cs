public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        if (p.Length > s.Length) {
            return new List<int>();
        }
        
        IList<int> result = new List<int>();
        
        int[] charCount = new int[26];
        foreach (char c in p) {
            charCount[c - 'a']++;
        }
        
        int left = 0;
        int right = 0;
        int count = p.Length;
        
        while (right < s.Length) {
            if (charCount[s[right++] - 'a']-- >= 1) {
                count--;
            }
            
            if (count is 0) {
                result.Add(left);
            }
            
            if (right - left == p.Length && charCount[s[left++] - 'a']++ >= 0) {
                count++;
            }
        }
        
        return result;
    }
}

// Example 1:

// Input: s = "cbaebabacd", p = "abc"
// Output: [0,6]
// Explanation:
// The substring with start index = 0 is "cba", which is an anagram of "abc".
// The substring with start index = 6 is "bac", which is an anagram of "abc".

// Example 2:

// Input: s = "abab", p = "ab"
// Output: [0,1,2]
// Explanation:
// The substring with start index = 0 is "ab", which is an anagram of "ab".
// The substring with start index = 1 is "ba", which is an anagram of "ab".
// The substring with start index = 2 is "ab", which is an anagram of "ab".
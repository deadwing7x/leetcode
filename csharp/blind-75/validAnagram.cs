public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> letters = new();
        
        foreach (char c in s) {
            if (!letters.ContainsKey(c)) {
                letters.Add(c, 1);
            } else {
                int count = letters[c];
                letters[c] = count + 1;
            }
        }
        
        foreach (char c in t) {
            if (letters.ContainsKey(c)) {
                int count = letters[c];
                letters[c] = count - 1;
            } else {
                letters.Add(c, 1);
            }
        }
        
        return letters.All(x => x.Value == 0);
    }
}

// Example 1:

// Input: s = "anagram", t = "nagaram"
// Output: true

// Example 2:

// Input: s = "rat", t = "car"
// Output: false
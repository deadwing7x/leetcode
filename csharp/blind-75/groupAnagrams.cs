// Using dictionary and sorting.

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if (strs.Length is 0) {
            return new List<IList<string>>();
        }
        
        Dictionary<string, IList<string>> countMap = new();
        
        foreach (string s in strs) {
            char[] characters = s.ToCharArray();
            Array.Sort(characters);
            
            string key = string.Join(string.Empty, characters);
            
            if (countMap.ContainsKey(key)) {
                countMap[key].Add(s);
            } else {
                countMap.Add(key, new List<string>() { s });
            }
        }
        
        return countMap.Values.ToList();
    }
}

// Using dictionary, count characters, create string from count array.

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if (strs.Length is 0) {
            return new List<IList<string>>();
        }
        
        Dictionary<string, IList<string>> countMap = new();
        
        foreach (string s in strs) {
            int[] count = new int[26];
            
            for (int i = 0; i < s.Length; i++) {
                int index = (int)s[i] - 97;
                
                count[index]++;
            }
            
            string key = string.Empty;
            
            for (int i = 0; i < 26; i++) {
                if (count[i] is not 0) {
                    key += $"{count[i]}{((char)(i + 97)).ToString()}";
                }
            }
            
            if (countMap.ContainsKey(key)) {
                countMap[key].Add(s);
            } else {
                countMap.Add(key, new List<string>() { s });
            }
        }
        
        return countMap.Values.ToList();
    }
}

// Example 1:

// Input: strs = ["eat","tea","tan","ate","nat","bat"]
// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

// Example 2:

// Input: strs = [""]
// Output: [[""]]

// Example 3:

// Input: strs = ["a"]
// Output: [["a"]]
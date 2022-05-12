public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanMap = new() {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
        
        int result = 0;
        
        for (int i = 0; i < s.Length; i++) {
            if (i + 1 < s.Length && romanMap[s[i + 1]] > romanMap[s[i]]) {
                result += romanMap[s[i]]  * -1;
            } else {
                result += romanMap[s[i]];
            }
        }
        
        return result;
    }
}

// Example 1:

// Input: s = "III"
// Output: 3
// Explanation: III = 3.

// Example 2:

// Input: s = "LVIII"
// Output: 58
// Explanation: L = 50, V= 5, III = 3.

// Example 3:

// Input: s = "MCMXCIV"
// Output: 1994
// Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
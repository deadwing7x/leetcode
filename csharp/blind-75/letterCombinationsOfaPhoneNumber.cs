public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if (digits.Length is 0) {
            return new List<string>();
        }
        
        IList<string> result = new List<string>();
        
        Dictionary<char, List<char>> numberMap = new() {
            { '2', new List<char> { 'a', 'b', 'c' } },
            { '3', new List<char> { 'd', 'e', 'f' } },
            { '4', new List<char> { 'g', 'h', 'i' } },
            { '5', new List<char> { 'j', 'k', 'l' } },
            { '6', new List<char> { 'm', 'n', 'o' } },
            { '7', new List<char> { 'p', 'q', 'r', 's' } },
            { '8', new List<char> { 't', 'u', 'v' } },
            { '9', new List<char> { 'w', 'x', 'y', 'z' } },
        };
        
        foreach (char c in digits) {
            List<char> numbers = numberMap[c];
            
            IList<string> temp = new List<string>();
            
            if (result.Count is 0) {
                foreach (char n in numbers) {
                    result.Add(n + string.Empty);
                }
            }
            else {
                foreach (string s in result) {
                    foreach (char n in numbers) {
                        temp.Add(s + n);
                    }
                }
                
                result = temp;
            }
        }
        
        return result;
    }
}

// Example 1:

// Input: digits = "23"
// Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]

// Example 2:

// Input: digits = ""
// Output: []

// Example 3:

// Input: digits = "2"
// Output: ["a","b","c"]
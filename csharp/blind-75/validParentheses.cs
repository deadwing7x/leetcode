public class Solution {
    public bool IsValid(string s) {
        Stack<char> elements = new();
        
        Dictionary<char, char> complementParentheses = new() {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' },
        };
        
        for (int i = 0; i < s.Length; i++) {
            if (complementParentheses.ContainsKey(s[i])) {
                elements.Push(s[i]);
            } else {
                if (elements.Count is 0) {
                    return false;
                } else {
                    if (string.Equals(s[i], complementParentheses[elements.Peek()])) {
                        elements.Pop();
                    }
                    else {
                        return false;
                    }
                }
            }
        }
        
        return elements.Count == 0;
    }
}

// Example 1:

// Input: s = "()"
// Output: true

// Example 2:

// Input: s = "()[]{}"
// Output: true

// Example 3:

// Input: s = "(]"
// Output: false
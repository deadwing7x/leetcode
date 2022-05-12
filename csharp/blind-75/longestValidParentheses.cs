// Using stack, Time - O(N) Space - O(N)

public class Solution {
    public int LongestValidParentheses(string s) {
        if (s.Length is 0) {
            return 0;
        }
        
        Stack<int> characters = new();
        characters.Push(-1);
        
        int count = 0;
        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                characters.Push(i);
            } else {
                characters.Pop();
                
                if (characters.Count is 0) {
                    characters.Push(i);
                } else {
                    count = Math.Max(count, i - characters.Peek());
                }
            }
        }
        
        return count;
    }
}

// Using two pass two pointer approach to keep track of left and right parentheses count.

public class Solution {
    public int LongestValidParentheses(string s) {
        if (s.Length is 0 or 1) {
            return 0;
        }
        
        int maxLength = 0;
        
        int leftBracket = 0;
        int rightBracket = 0;
        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                leftBracket++;
            } else {
                rightBracket++;
            }
            
            if (leftBracket == rightBracket) {
                maxLength = Math.Max(maxLength, 2 * rightBracket);
            } else if (rightBracket >= leftBracket) {
                leftBracket = rightBracket = 0;
            }
        }
        
        leftBracket = 0;
        rightBracket = 0;
        
        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] == '(') {
                leftBracket++;
            } else {
                rightBracket++;
            }
            
            if (leftBracket == rightBracket) {
                maxLength = Math.Max(maxLength, 2 * leftBracket);
            } else if (leftBracket >= rightBracket) {
                leftBracket = rightBracket = 0;
            }
        }
        
        return maxLength;
    }
}

// Example 1:

// Input: s = "(()"
// Output: 2
// Explanation: The longest valid parentheses substring is "()".

// Example 2:

// Input: s = ")()())"
// Output: 4
// Explanation: The longest valid parentheses substring is "()()".

// Example 3:

// Input: s = ""
// Output: 0
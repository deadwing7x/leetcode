public class Solution {
    public int MyAtoi(string s) {
        if (s.Length is 0) {
            return 0;
        }
        
        Stack<char> digits = new();
        
        bool isNegative = false;
        int index = 0;
        int number = 0;
        
        while (index < s.Length && s[index] == ' ') {
            index++;
        }
        
        if (index < s.Length && s[index] == '-') {
            isNegative = true;
            index++;
        } else if (index < s.Length && s[index] == '+') {
            index++;
        }
        
        while (index < s.Length && char.IsNumber(s[index])) {
            int currentDigit = s[index] - '0';
            
            if ((number > int.MaxValue / 10) ||
                (number == int.MaxValue / 10 && currentDigit > int.MaxValue % 10)) {
                return isNegative ? int.MinValue : int.MaxValue;
            }
            
            number = 10 * number + currentDigit;
            index++;
        }
        
        if (isNegative) {
            number *= -1;
        }
        
        return number;
    }
}

// Example 1:

// Input: s = "42"
// Output: 42
// Explanation: The underlined characters are what is read in, the caret is the current reader position.
// Step 1: "42" (no characters read because there is no leading whitespace)
//          ^
// Step 2: "42" (no characters read because there is neither a '-' nor '+')
//          ^
// Step 3: "42" ("42" is read in)
//            ^
// The parsed integer is 42.
// Since 42 is in the range [-231, 231 - 1], the final result is 42.

// Example 2:

// Input: s = "   -42"
// Output: -42
// Explanation:
// Step 1: "   -42" (leading whitespace is read and ignored)
//             ^
// Step 2: "   -42" ('-' is read, so the result should be negative)
//              ^
// Step 3: "   -42" ("42" is read in)
//                ^
// The parsed integer is -42.
// Since -42 is in the range [-231, 231 - 1], the final result is -42.

// Example 3:

// Input: s = "4193 with words"
// Output: 4193
// Explanation:
// Step 1: "4193 with words" (no characters read because there is no leading whitespace)
//          ^
// Step 2: "4193 with words" (no characters read because there is neither a '-' nor '+')
//          ^
// Step 3: "4193 with words" ("4193" is read in; reading stops because the next character is a non-digit)
//              ^
// The parsed integer is 4193.
// Since 4193 is in the range [-231, 231 - 1], the final result is 4193.
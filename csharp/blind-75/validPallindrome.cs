public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrWhiteSpace(s)) {
            return true;
        }
        
        Stack<char> charElements = new();
        
        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                charElements.Push(Char.ToLower(c));
            }
        }
        
        List<char> elements = charElements.ToList();
        
        for (int i = 0, j = elements.Count - 1; i < elements.Count / 2; i++, j--) {
            if (elements[i] != elements[j]) {
                return false;
            }
        }
        
        return true;
    }
}

// Example 1:

// Input: s = "A man, a plan, a canal: Panama"
// Output: true
// Explanation: "amanaplanacanalpanama" is a palindrome.

// Example 2:

// Input: s = "race a car"
// Output: false
// Explanation: "raceacar" is not a palindrome.

// Example 3:

// Input: s = " "
// Output: true
// Explanation: s is an empty string "" after removing non-alphanumeric characters.
// Since an empty string reads the same forward and backward, it is a palindrome.
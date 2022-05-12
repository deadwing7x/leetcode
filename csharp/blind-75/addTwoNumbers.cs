/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1 is null && l2 is null) {
            return null;
        }
        
        ListNode dummyHead = new(0);
        ListNode l3 = dummyHead;
        
        int carry = 0;
        
        while (l1 is not null || l2 is not null) {
            int l1Val = l1 is not null ? l1.val : 0;
            int l2Val = l2 is not null ? l2.val : 0;
            
            int currentSum = l1Val + l2Val + carry;
            
            carry = currentSum / 10;
            int currentDigit = currentSum % 10;
            
            ListNode currentNode = new(currentDigit);
            l3.next = currentNode;
            
            if (l1 != null) {
                l1 = l1.next;
            }
            
            if (l2 != null) {
                l2 = l2.next;
            }
            
            l3 = l3.next;
        }
        
        if (carry > 0) {
            ListNode carryNode = new(carry);
            l3.next = carryNode;
            l3 = l3.next;
        }
        
        return dummyHead.next;
    }
}

// Example 1:

// Input: l1 = [2,4,3], l2 = [5,6,4]
// Output: [7,0,8]
// Explanation: 342 + 465 = 807.

// Example 2:

// Input: l1 = [0], l2 = [0]
// Output: [0]

// Example 3:

// Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
// Output: [8,9,9,9,0,0,0,1]
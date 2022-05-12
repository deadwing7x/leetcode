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
    public bool IsPalindrome(ListNode head) {
        if (head is null) {
            return false;
        }
        
        if (head.next is null) {
            return true;
        }
        
        ListNode slow = head.next;
        ListNode fast = head.next?.next;
        
        while (fast is not null) {
            slow = slow.next;
            fast = fast.next?.next;
        }
        
        slow = reverseLinkedList(slow);
        fast = head;
        
        while (slow != null) {
            if (slow.val != fast.val) {
                return false;
            } else {
                fast = fast.next;
                slow = slow.next;
            }
        }
        
        return true;
    }
    
    private ListNode reverseLinkedList(ListNode head) {
        ListNode prev = null;
        
        while (head is not null) {
            ListNode newHead = head.next;
            head.next = prev;
            prev = head;
            head = newHead;
        }
        
        return prev;
    }
}

// Example 1:

// Input: head = [1,2,2,1]
// Output: true

// Example 2:

// Input: head = [1,2]
// Output: false
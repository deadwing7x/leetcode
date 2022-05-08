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
    public void ReorderList(ListNode head) {
        if (head is null || head.next is null) {
            return;
        }
        
        ListNode firstHead = head;
        ListNode secondHead = head;
        ListNode firstEnd = null;
        ListNode secondEnd = head;
        
        while (secondEnd is not null && secondEnd.next is not null) {
            firstEnd = secondHead;
            secondHead = secondHead.next;
            secondEnd = secondEnd.next.next;
        }
        
        firstEnd.next = null;
        
        secondHead = reverseList(secondHead);
        
        mergeList(firstHead, secondHead);
    }
    
    public ListNode reverseList(ListNode head) {
        ListNode prev = null;
        
        while (head is not null) {
            ListNode nextNode = head.next;
            head.next = prev;
            prev = head;
            head = nextNode;
        }
        
        return prev;
    }
    
    public void mergeList(ListNode l1, ListNode l2) {
        while (l1 is not null) {
            ListNode l1Next = l1.next;
            ListNode l2Next = l2.next;
            
            l1.next = l2;
            
            if (l1Next is null) {
                break;
            }
            
            l2.next = l1Next;
            
            l1 = l1Next;
            l2 = l2Next;
        }
    }
}

// Example 1:

// Input: head = [1,2,3,4]
// Output: [1,4,2,3]

// Example 2:

// Input: head = [1,2,3,4,5]
// Output: [1,5,2,4,3]
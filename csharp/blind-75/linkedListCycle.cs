/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head is null || head.next is null) {
            return false;
        }
        
        if (head == head.next) {
            return true;
        }
        
        ListNode slowRunner = head.next;
        ListNode fastRunner = head.next?.next;
        
        while(fastRunner is not null)
        {
            fastRunner = fastRunner.next?.next;
            slowRunner = slowRunner.next;
            
            if(fastRunner == slowRunner) {
                return true;
            }
        }
        
        return false;
    }
}


// Example 1:

// Input: head = [3,2,0,-4], pos = 1
// Output: true
// Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).

// Example 2:

// Input: head = [1,2], pos = 0
// Output: true
// Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.

// Example 3:

// Input: head = [1], pos = -1
// Output: false
// Explanation: There is no cycle in the linked list.
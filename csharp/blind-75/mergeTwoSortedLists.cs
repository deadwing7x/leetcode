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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode sortedHead = new();
        ListNode currentHead = sortedHead;
        
        while (list1 is not null && list2 is not null) {
            if (list1.val < list2.val) {
                currentHead.next = list1;
                list1 = list1.next;
            } else {
                currentHead.next = list2;
                list2 = list2.next;
            }
            
            currentHead = currentHead.next;
        }
        
        if (list1 is not null) {
            currentHead.next = list1;
            list1 = list1.next;
        }
        
        if (list2 is not null) {
            currentHead.next = list2;
            list2 = list2.next;
        }
        
        return sortedHead.next;
    }
}

// Example 1:

// Input: list1 = [1,2,4], list2 = [1,3,4]
// Output: [1,1,2,3,4,4]

// Example 2:

// Input: list1 = [], list2 = []
// Output: []

// Example 3:

// Input: list1 = [], list2 = [0]
// Output: [0]
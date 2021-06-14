/*

Problem Statement: Given a linked list, swap every two adjacent nodes and return its head. 
You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)

Input: head = [1,2,3,4]
Output: [2,1,4,3]

Input: head = []
Output: []

*/

struct ListNode
{
    int val;
    ListNode *next;
};

ListNode *swapPairsHelper(ListNode *head)
{
    if (head == NULL || head->next == NULL)
    {
        return head;
    }

    ListNode *newHead, *repeatFromThisNode;
    newHead = head->next;
    repeatFromThisNode = newHead->next;

    newHead->next = head;
    head->next = swapPairsHelper(repeatFromThisNode);

    return newHead;
}

ListNode *swapPairs(ListNode *head)
{
    return swapPairsHelper(head);
}
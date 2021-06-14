/*

Problem Statement: Given a non-empty, singly linked list with head node head, return a middle node of linked list.
If there are two middle nodes, return the second middle node.

Input: [1,2,3,4,5]
Output: Node 3 from this list (Serialization: [3,4,5])

Input: [1,2,3,4,5,6]
Output: Node 4 from this list (Serialization: [4,5,6])

*/

struct ListNode
{
    int val;
    ListNode *next;
};

ListNode *middleNode(ListNode *head)
{
    int len = 1;

    ListNode *curr = head;

    while (curr->next != NULL)
    {
        len++;
        curr = curr->next;
    }

    for (int i = 1; i < len / 2 + 1; i++)
    {
        head = head->next;
    }

    return head;
}
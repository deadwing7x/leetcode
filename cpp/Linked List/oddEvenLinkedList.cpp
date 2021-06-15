/*

Problem Statement: Given the head of a singly linked list, group all the nodes with odd indices together followed by the nodes with even indices, and return the reordered list.
The first node is considered odd, and the second node is even, and so on. 

Note that the relative order inside both the even and odd groups should remain as it was in the input.

Input: head = [1,2,3,4,5]
Output: [1,3,5,2,4]

*/

struct ListNode
{
    int val;
    ListNode *next;
};

ListNode *oddEvenList(ListNode *head)
{
    if (head == NULL || head->next == NULL)
    {
        return head;
    }

    int len = 1;

    ListNode *curr = head;
    while (curr->next != NULL)
    {
        len++;
        curr = curr->next;
    }

    ListNode *newHead = new ListNode(head->next->val);
    newHead->next = head->next->next;
    for (int i = 2; i <= len; i++)
    {
        if (i % 2 == 0)
        {
            ListNode *temp = new ListNode(newHead->val);
            curr->next = temp;
            curr = curr->next;
            newHead = newHead->next;
        }
        else
        {
            newHead = newHead->next;
        }
    }

    ListNode *it = head->next;
    for (int i = 2; i <= len; i = i + 2)
    {
        ListNode *temp = it->next;
        it->val = temp->val;
        it->next = temp->next;
        it = it->next;
    }

    return head;
}
/* 

Problem Statement: Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, 
and return the new head.

Input: head = [1,2,6,3,4,5,6], val = 6
Output: [1,2,3,4,5]

*/

struct ListNode
{
    int val;
    ListNode *next;
};

ListNode *removeElements(ListNode *head, int val)
{
    if (head == NULL)
    {
        return head;
    }

    ListNode *curr = head;

    while (curr->next != NULL)
    {
        if (curr->val == val)
        {
            head = head->next;
            curr = head;
        }
        else if (curr->next->val == val)
        {
            curr->next = curr->next->next;
        }
        else
        {
            curr = curr->next;
        }
    }

    if (head->next == NULL && head->val == val)
    {
        head = NULL;

        return head;
    }

    return head;
}
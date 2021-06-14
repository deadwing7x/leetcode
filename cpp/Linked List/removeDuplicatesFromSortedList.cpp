/* 

Problem Statement: Given the head of a sorted linked list, delete all duplicates such that each element appears only once. 
Return the linked list sorted as well. 

Input: head = [1,1,2]
Output: [1,2]

*/

struct ListNode
{
    int val;
    ListNode *next;
};

ListNode *deleteDuplicates(ListNode *head)
{
    if (head == NULL)
    {
        return head;
    }

    ListNode *curr = head;

    while (curr->next != NULL)
    {
        if (curr->val == curr->next->val)
        {
            curr->next = curr->next->next;
        }
        else
        {
            curr = curr->next;
        }
    }

    return head;
}
/*

Problem Statement: Merge two sorted linked lists and return it as a sorted list. 
The list should be made by splicing together the nodes of the first two lists.

Input: l1 = [1,2,4], l2 = [1,3,4]
Output: [1,1,2,3,4,4]

Input: l1 = [], l2 = [0]
Output: [0]

*/

struct ListNode
{
    int val;
    ListNode *next;
};

ListNode *mergeTwoLists(ListNode *l1, ListNode *l2)
{
    ListNode *sortedTemp = new ListNode();
    ListNode *currentHead = sortedTemp;

    while (l1 != NULL && l2 != NULL)
    {
        if (l1->val < l2->val)
        {
            currentHead->next = l1;
            l1 = l1->next;
        }
        else
        {
            currentHead->next = l2;
            l2 = l2->next;
        }

        currentHead = currentHead->next;
    }

    if (l1 != NULL)
    {
        currentHead->next = l1;
        l1 = l1->next;
    }

    if (l2 != NULL)
    {
        currentHead->next = l2;
        l2 = l2->next;
    }

    return sortedTemp->next;
}
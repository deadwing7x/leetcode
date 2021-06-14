/*

Problem Statement: Given the head of a linked list, return the list after sorting it in ascending order.

Follow up: Can you sort the linked list in O(n logn) time and O(1) memory (i.e. constant space)?

Input: head = [4,2,1,3]
Output: [1,2,3,4]

*/

struct ListNode
{
    int val;
    ListNode *next;
};

ListNode *sortList(ListNode *head)
{
    if (head == NULL || head->next == NULL)
    {
        return head;
    }

    ListNode *fast = head;
    ListNode *slow = head;
    ListNode *temp = head;

    while (fast != NULL && fast->next != NULL)
    {
        temp = slow;
        slow = slow->next;
        fast = fast->next->next;
    }

    temp->next = NULL;

    ListNode *leftList = sortList(head);
    ListNode *rightList = sortList(slow);

    return mergeList(leftList, rightList);
}

ListNode *mergeList(ListNode *l1, ListNode *l2)
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
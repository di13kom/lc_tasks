using LeetCode.Problems.Common;

namespace LeetCode.Problems._19;

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int cStep = 0;
        ListNode targetNode = head;
        ListNode curNode = head;

        while (curNode is not null)
        {
            curNode = curNode.next;

            if (cStep++ >= n + 1)
            {
                targetNode = targetNode?.next;
            }
        }
        if (cStep - n == 0)
        {
            head = head.next;
        }
        else
        {
            targetNode.next = targetNode.next?.next;
        }


        return head;

    }
}
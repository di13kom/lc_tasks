using LeetCode.Problems.Common;

namespace LeetCode.Problems._25;

public class Solution
{

    public ListNode ReverseKGroup(ListNode head, int k)
    {
        int counter = 1;

        if (k <= 1)
            return head;

        ListNode dummyHead = new ListNode(-1, head);

        ListNode ln = dummyHead;

        do
        {
            ln = Recursion(ln.next, ln, k, counter);
        } while (ln is not null);

        return dummyHead.next;
    }

    private ListNode Recursion(ListNode head, ListNode slowHead, int k, int curStep)
    {
        if (head is null)
            return null;
        if (curStep == k)
        {
            var targetNode0 = head.next;
            var targetNode1 = slowHead.next;

            targetNode1.next = targetNode0;
            head.next = targetNode1;

            slowHead.next = head;

            return slowHead.next;
        }
        var newHead = Recursion(head.next, slowHead, k, ++curStep);
        if (newHead is not null && newHead.next != head)
        {
            var tmp = newHead.next;
            head.next = tmp;
            newHead.next = head;
        }

        return newHead?.next;
    }
}

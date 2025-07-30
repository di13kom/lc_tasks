using LeetCode.Problems.Common;

namespace LeetCode.Problems._24;

public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {

        if (head is null)
            return null;

        var dummyNode = new ListNode(0, head);

        SwapPairsInternal(dummyNode);

        return dummyNode.next;
    }

    private void SwapPairsInternal(ListNode head)
    {
        if (head.next is null || head.next.next is null)
            return;

        var tmp = head.next;
        var tmp1 = head.next.next;
        var tmp2 = head.next.next.next;

        head.next = tmp1;
        tmp.next = tmp2;
        tmp1.next = tmp;

        SwapPairsInternal(head.next.next);
    }
}
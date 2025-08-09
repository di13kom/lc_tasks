using LeetCode.Problems.Common;

namespace LeetCode.Problems._160;

public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        int headACount = 0, headBCount = 0;
        var retVal = ListNodeTraverseRecursive(headA, headB, ref headACount, ref headBCount);

        return retVal;
    }

    private ListNode ListNodeTraverseRecursive(ListNode headA, ListNode headB, ref int headACount, ref int headBCount)
    {
        if (headA.next is null && headB.next is null)
        {
            //reach tail both heads
            if (headA == headB)
                return new ListNode(headA.val);
            return null;//return null if tails is not the same
        }
        headACount = headA.next == null ? headACount : headACount + 1;
        headBCount = headB.next == null ? headBCount : headBCount + 1;

        var res = ListNodeTraverseRecursive(headA?.next ?? headA, headB?.next ?? headB, ref headACount, ref headBCount);

        if (res == null)//skip different tails
            return null;
        if (headA.next == null || headB.next == null)//skip small ListNode, while next node is null
        {
            return res;
        }

        var node = headACount >= headBCount ? headA : headB;//choose long ListNode
        for (int i = 0; i < Math.Abs(headBCount - headACount); i++)
        {
            node = node.next;//iterate to find node in long ListNode, to match with small ListNode
        }

        if (headACount >= headBCount && node == headB)
        {
            return new ListNode(headB.val, res);
        }
        else if (headACount < headBCount && node == headA)
        {
            return new ListNode(headA.val, res);
        }

        return res;
    }

}

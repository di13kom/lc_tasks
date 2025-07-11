using LeetCode.Problems.Common;

namespace LeetCode.Problems._2;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode retVal = null;
        ListNode prevNode = null;
        bool IsprevMoreThenTen = false;

        do
        {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + (IsprevMoreThenTen ? 1 : 0);
            IsprevMoreThenTen = sum >= 10;

            var curNode = new ListNode(sum % 10);
            retVal ??= curNode;
            if (prevNode is not null)
                prevNode.next = curNode;
            prevNode = curNode;

            l1 = l1?.next;
            l2 = l2?.next;
        }
        while (l1 != null || l2 != null || IsprevMoreThenTen);

        return retVal;
    }
}
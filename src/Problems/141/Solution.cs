using LeetCode.Problems.Common;

namespace LeetCode.Problems._141;

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        HashSet<int> dict = [];

        if (head is null || head.next is null)
            return false;

        ListNode alwaysHead = head;

        while (head.next is not null)
        {
            if (!dict.Add(head.val))
            {
                var tmpHead = alwaysHead;
                while (tmpHead.val != head.val)
                {
                    tmpHead = tmpHead.next;
                }
                if (tmpHead == head)
                    return true;
            }
            head = head.next;
        }

        return false;
    }
}
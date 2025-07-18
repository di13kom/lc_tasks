using LeetCode.Problems.Common;

namespace LeetCode.Problems._83;

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var curNode = head;
        ListNode nextNode;
        while (curNode is not null)
        {
            nextNode = curNode.next;
            if (nextNode?.val == curNode.val)
            {
                while (nextNode is not null && curNode.val == nextNode.val)
                {
                    nextNode = nextNode.next;
                }
                curNode.next = nextNode;
            }

            curNode = nextNode;
        }

        return head;

    }
}
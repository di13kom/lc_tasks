using LeetCode.Problems.Common;

namespace LeetCode.Problems._1721;

public class Solution
{
    public ListNode SwapNodes(ListNode head, int k)
    {
        int counter = 0;

        ListNode dummyHead = new ListNode(-1, head);
        ListNode firstNodeToSwap = dummyHead;
        ListNode secondNodeToSwap = dummyHead;

        while (head is not null)
        {
            if (++counter == (k - 1) && head.next is not null)
            {
                firstNodeToSwap = head;
            }
            head = head.next;
            secondNodeToSwap = (counter >= (k + 1)) ? secondNodeToSwap.next : secondNodeToSwap;
        }
        if (k + k > counter)
        {
            var tmp_ = secondNodeToSwap;
            secondNodeToSwap = firstNodeToSwap;
            firstNodeToSwap = tmp_;
        }
        if (firstNodeToSwap.next == secondNodeToSwap)
        {
            var tmp2 = secondNodeToSwap.next;
            var tmp1 = firstNodeToSwap.next;

            secondNodeToSwap.next = tmp2.next;
            firstNodeToSwap.next = tmp2;
            tmp2.next = secondNodeToSwap;
        }
        else
        {
            var tmp2 = secondNodeToSwap;
            var postpost2node = secondNodeToSwap.next?.next;
            var tmp1 = firstNodeToSwap.next;
            var postpost1node = firstNodeToSwap.next?.next;


            firstNodeToSwap.next = secondNodeToSwap.next;
            secondNodeToSwap.next.next = postpost1node;

            tmp2.next = tmp1;
            tmp1.next = postpost2node;

        }

        return dummyHead.next;
    }
}
using LeetCode.Problems.Common;

namespace LeetCode.Problems._142;

public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        Dictionary<int, List<int>> dict = [];

        if (head is null || head.next is null)
            return null;

        ListNode alwaysHead = head;
        int counter = 0;

        while (head.next is not null)
        {
            if (!dict.TryAdd(head.val, [counter]))
            {
                var tmpHead = alwaysHead;
                var tmpCounter = 0;
                foreach (var item in dict[head.val])
                {
                    while (tmpHead.val != head.val)
                    {
                        tmpHead = tmpHead.next;
                        ++tmpCounter;
                    }
                    if (tmpHead == head)
                        return head;

                    tmpHead = tmpHead.next;
                }
                dict[head.val].Add(counter);

            }
            counter++;
            head = head.next;
        }


        return null;
    }
}
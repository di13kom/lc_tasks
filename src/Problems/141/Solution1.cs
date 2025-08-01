using LeetCode.Problems.Common;
namespace LeetCode.Problems._141;

public class Solution1
{
    public bool HasCycle(ListNode head)
    {
        Dictionary<int, List<int>> dict = [];

        if (head is null || head.next is null)
            return false;

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
                        return true;

                    tmpHead = tmpHead.next;
                }
                dict[head.val].Add(counter);

            }
            counter++;
            head = head.next;
        }
        return false;
    }
}
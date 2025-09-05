using LeetCode.Problems.Common;

namespace LeetCode.Problems._2074;

public class Solution
{
    public ListNode ReverseEvenLengthGroups(ListNode head)
    {
        int iter = 0;
        int oddGroupStart = 0;
        int oddGroupLength = 1;
        int evenGroupStart = 0;
        int evenGroupLength = 2;
        var newHead = head;
        int curGroupCount = 0;
        ListNode groupStartHead = head;

        while (newHead is not null)
        {
            if (iter == evenGroupStart + evenGroupLength || (newHead.next is null && curGroupCount % 2 == 0 && iter > 0))//end even group or last group
            {
                newHead = TraverseGroup(groupStartHead, curGroupCount / 2 - 1);
                oddGroupStart = evenGroupStart + evenGroupLength;
                evenGroupLength += 2;
                oddGroupLength += 2;
                evenGroupStart = oddGroupStart + oddGroupLength;
                curGroupCount = 0;
                groupStartHead = newHead;
            }
            else if (iter == oddGroupStart + oddGroupLength && iter > 1)//end odd group
            {
                groupStartHead = newHead;
                curGroupCount = 0;
            }

            iter++;
            newHead = newHead.next;
            curGroupCount++;
        }

        return head;
    }

    private ListNode TraverseGroup(ListNode curNode, int iterKey)
    {
        ListNode rightNode;
        ListNode leftNode = curNode.next;
        if (iterKey == 0)
        {
            rightNode = curNode.next.next;

            var tmp = rightNode.next;

            curNode.next = rightNode;
            rightNode.next = leftNode;
            leftNode.next = tmp;
        }
        else
        {
            var preRightNode = TraverseGroup(curNode.next, --iterKey);

            rightNode = preRightNode.next;
            var tmp = rightNode.next;

            curNode.next = rightNode;
            rightNode.next = leftNode.next;
            preRightNode.next = leftNode;
            leftNode.next = tmp;
        }


        return leftNode;
    }
}

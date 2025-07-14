using LeetCode.Problems.Common;

namespace LeetCode.Problems._1290;

public class Solution
{
    public int GetDecimalValue(ListNode head)
    {
        int retVal = 0;
        int curPosition = -1;
        int[] zeroOneArray = new int[30];

        do
        {
            zeroOneArray[++curPosition] = head.val;
            head = head.next;
        }
        while (head is not null);
        for (int i = curPosition; i >= 0; i--)
        {
            retVal += (int)(zeroOneArray[i] * Math.Pow(2, curPosition - i));
        }
        return retVal;
    }
}
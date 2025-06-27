using System;

namespace LeetCode.Problems.Common;

public static class ListNodeExtension
{
    public static ListNode ArrayToListNode(int[] ints)
    {
        ListNode retVal = null;

        for (int i = ints.Length - 1; i >= 0; i--)
        {
            int item = ints[i];
            retVal = new ListNode(item, retVal);
        }

        return retVal;
    }

    public static int[] ListNodeToArray(ListNode listNode)
    {
        List<int> retVal = [];
        if (listNode is null)
            return [];
        retVal.Add(listNode.val);
        while (listNode.next is not null)
        {
            retVal.Add(listNode.val);
            listNode = listNode.next;
        }

        return retVal.ToArray();
    }
}
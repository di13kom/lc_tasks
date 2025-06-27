using LeetCode.Problems.Common;

namespace LeetCode.Problems._21;


public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        return Merge(list1, list2);
    }

    private ListNode Merge(ListNode list1, ListNode list2)
    {
        ListNode retVal = null;

        if (list1 is null && list2 is null)
            return null;

        if (list1 == null)
        {
            retVal = new ListNode(list2.val)
            {
                next = Merge(list1, list2.next)
            };
        }
        else if (list2 == null)
        {
            retVal = new ListNode(list1.val)
            {
                next = Merge(list1.next, list2)
            };
        }
        else if (list1.val <= list2.val)
        {
            retVal = new(list1.val)
            {
                next = Merge(list1.next, list2)
            };
        }
        else
        {
            retVal = new(list2.val)
            {
                next = Merge(list1, list2.next)
            };
        }

        return retVal;
    }
}
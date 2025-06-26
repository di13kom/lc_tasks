using LeetCode.Problems._21;

namespace ProblemsUnitTests._21;

public class Problem21UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((ListNode input1, ListNode input2, ListNode expected) td)
    {
        Assert.That(ListNodeToArray(new Solution().MergeTwoLists(td.input1, td.input2)), Is.EqualTo(ListNodeToArray(td.expected)));
    }

    private static IEnumerable<(ListNode, ListNode, ListNode)> GetTestCaseDatas()
    {
        yield return (ArrayToListNode([1, 2, 4]), ArrayToListNode([1, 3, 4]), ArrayToListNode([1, 1, 2, 3, 4, 4]));
        yield return (ArrayToListNode([]), ArrayToListNode([]), ArrayToListNode([]));
        yield return (ArrayToListNode([]), ArrayToListNode([0]), ArrayToListNode([0]));
    }


    private static ListNode ArrayToListNode(int[] ints)
    {
        ListNode retVal = null;

        for (int i = ints.Length - 1; i >= 0; i--)
        {
            int item = ints[i];
            retVal = new ListNode(item, retVal);
        }

        return retVal;
    }

    private static int[] ListNodeToArray(ListNode listNode)
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

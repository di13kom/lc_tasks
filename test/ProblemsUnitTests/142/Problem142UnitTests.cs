using LeetCode.Problems._142;
using LeetCode.Problems.Common;
using static LeetCode.Problems.Common.ListNodeExtension;

namespace ProblemsUnitTests._142;

public class Problem142UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((ListNode input, ListNode expected) td)
    {
        Assert.That(new Solution().DetectCycle(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(ListNode, ListNode)> GetTestCaseDatas()
    {
        var array = ArrayToListNode([1, 2, 3, 2]);
        array.next.next.next = array;
        var array1 = ArrayToListNode([1, 2, 3, 2, 4, 5]);
        array1.next.next.next.next.next = array1.next;
        var array2 = ArrayToListNode([-1, -7, 7, -4, 19, 6, -9, -5, -2, -5]);
        array2.next.next.next.next.next.next.next.next.next = array2.next.next.next.next.next.next.next;

        yield return (array, array);
        yield return (array1, array1.next);
        yield return (array2, array2.next.next.next.next.next.next.next);
    }
}
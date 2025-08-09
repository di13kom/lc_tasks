using LeetCode.Problems._160;
using LeetCode.Problems.Common;

using static LeetCode.Problems.Common.ListNodeExtension;

namespace ProblemsUnitTests._160;

public class Problem160UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas)), Timeout(10000)]
    public void SolutionTest((ListNode input0, ListNode input1, ListNode expected) td)
    {
        Assert.That(ListNodeToArray(new Solution().GetIntersectionNode(td.input0, td.input1)), Is.EqualTo(ListNodeToArray(td.expected)));
    }

    private static IEnumerable<(ListNode, ListNode, ListNode)> GetTestCaseDatas()
    {
        ListNode common0 = ArrayToListNode([8, 4, 5]);
        ListNode common1 = ArrayToListNode([2, 4]);
        ListNode common2 = ArrayToListNode([9, 8, 7, 6, 5, 4, 3, 2, 1]);

        yield return (ArrayToListNode([4, 1]).Concat(common0), ArrayToListNode([5, 6, 1]).Concat(common0), common0);
        yield return (ArrayToListNode([1, 9, 1]).Concat(common1), ArrayToListNode([3]).Concat(common1), common1);
        yield return (ArrayToListNode([1, 9, 1, 6, 8, 7, 5]).Concat(common2), ArrayToListNode([3, 13, 5]).Concat(common2), common2);

        yield return (ArrayToListNode([2, 6, 4]), ArrayToListNode([1, 5]), null);
    }
}
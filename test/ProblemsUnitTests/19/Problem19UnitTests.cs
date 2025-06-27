using LeetCode.Problems._19;
using LeetCode.Problems.Common;
using static LeetCode.Problems.Common.ListNodeExtension;

namespace ProblemsUnitTests._19;
public class Problem19UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((ListNode input1, int n, ListNode expected) td)
    {
        Assert.That(ListNodeToArray(new Solution().RemoveNthFromEnd(td.input1, td.n)), Is.EqualTo(ListNodeToArray(td.expected)));
    }

    private static IEnumerable<(ListNode, int, ListNode)> GetTestCaseDatas()
    {
        yield return (ArrayToListNode([1,2,3,4,5]), 2, ArrayToListNode([1,2,3,5]));
        yield return (ArrayToListNode([1]), 1, ArrayToListNode([]));
        yield return (ArrayToListNode([1,2]), 1, ArrayToListNode([1]));
        yield return (ArrayToListNode([1,2]), 2, ArrayToListNode([2]));
        yield return (ArrayToListNode([1,2,3,4,5]), 1, ArrayToListNode([1,2,3,4]));
    }
}
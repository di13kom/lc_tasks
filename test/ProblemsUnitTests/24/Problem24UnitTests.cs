using LeetCode.Problems._24;
using LeetCode.Problems.Common;
using static LeetCode.Problems.Common.ListNodeExtension;

namespace ProblemsUnitTests._24;

public class Problem24UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((ListNode input, ListNode expected) td)
    {
        Assert.That(ListNodeToArray(new Solution().SwapPairs(td.input)), Is.EqualTo(ListNodeToArray(td.expected)));
    }

    private static IEnumerable<(ListNode, ListNode)> GetTestCaseDatas()
    {
        yield return (ArrayToListNode([]), ArrayToListNode([]));
        yield return (ArrayToListNode([1]), ArrayToListNode([1]));
        yield return (ArrayToListNode([1, 2]), ArrayToListNode([2, 1]));
        yield return (ArrayToListNode([1, 2, 3]), ArrayToListNode([2, 1, 3]));
        yield return (ArrayToListNode([1, 2, 3, 4]), ArrayToListNode([2, 1, 4, 3]));
    }
}
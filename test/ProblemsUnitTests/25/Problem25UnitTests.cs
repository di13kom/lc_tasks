using LeetCode.Problems._25;
using LeetCode.Problems.Common;
using static LeetCode.Problems.Common.ListNodeExtension;

namespace ProblemsUnitTests._25;

public class Problem25UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((ListNode input1, int k, ListNode expected) td)
    {
        Assert.That(ListNodeToArray(new Solution().ReverseKGroup(td.input1, td.k)), Is.EqualTo(ListNodeToArray(td.expected)));
    }

    private static IEnumerable<(ListNode, int, ListNode)> GetTestCaseDatas()
    {
        yield return (ArrayToListNode([1, 2, 3, 4, 5]), 2, ArrayToListNode([2, 1, 4, 3, 5]));
        yield return (ArrayToListNode([1, 2, 3, 4, 5]), 3, ArrayToListNode([3, 2, 1, 4, 5]));
        yield return (ArrayToListNode([1, 2, 3, 4, 5, 6, 7, 8]), 3, ArrayToListNode([3, 2, 1, 6, 5, 4, 7, 8]));
        yield return (ArrayToListNode([1, 2, 3, 4, 5, 6, 7, 8]), 4, ArrayToListNode([4, 3, 2, 1, 8, 7, 6, 5]));
        yield return (ArrayToListNode([1, 2, 3, 4, 5, 6, 7, 8]), 5, ArrayToListNode([5, 4, 3, 2, 1, 6, 7, 8]));
        yield return (ArrayToListNode([1, 2, 3, 4, 5, 6, 7, 8]), 1, ArrayToListNode([1, 2, 3, 4, 5, 6, 7, 8]));
    }
}
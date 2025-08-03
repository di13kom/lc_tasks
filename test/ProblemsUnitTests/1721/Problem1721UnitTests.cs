using LeetCode.Problems._1721;
using LeetCode.Problems.Common;
using static LeetCode.Problems.Common.ListNodeExtension;

namespace ProblemsUnitTests._1721;

public class Problem1721UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas)), Timeout(10000)]
    public void SolutionTest((ListNode input1, int k, ListNode expected) td)
    {
        Assert.That(ListNodeToArray(new Solution().SwapNodes(td.input1, td.k)), Is.EqualTo(ListNodeToArray(td.expected)));
    }

    private static IEnumerable<(ListNode, int, ListNode)> GetTestCaseDatas()
    {
        yield return (ArrayToListNode([1, 2, 3, 4, 5]), 2, ArrayToListNode([1, 4, 3, 2, 5]));
        yield return (ArrayToListNode([1, 2, 3, 4]), 1, ArrayToListNode([4, 2, 3, 1]));
        yield return (ArrayToListNode([1, 2, 3, 4]), 2, ArrayToListNode([1, 3, 2, 4]));
        yield return (ArrayToListNode([100, 90]), 2, ArrayToListNode([90, 100]));
        yield return (ArrayToListNode([7, 9, 6, 6, 7, 8, 3, 0, 9, 5]), 5, ArrayToListNode([7, 9, 6, 6, 8, 7, 3, 0, 9, 5]));
        yield return (ArrayToListNode([7, 9, 6, 6, 7, 8, 3, 0, 9, 5]), 6, ArrayToListNode([7, 9, 6, 6, 8, 7, 3, 0, 9, 5]));
    }
}
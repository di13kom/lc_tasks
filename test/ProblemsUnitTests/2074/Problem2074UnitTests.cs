using LeetCode.Problems._2074;
using LeetCode.Problems.Common;
using static LeetCode.Problems.Common.ListNodeExtension;

namespace ProblemsUnitTests._2074;

public class Problem2074UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((ListNode input1, ListNode expected) td)
    {
        Assert.That(ListNodeToArray(new Solution().ReverseEvenLengthGroups(td.input1)), Is.EqualTo(ListNodeToArray(td.expected)));
    }

    private static IEnumerable<(ListNode, ListNode)> GetTestCaseDatas()
    {
        yield return (ArrayToListNode([8]), ArrayToListNode([8]));
        yield return (ArrayToListNode([1, 3]), ArrayToListNode([1, 3]));
        yield return (ArrayToListNode([5, 2, 6, 3, 9, 1, 7, 3, 8, 4]), ArrayToListNode([5, 6, 2, 3, 9, 1, 4, 8, 3, 7]));
        yield return (ArrayToListNode([1, 1, 0, 6]), ArrayToListNode([1, 0, 1, 6]));
        yield return (ArrayToListNode([1, 1, 0, 6, 5]), ArrayToListNode([1, 0, 1, 5, 6]));
        yield return (ArrayToListNode([5, 2, 6, 3, 9, 1, 7, 3, 8, 4, 9, 0, 7]), ArrayToListNode([5, 6, 2, 3, 9, 1, 4, 8, 3, 7, 9, 0, 7]));
    }
}
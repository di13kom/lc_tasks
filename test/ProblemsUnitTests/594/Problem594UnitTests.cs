using LeetCode.Problems._594;

namespace ProblemsUnitTests._594;

public class Problem594UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] nums, int expected) td)
    {
        Assert.That(new Solution().FindLHS(td.nums), Is.EqualTo(td.expected));
    }
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((int[] nums, int expected) td)
    {
        Assert.That(new Solution1().FindLHS(td.nums), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1, 3, 2, 2, 5, 2, 3, 7], 5);
        yield return ([1, 2, 3, 4], 2);
        yield return ([1, 1, 1, 1], 0);
        yield return ([1, 2, 2, 2, 3, 3, 4, 4, 4, 4], 6);
        yield return ([1, 4, 4, 4, 4, 4], 0);
        yield return ([1, 4, 4, 4, 5, 6], 4);
        yield return ([1, 4, 4, 4, 4, 4, 4, 4, 4, 5], 9);
    }
}

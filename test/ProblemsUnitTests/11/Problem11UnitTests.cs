using LeetCode.Problems._11;

namespace ProblemsUnitTests._11;

public class Problem11UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] height, int expected) td)
    {
        Assert.That(new Solution().MaxArea(td.height), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1, 8, 6, 2, 5, 4, 8, 3, 7], 49);
        yield return ([1, 1], 1);
        yield return ([1, 2, 1], 2);
        yield return ([1, 3, 2, 5, 25, 24, 5], 24);
        yield return ([1, 2, 4, 3], 4);
        yield return ([2, 3, 4, 5, 18, 17, 6], 17);
        yield return ([7, 10, 6, 2, 5, 4, 8, 3, 7], 56);
        yield return ([5, 4, 3, 2, 1], 6);
    }
}

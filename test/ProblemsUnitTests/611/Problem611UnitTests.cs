using LeetCode.Problems._611;

namespace ProblemsUnitTests._611;

public class Problem611UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().TriangleNumber(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([2, 2, 3, 4], 3);
        yield return ([4, 2, 3, 4], 4);
        yield return ([1, 1, 3, 4], 0);
        yield return ([2, 999, 999, 2, 500, 998, 997], 18);
        yield return ([0, 0, 0], 0);
        yield return ([7, 0, 0, 0], 0);
        yield return ([7, 1, 1, 1], 1);
        yield return ([1, 2, 3, 4, 5, 6, 7, 8, 9], 34);
        yield return ([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 50);
    }
}

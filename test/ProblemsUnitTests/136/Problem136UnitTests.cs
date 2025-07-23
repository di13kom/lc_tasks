using LeetCode.Problems._136;

namespace ProblemsUnitTests._136;

public class Problem136UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().SingleNumber(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([2, 2, 1], 1);
        yield return ([4, 1, 2, 1, 2], 4);
        yield return ([1], 1);
        yield return ([5, 3, 1, 5, 3], 1);
        yield return ([7, 5, 3, 1, 5, 3, 7], 1);
    }
}
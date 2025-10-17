using LeetCode.Problems._961;

namespace ProblemsUnitTests._961;

public class Problem961UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().RepeatedNTimes(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1, 2, 3, 3], 3);
        yield return ([2, 1, 2, 5, 3, 2], 2);
        yield return ([5, 1, 5, 2, 5, 3, 5, 4], 5);
    }
}

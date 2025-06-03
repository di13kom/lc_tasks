using LeetCode.Problems._3432;

namespace ProblemsUnitTests._3432;

public class Problem3432UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().CountPartitions(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([10, 10, 3, 7, 6], 4);
        yield return ([1, 2, 2], 0);
        yield return ([2, 4, 6, 8], 3);
        yield return ([1, 4, 7], 2);
        yield return ([4, 1, 7], 2);
    }
}

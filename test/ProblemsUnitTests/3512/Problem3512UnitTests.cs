using LeetCode.Problems._3512;

namespace ProblemsUnitTests._3512;

public class Problem3512UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int k, int expected) td)
    {
        Assert.That(new Solution().MinOperations(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, int)> GetTestCaseDatas()
    {
        yield return ([3, 9, 7], 5, 4);
        yield return ([4, 1, 3], 4, 0);
        yield return ([3, 2], 6, 5);
    }
}

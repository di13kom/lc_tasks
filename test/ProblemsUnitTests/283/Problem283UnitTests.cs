using LeetCode.Problems._283;

namespace ProblemsUnitTests._283;

public class Problem283UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int[] expected) td)
    {
        new Solution().MoveZeroes(td.input);
        Assert.That(td.input, Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int[])> GetTestCaseDatas()
    {
        yield return ([0, 1, 0, 3, 12], [1, 3, 12, 0, 0]);
        yield return ([0,], [0]);
    }
}
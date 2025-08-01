using LeetCode.Problems._48;

namespace ProblemsUnitTests._48;

public class Problem48UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[][] input, int[][] expected) td)
    {
        new Solution().Rotate(td.input);
        Assert.That(td.input, Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[][], int[][])> GetTestCaseDatas()
    {
        yield return ([[1, 2, 3], [4, 5, 6], [7, 8, 9]], [[7, 4, 1], [8, 5, 2], [9, 6, 3]]);
        yield return ([[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]], [[15, 13, 2, 5], [14, 3, 4, 1], [12, 6, 8, 9], [16, 7, 10, 11]]);
    }
}

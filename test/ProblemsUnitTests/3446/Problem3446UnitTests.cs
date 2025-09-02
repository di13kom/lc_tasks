using LeetCode.Problems._3446;

namespace ProblemsUnitTests._3446;

public class Problem3446UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Test1((int[][] input, int[][] expected) td)
    {
        Assert.That(new Solution().SortMatrix(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[][], int[][])> GetTestCaseDatas()
    {
        yield return ([[1, 7, 3], [9, 8, 2], [4, 5, 6]], [[8, 2, 3], [9, 6, 7], [4, 5, 1]]);
        yield return ([[0, 1], [1, 2]], [[2, 1], [1, 0]]);
        yield return ([[1]],[[1]]);
    }
}
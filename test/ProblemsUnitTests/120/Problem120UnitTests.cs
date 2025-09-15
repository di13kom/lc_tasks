using LeetCode.Problems._120;

namespace ProblemsUnitTests._120;

public class Problem120UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((IList<IList<int>> input, int expected) td)
    {
        Assert.That(new Solution1().MinimumTotal(td.input), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((IList<IList<int>> input, int expected) td)
    {
        Assert.That(new Solution().MinimumTotal(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(IList<IList<int>>, int)> GetTestCaseDatas()
    {
        yield return ([[2], [3, 4], [6, 5, 7], [4, 1, 8, 3]], 11);
        yield return ([[-10]], -10);
        yield return ([[0]], 0);
        yield return ([[0], [0, 0]], 0);
        yield return ([[2], [-3, 4], [100, 99, 7], [4, 1, -8, 3]], 5);
        yield return ([[3], [3, 3], [3, 3, 3], [3, 3, 3, 3], [3, 3, 3, 3, 3], [3, 3, 3, 3, 3, 3], [3, 3, 3, 3, 3, 0, 3]], 18);
        yield return ([[3], [3, 3], [3, 3, 3], [3, 3, 3, 3], [3, 3, 3, 3, 3], [3, 3, 3, 3, 3, 3], [3, 3, 3, 3, 3, 0, 3]], 18);
        yield return ([[-7],[-2, 1],[-5, -5, 9],[-4, -5, 4, 4],[-6, -6, 2, -1, -5],[3, 7, 8, -3, 7, -9],[-9, -1, -9, 6, 9, 0, 7],
        [-7, 0, -6, -8, 7, 1, -4, 9],[-3, 2, -6, -9, -7, -6, -9, 4, 0]], -44);
        yield return ([[-7], [-2, 1], [-5, -5, 9], [-4, -5, 4, 4], [-6, -6, 2, -1, -5], [3, 7, 8, -3, 7, -9], [-9, -1, -9, 6, 9, 0, 7],
                        [-7, 0, -6, -8, 7, 1, -4, 9], [-3, 2, -6, -9, -7, -6, -9, 4, 0], [-8, -6, -3, -9, -2, -6, 7, -5, 0, 7],
                        [-9, -1, -2, 4, -2, 4, 4, -1, 2, -5, 5], [1, 1, -6, 1, -2, -4, 4, -2, 6, -6, 0, 6],
                        [-3, -3, -6, -2, -6, -2, 7, -9, -5, -7, -5, 5, 1]], -63);
    }
}
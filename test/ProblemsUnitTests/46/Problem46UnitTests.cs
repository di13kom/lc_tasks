using LeetCode.Problems._46;

namespace ProblemsUnitTests._46;

public class Problem46UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, IList<IList<int>> expected) td)
    {
        Assert.That(new Solution().Permute(td.input), Is.EquivalentTo(td.expected));
    }

    private static IEnumerable<(int[], IList<IList<int>>)> GetTestCaseDatas()
    {
        yield return ([1, 2, 3], [[1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1]]);
        yield return ([0, 1], [[0, 1], [1, 0]]);
        yield return ([1], [[1]]);
        yield return ([-1, 0, 1, 2,], [[-1,0,1,2],[-1,0,2,1],[-1,1,0,2],[-1,1,2,0],[-1,2,0,1],[-1,2,1,0],
                                        [0,-1,1,2],[0,-1,2,1],[0,1,-1,2],[0,1,2,-1],[0,2,-1,1],[0,2,1,-1],
                                        [1,-1,0,2],[1,-1,2,0],[1,0,-1,2],[1,0,2,-1],[1,2,-1,0],[1,2,0,-1],
                                        [2,-1,0,1],[2,-1,1,0],[2,0,-1,1],[2,0,1,-1],[2,1,-1,0],[2,1,0,-1]]);
    }
}
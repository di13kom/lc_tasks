using LeetCode.Problems._15;

namespace ProblemsUnitTests._15;

public class Problem15UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, IList<IList<int>> expected) td)
    {
        Assert.That(new Solution().ThreeSum(td.input), Is.EquivalentTo(td.expected));
    }
    
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((int[] input, IList<IList<int>> expected) td)
    {
        Assert.That(new Solution1().ThreeSum(td.input), Is.EquivalentTo(td.expected));
    }

    private static IEnumerable<(int[], IList<IList<int>>)> GetTestCaseDatas()
    {
        yield return ([-1, 0, 1, 2, -1, -4], [[-1, -1, 2], [-1, 0, 1]]);
        yield return ([0, 1, 1], []);
        yield return ([0, 0, 0], [[0, 0, 0]]);
        yield return ([1, 1, -2], [[-2, 1, 1]]);
        yield return ([-1, 0, 1, 6, -1, -4, 5, 2], [[-1, -1, 2], [-1, 0, 1], [-4, -1, 5]]);//-4,-1,-1,0,1,2,5,6
    }
}
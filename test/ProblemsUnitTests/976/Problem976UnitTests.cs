using LeetCode.Problems._976;

namespace ProblemsUnitTests._976;

public class Problem976UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().LargestPerimeter(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([2, 1, 2], 5);
        yield return ([5, 6, 7], 18);
        yield return ([1, 2, 1, 10], 0);
        yield return ([3, 2, 3, 4], 10);
    }
}

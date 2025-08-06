using LeetCode.Problems._896;

namespace ProblemsUnitTests._896;

public class Problem896UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, bool expected) td)
    {
        Assert.That(new Solution().IsMonotonic(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], bool)> GetTestCaseDatas()
    {
        yield return ([1, 2, 2, 3], true);
        yield return ([6, 5, 4, 4], true);
        yield return ([1, 3, 2], false);
        yield return ([1], true);
        yield return ([1, 1], true);
        yield return ([2, 2, 2, 1, 4, 5], false);
        yield return ([3, 1, 9], false);
    }
}
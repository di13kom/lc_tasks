using LeetCode.Problems._217;

namespace ProblemsUnitTests._217;

public class Problem217UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input1, bool expected) td)
    {
        Assert.That(new Solution().ContainsDuplicate(td.input1), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], bool)> GetTestCaseDatas()
    {
        yield return ([1, 2, 3, 1], true);
        yield return ([1, 2, 3, 4], false);
        yield return ([1, 1, 1, 3, 3, 4, 3, 2, 4, 2], true);
    }
}
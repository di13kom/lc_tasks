using LeetCode.Problems._717;

namespace ProblemsUnitTests._717;

public class Problem717UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, bool expected) td)
    {
        Assert.That(new Solution().IsOneBitCharacter(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], bool)> GetTestCaseDatas()
    {
        yield return ([1], false);
        yield return ([0], true);
        yield return ([0, 0], true);
        yield return ([0, 1, 0], false);
        yield return ([1, 0, 0], true);
        yield return ([1, 0, 1, 0], false);
        yield return ([1, 1, 1, 0], false);
        yield return ([1, 1, 1, 1, 0], true);
        yield return ([1, 1, 0, 1, 1, 0], true);
        yield return ([1, 1, 1, 1, 1, 0], false);
        yield return ([0, 0, 0, 0, 0, 0], true);
    }
}

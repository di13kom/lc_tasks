using LeetCode.Problems._1018;

namespace ProblemsUnitTests._1018;

public class Problem1018UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, IList<bool> expected) td)
    {
        Assert.That(new Solution().PrefixesDivBy5(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], IList<bool>)> GetTestCaseDatas()
    {
        yield return ([0, 1, 1], [true, false, false]);
        yield return ([1, 1, 1], [false, false, false]);
        yield return ([1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 1],
                        [false, false, true, true, true, false, false, false, false, true, true, false, false, false, false, false, false, true]);
        yield return ([0, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 1],
                        [true, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false]);
        yield return ([1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 0, 1],
                        [false, false, false, false, true, true, false, false, false, false, false, false, false, true, true, true, false, false, true]);
        yield return ([0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 1, 1, 0],
                        [true, true, false, false, false, false, false, false, true, true, false, false, false, false, true, false, false]);
        yield return ([1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1],
                        [false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, true, true, true, true, false]);
    }
}

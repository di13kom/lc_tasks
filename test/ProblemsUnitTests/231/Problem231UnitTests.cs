using LeetCode.Problems._231;

namespace ProblemsUnitTests._231;

public class Problem231UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, bool expected) td)
    {
        Assert.That(new Solution().IsPowerOfTwo(td.input), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int, bool)> GetTestCaseDatas()
    {
        yield return (1, true);
        yield return (16, true);
        yield return (3, false);
        yield return (512, true);
        yield return (-512, false);
        yield return (-6, false);
        yield return (0, false);
    }
}

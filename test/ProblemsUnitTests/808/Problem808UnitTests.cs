using LeetCode.Problems._808;

namespace ProblemsUnitTests._808;

[Timeout(10000)]
public class Problem808UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((int input, double expected) td)
    {
        Assert.That(new Solution().SoupServings(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, double)> GetTestCaseDatas()
    {
        yield return (12, 0.62500);
        yield return (100, 0.71875);
        yield return (2253, 0.99880d);
        // yield return (400, 0.88963);//Round issue
        yield return (3345, 0.99989d);
        yield return (5000, 1.00000d);
        yield return (5890, 1.00000d);
        yield return (123, 0.74219d);
        yield return (12, 0.62500d);
        yield return (55, 0.65625d);
        yield return (1, 0.625d);
        yield return (0, 0.5d);
    }
}

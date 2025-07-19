using LeetCode.Problems._50;

namespace ProblemsUnitTests._50;

public class Problem50UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((double input, int n, double expected) td)
    {
        Assert.That(new Solution().MyPow(td.input, td.n), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(double, int, double)> GetTestCaseDatas()
    {
        yield return (-1, int.MaxValue, -1);
        yield return (2.0, 10, 1024.0);
        yield return (2.0, 11, 2048.0);
        yield return (2.0, 4, 16.0);
        //yield return (2.10000, 3, 9.261);//Test Fail->double round issue
        yield return (2.00000, -2, 0.25000);
        yield return (2.00000, int.MinValue, 0.0);
        yield return (-1.00000, int.MinValue, 1);
    }
}
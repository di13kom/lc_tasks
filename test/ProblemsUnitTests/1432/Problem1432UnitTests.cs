using LeetCode.Problems._1432;

namespace ProblemsUnitTests._1432;

public class Problem1432UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Test1((int input, int expected) td)
    {
        Assert.That(new Solution().MaxDiff(td.input), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (555, 888);
        yield return (9, 8);
        yield return (123456, 820000);
        yield return (1919, 8989);
    }
}

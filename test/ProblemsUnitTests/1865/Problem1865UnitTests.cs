using LeetCode.Problems._1865;

namespace ProblemsUnitTests._1865;

public class Problem1865UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, int k, int expected) td)
    {
        //Assert.That(new Solution().PossibleStringCount(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int, int)> GetTestCaseDatas()
    {
        yield return ("aabbccdd", 7, 5);
    }
}

using LeetCode.Problems._2264;

namespace ProblemsUnitTests._2264;

public class Problem2264UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string n, string expected) td)
    {
        Assert.That(new Solution().LargestGoodInteger(td.n), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, string)> GetTestCaseDatas()
    {
        yield return ("6777133339", "777");
        yield return ("2300019", "000");
        yield return ("2300019999", "999");
        yield return ("42352338", "");
        yield return ("6777188889", "888");
        yield return ("222", "222");
    }
}

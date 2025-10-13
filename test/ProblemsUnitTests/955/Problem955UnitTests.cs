using LeetCode.Problems._955;

namespace ProblemsUnitTests._955;

public class Problem955UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string[] input, int expected) td)
    {
        Assert.That(new Solution().MinDeletionSize(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string[], int)> GetTestCaseDatas()
    {
        yield return (["ca", "bb", "ac"], 1);
        yield return (["xc", "yb", "za"], 0);
        yield return (["zyx", "wvu", "tsr"], 3);
        yield return (["a", "a"], 0);
        yield return (["vdy", "vei", "zvc", "zld"], 2);
        yield return (["xga", "xfb", "yfa"], 1);
        yield return (["abx", "agz", "bgc", "bfc"], 1);
        yield return (["xga", "xfb", "yfa"], 1);
        yield return (["aaab", "aaac"], 0);
        yield return (["epdzz", "vjoxh"], 0);
        yield return (["bnjoarpmm", "xobjwmteu", "tjkwymexv"], 4);
        yield return (["hpwunsqg", "euzujrtm", "fbovfpii", "piexjjfc"], 5);
    }
}

using NUnit.Framework;
using LeetCode.Problems._2138;

namespace ProblemsUnitTests._2138;

public class Problem2138UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Test1((string input, int k, char fill, string[] expected) td)
    {
        Assert.That(new Solution().DivideString(td.input, td.k, td.fill), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int, char, string[])> GetTestCaseDatas()
    {
        yield return ("abcdefghi", 3, 'x', ["abc", "def", "ghi"]);
        yield return ("abcdefghij", 3, 'x', ["abc", "def", "ghi", "jxx"]);
        yield return ("uebwzkwruptltkctvmkejivsxwzqixowmmqmkatphkfbpxlusiqmabnpsipyh", 31, 'y', ["uebwzkwruptltkctvmkejivsxwzqixo","wmmqmkatphkfbpxlusiqmabnpsipyhy"]);
        yield return ("joeatjeagrwhxbfhgkhebiczutmpgboinsnfxyeipndskmfqesuxlhvkgzxepjxmsuibrxjvaswslckrniqst", 85, 'z', ["joeatjeagrwhxbfhgkhebiczutmpgboinsnfxyeipndskmfqesuxlhvkgzxepjxmsuibrxjvaswslckrniqst"]);
    }
}
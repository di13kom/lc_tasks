using LeetCode.Problems._1678;

namespace ProblemsUnitTests._1678;

public class Problem1678UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string cnt, string expected) td)
    {
        Assert.That(new Solution().Interpret(td.cnt), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(string, string)> GetTestCaseDatas()
    {
        yield return ("G()(al)", "Goal");
        yield return ("G()()()()(al)", "Gooooal");
        yield return ("(al)G(al)()()G", "alGalooG");
    }
}

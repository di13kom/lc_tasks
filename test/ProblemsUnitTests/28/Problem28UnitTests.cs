using LeetCode.Problems._28;

namespace ProblemsUnitTests._28;

public class Problem28UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input0, string input1, int expected) td)
    {
        Assert.That(new Solution().StrStr(td.input0, td.input1), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, string, int)> GetTestCaseDatas()
    {
        yield return ("sadbutsad", "sad", 0);
        yield return ("leetcode", "leeto", -1);
        yield return ("xyzsadbutsad", "sad", 3);
        yield return ("rsabutsad", "sad", 6);
        yield return ("mississippi", "issip", 4);
        yield return ("mississippi", "issipi", -1);
    }
}
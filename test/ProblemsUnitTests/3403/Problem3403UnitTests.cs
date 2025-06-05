using LeetCode.Problems._3403;

namespace ProblemsUnitTests._3403;

//[Timeout(10000)]
public class Problem3403UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution_Tests((string word, int numFriends, string expected) td)
    {
        Assert.That(new Solution().AnswerString(td.word, td.numFriends), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int, string)> GetTestCaseDatas()
    {
        yield return (Enumerable.Repeat('a', 2500)
                                .Zip(Enumerable.Repeat('b', 2500), (first, second) => new char[] { first, second })
                                .SelectMany(x => x)
                                .Aggregate("", (x, y) => string.Concat(x, y)),
        750,
        Enumerable.Repeat('b', 2500 - 750 / 2)
                                .Zip(Enumerable.Repeat('a', 2500 - 750 / 2), (first, second) => new char[] { first, second })
                                .SelectMany(x => x)
                                .Aggregate("", (x, y) => string.Concat(x, y)) + 'b'
        );
        yield return ("gh", 1, "gh");
        yield return ("xy", 2, "y");
        yield return ("xzy", 2, "zy");
        yield return ("yxz", 3, "z");
        yield return ("dbca", 2, "dbc");
        yield return ("gggg", 4, "g");
        yield return ("aann", 2, "nn");
        yield return ("xzyz", 1, "xzyz");
        yield return ("xxyy", 2, "yy");
        yield return ("nbjnc", 2, "nc");
    }
}

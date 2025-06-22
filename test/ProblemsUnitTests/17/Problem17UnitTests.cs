using LeetCode.Problems._17;
namespace ProblemsUnitTests._17;

public class Problem17UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, IList<string> expected) td)
    {
        Assert.That(new Solution().LetterCombinations(td.input), Is.EquivalentTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((string input, IList<string> expected) td)
    {
        Assert.That(new Solution1().LetterCombinations(td.input), Is.EquivalentTo(td.expected));
    }

    private static IEnumerable<(string, IList<string>)> GetTestCaseDatas()
    {
        yield return ("23",["ad","ae","af","bd","be","bf","cd","ce","cf"]);
        yield return ("",[]);
        yield return ("2",["a","b","c"]);
        yield return ("5678",["jmpt","jmpu","jmpv","jmqt","jmqu","jmqv","jmrt","jmru","jmrv","jmst","jmsu","jmsv","jnpt","jnpu","jnpv","jnqt","jnqu","jnqv","jnrt","jnru","jnrv","jnst","jnsu","jnsv","jopt","jopu","jopv","joqt","joqu","joqv","jort","joru","jorv","jost","josu","josv","kmpt","kmpu","kmpv","kmqt","kmqu","kmqv","kmrt","kmru","kmrv","kmst","kmsu","kmsv","knpt","knpu","knpv","knqt","knqu","knqv","knrt","knru","knrv","knst","knsu","knsv","kopt","kopu","kopv","koqt","koqu","koqv","kort","koru","korv","kost","kosu","kosv","lmpt","lmpu","lmpv","lmqt","lmqu","lmqv","lmrt","lmru","lmrv","lmst","lmsu","lmsv","lnpt","lnpu","lnpv","lnqt","lnqu","lnqv","lnrt","lnru","lnrv","lnst","lnsu","lnsv","lopt","lopu","lopv","loqt","loqu","loqv","lort","loru","lorv","lost","losu","losv"]);
    }
}

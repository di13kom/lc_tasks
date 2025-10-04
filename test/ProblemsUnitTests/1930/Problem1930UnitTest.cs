using LeetCode.Problems._1930;

namespace ProblemsUnitTests._1930;

public class Problem1930UnitTest
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, int expected) td)
    {
        Assert.That(new Solution().CountPalindromicSubsequence(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int)> GetTestCaseDatas()
    {
        yield return ("aabca", 3);
        yield return ("adc", 0);
        yield return ("bbcbaba", 4);
        yield return ("bbaabb", 2);
        yield return ("aaaaaa", 1);
        yield return ("lhwtek", 0);
        yield return ("ckafnafqo", 4);
        yield return ("narisoerjteokvhfupilrnuytrhrqcygiudbzptlxosjkdrxwx", 239);
        yield return ("eensygaioqiwqueoxmnbcxmjgfvjshjhsjgshtnmnvsefghsgfjseegjywyrwourwppidmxdmxvxhdbzhjgfdjgeyssoefsjbfbbxnbdnfvdfvjhxdjfhgxdjfhxdjfxhbbxfvxdjfvjh", 369);
        yield return ("aaabbbcccdddeeefffggghhhiiijjjkkklllmmmnnnooopppqqqrrrssstttuuuvvvwwwxxxyyyzzzaaabbbcccdddeeefffggghhhiiijjjkkklllmmmnnnooopppqqqrrrssstttuuuvvvwwwxxxyyyzzz", 676);
    }
}

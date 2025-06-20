using NUnit.Framework;
using LeetCode.Problems._3085;

namespace ProblemsUnitTests._3085;

public class Problem3085UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, int k, int expected) td)
    {
        Assert.That(new Solution().MinimumDeletions(td.input, td.k), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((string input, int k, int expected) td)
    {
        Assert.That(new Solution1().MinimumDeletions(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int, int)> GetTestCaseDatas()
    {
        yield return ("aabcaba", 0, 3);//4,2,1
        yield return ("dabdcbdcdcd", 2, 2);//5,1,2,3
        yield return ("aaabaaa", 2, 1);//5,1

        yield return ("aaaaa", 0, 0);//4
        yield return ("aabbcc", 0, 0);//2,2,2
        yield return ("aabbccdd", 1, 0);//2,2,2,2
        yield return ("abcde", 0, 0);//1,1,1,1
        yield return ("aaabbbcccdddeeefff", 1, 0);//3,3,3,3,3,3
        yield return ("k", 1, 0);//1
        yield return ("a", 0, 0);//1
        yield return ("abcdefghiabcdefghiabcdieid", 13423, 0);//
        yield return ("vvnowvov", 2, 1);
        yield return ("abcdefghiabcdefghiabcdieid", 0, 8);
    }
}
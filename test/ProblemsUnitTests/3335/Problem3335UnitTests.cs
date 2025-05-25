using LeetCode.Problems._3335;

namespace ProblemsUnitTests._3335;

public class Problem3335UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("abcyy", 2, 7)]
    [TestCase("azbk", 1, 5)]
    [TestCase("jqktcurgdvlibczdsvnsg", 7517, 5)]
    [TestCase("abcde", 25, 9)]
    [TestCase("a", 750, 8388608)]
    [TestCase("z", 750, 16777216)]
    [TestCase("ab", 350, 16385)]
    [TestCase("aa", 350, 16384)]
    [Timeout(10000)]
    public void Test1(string input, int transformationCnt, int expected)
    {
        //Assert.That(new Solution2().LengthAfterTransformations(input, transformationCnt), Is.EqualTo(expected));
        //Assert.That(new Solution1().LengthAfterTransformations(input, transformationCnt), Is.EqualTo(expected));
        //Assert.That(new Solution0().LengthAfterTransformations(input, transformationCnt), Is.EqualTo(expected));
        Assert.That(new Solution().LengthAfterTransformations(input, transformationCnt), Is.EqualTo(expected));
    }
}

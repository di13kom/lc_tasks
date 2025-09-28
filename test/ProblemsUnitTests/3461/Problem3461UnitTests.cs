using LeetCode.Problems._3461;

namespace ProblemsUnitTests._3461;

public class Problem3461UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string colors, bool expected) td)
    {
        Assert.That(new Solution().HasSameDigits(td.colors), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, bool)> GetTestCaseDatas()
    {
        yield return ("3902", true);
        yield return ("34789",false);
        yield return ("4867716181911413979960155821878", true);
        yield return ("472371665226339635424494604455723348326857778972516313101962164", true);
        yield return ("84710392847561029837465019283746509182736450918273645091827364509182736450918273", false);
        yield return ("192837465091827364509182736450918273645091827364509182736450918273645091827364509182736450", true);
        yield return ("38475610293847561029384756102938475610293847561029384756102938475610293847561029384756102938475610", true);
    }
}

using NUnit.Framework;
using LeetCode.Problems._2140;

namespace ProblemsUnitTests._2140;

public class Problem2140UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test()
    {
        int[][] input = [[3, 2], [4, 3], [4, 4], [2, 5]];
        int expected = 5;
        Assert.That(new Solution().MostPoints(input), Is.EqualTo(expected));
    }
    [Test]
    public void Test2()
    {
        int[][] input = [[1, 1], [2, 2], [3, 3], [4, 4], [5, 5]];
        int expected = 7;
        Assert.That(new Solution().MostPoints(input), Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        int[][] input = [[21, 5], [92, 3], [74, 2], [39, 4], [58, 2], [5, 5], [49, 4], [65, 3]];
        int expected = 157;
        Assert.That(new Solution().MostPoints(input), Is.EqualTo(expected));
    }

    //[Test, CancelAfter(10000)]
    //public void Test4(CancellationToken token)
    [Test, Timeout(10000)]
    public void Test4()
    {
        int[][] input = [
                        [67,1],[41,2],[77,1],[37,4],[26,1],[61,4],[42,4],[68,5],[85,4],[55,4],[68,3],[36,5],[35,5],
                        [15,5],[52,3],[23,3],[53,2],[87,2],[68,4],[38,5],[57,1],[34,3],[59,4],[12,4],[64,4],[89,3],
                        [80,2],[6,2],[68,5],[35,1],[18,2],[76,1],[59,2],[24,4],[33,2],[59,4],[15,5],[47,4],[77,2],
                        [16,3],[75,1],[86,4],[8,2],[92,3],[32,3],[83,4],[81,1],[21,5],[91,1],[25,2],[5,3],[6,3],
                        [21,1],[34,5],[57,5],[76,5],[31,5],[22,3],[2,4],[79,5],[75,3],[63,3],[78,5],[19,2],[50,4],
                        [78,5],[81,2],[79,1],[57,2],[58,1],[74,3],[63,2],[24,1],[22,1],[4,2],[100,2],[43,3],[1,1],
                        [3,1],[74,4],[42,1],[8,5],[32,2],[2,3],[38,3],[12,5],[100,4],[21,5],[14,2],[69,4],[51,1],
                        [14,5],[30,3],[96,3],[65,2],[74,1],[74,5]
                        ];
        int expected = 1728;
        //while (!token.IsCancellationRequested)
        //{
        Assert.That(new Solution().MostPoints(input), Is.EqualTo(expected));
        //Assert.That(new Solution2().MostPoints(input), Is.EqualTo(expected));
        //}
    }
}

using LeetCode.Problems._1;
using LeetCode.Problems._1116;

namespace ProblemsUnitTests._1116;

public class Problem1116UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1, "01")]
    [TestCase(2, "0102")]
    [TestCase(5, "0102030405")]
    public void Test1(int input, string expected)
    {
        Task[] tasks = new Task[3];
        var ZeroEvenOdd = new ZeroEvenOdd(input);
        tasks[0] = Task.Run(() =>
        {
            ZeroEvenOdd.Zero(x =>
            {
                if (x != 0)
                    throw new Exception("Not odd value;");
                Console.Write(x);
            });
        });
        tasks[1] = Task.Run(() =>
        {
            ZeroEvenOdd.Even(x =>
            {
                if (x % 2 != 0)
                    throw new Exception("Not even value;");
                Console.Write(x);
            });
        });
        tasks[2] = Task.Run(() =>
        {
            ZeroEvenOdd.Odd(x =>
            {
                if (x % 2 != 1)
                    throw new Exception("Not odd value;");
                Console.Write(x);
            });
        });

        Task.WaitAll(tasks);
        Assert.Pass();
    }
}

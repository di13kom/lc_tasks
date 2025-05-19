using LeetCode.Problems._1;
using LeetCode.Problems._1116;

namespace ProblemsUnitTests._1116;

public class Problem1116UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(2, "0102")]
    [TestCase(5, "0102030405")]
    public void Test1(int input, string expected)
    {
        Task[] tasks = new Task[3];
        int sleepTimeout = 200;
        var ZeroEvenOdd = new ZeroEvenOdd(input);
        tasks[0] = Task.Run(() =>
        {
            for (int i = 0; i < input; i++)
            {
                ZeroEvenOdd.Zero(x =>
                {
                    if (x != 0)
                        throw new Exception("Not odd value;");
                    Thread.Sleep(sleepTimeout);
                    Console.Write(x);
                });
            }
        });
        tasks[1] = Task.Run(() =>
        {
            for (int i = 0; i < input; i++)
            {
                ZeroEvenOdd.Even(x =>
                {
                    if (x % 2 != 0)
                        throw new Exception("Not even value;");
                    Thread.Sleep(sleepTimeout);
                    Console.Write(x);
                });
            }
        });
        tasks[2] = Task.Run(() =>
        {
            for (int i = 0; i < input; i++)
            {
                ZeroEvenOdd.Odd(x =>
                {
                    if (x % 2 != 1)
                        throw new Exception("Not odd value;");
                    Thread.Sleep(sleepTimeout);
                    Console.Write(x);
                });
            }
        });

        Task.WaitAll(tasks);
        Assert.Pass();
    }
}

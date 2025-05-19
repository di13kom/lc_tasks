using LeetCode.Problems._1195;

namespace ProblemsUnitTests._1195;

public class Problem1195UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(15)]
    [TestCase(5)]
    public void Test1(int input)
    {
        Task[] tasks = new Task[4];
        int sleepTimeout = 10;
        var problemClass = new FizzBuzz(input);
        tasks[0] = Task.Run(() =>
        {
            for (int i = 0; i < input; i++)
            {
                problemClass.Number(x =>
                {
                    Thread.Sleep(sleepTimeout);
                    Console.Write(x);
                });
            }
        });
        tasks[1] = Task.Run(() =>
        {
            for (int i = 0; i < input; i++)
            {
                problemClass.Buzz(() =>
                {
                    Thread.Sleep(sleepTimeout);
                    Console.Write("buzz");
                });
            }
        });
        tasks[2] = Task.Run(() =>
        {
            for (int i = 0; i < input; i++)
            {
                problemClass.Fizz(() =>
                {
                    Thread.Sleep(sleepTimeout);
                    Console.Write("fizz");
                });
            }
        });
        tasks[3] = Task.Run(() =>
        {
            for (int i = 0; i < input; i++)
            {
                problemClass.Fizzbuzz(() =>
                {
                    Thread.Sleep(sleepTimeout);
                    Console.Write("fizz-buzz");
                });
            }
        });

        Task.WaitAll(tasks);
        Assert.Pass();
    }
}

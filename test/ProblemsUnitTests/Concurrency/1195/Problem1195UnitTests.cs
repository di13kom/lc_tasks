using LeetCode.Problems.Concurrency._1195;

namespace ProblemsUnitTests._1195;

public class Problem1195UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(15, new string[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz" })]
    [TestCase(5, new string[] { "1", "2", "fizz", "4", "buzz" })]
    public void Test1(int input, string[] expected)
    {
        List<string> strings = [];
        Task[] tasks = new Task[4];
        int sleepTimeout = 10;
        var problemClass = new FizzBuzz(input);
        tasks[0] = Task.Run(() =>
        {
            //for (int i = 0; i < input; i++)
            //{
            problemClass.Number(x =>
            {
                Thread.Sleep(sleepTimeout);
                Console.Write(x);
                strings.Add(x.ToString());
            });
            //}
        });
        tasks[1] = Task.Run(() =>
        {
            //for (int i = 0; i < input; i++)
            //{
            problemClass.Buzz(() =>
            {
                Thread.Sleep(sleepTimeout);
                Console.Write("buzz");
                strings.Add("buzz");
            });
            //}
        });
        tasks[2] = Task.Run(() =>
        {
            //for (int i = 0; i < input; i++)
            //{
            problemClass.Fizz(() =>
            {
                Thread.Sleep(sleepTimeout);
                Console.Write("fizz");
                strings.Add("fizz");
            });
            //}
        });
        tasks[3] = Task.Run(() =>
        {
            //for (int i = 0; i < input; i++)
            //{
            problemClass.Fizzbuzz(() =>
            {
                Thread.Sleep(sleepTimeout);
                Console.Write("fizzbuzz");
                strings.Add("fizzbuzz");
            });
            //}
        });

        Task.WaitAll(tasks);
        Assert.That(strings.ToArray(), Is.EqualTo(expected));
    }
}

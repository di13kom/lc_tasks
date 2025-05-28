using System.Text;
using NUnit.Framework;
using LeetCode.Problems.Concurrency._1117;
using System.Linq.Expressions;
using System.Diagnostics;

namespace ProblemsUnitTests.Concurrency._1117;

public class Problem1117UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("HOH", "HHO")]
    [TestCase("OOHHHH", "HHOHHO")]
    [TestCase("OHHOOOHOHHHHHHH", "HOHHHOOHHHHOHHO")]
    [Timeout(10000)]
    public void Test1(string input, string expected)
    {
        StringBuilder chars = new StringBuilder();
        var length = input.Length;
        Task[] tasks = new Task[length];
        var h20 = new H2O_2();
        for (int i = 0; i < length; i++)
        {
            Debug.WriteLine($"Round:{i} = {input[i]}");
            Action action = input[i] switch
            {
                'O' => () => h20.Oxygen(() =>
                {
                    //Debug.WriteLine($"output:{i}");
                    chars.Append('O');
                }),
                'H' => () => h20.Hydrogen(() =>
                {
                    //Console.WriteLine($"output:{i}");
                    chars.Append('H');
                }),
                _ => throw new NotImplementedException(),
            };

            tasks[i] = Task.Run(() =>
            {
                action();
            });
        }

        Task.WaitAll(tasks);
        Assert.That(chars.ToString(), Is.EquivalentTo(expected));
    }
}

using System.Threading;

namespace LeetCode.Problems._1114;

public class Foo
{
    long currentOperation;
    public Foo()
    {
        currentOperation = 0;
    }

    public void First(Action printFirst)
    {
        if (Interlocked.Read(ref currentOperation) > 0)
            return;

        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        Interlocked.Exchange(ref currentOperation, 1);
    }

    public void Second(Action printSecond)
    {
        while (Interlocked.Read(ref currentOperation) < 1)
        {
            Thread.Sleep(500);
        }
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        Interlocked.Exchange(ref currentOperation, 2);
    }

    public void Third(Action printThird)
    {
        while (Interlocked.Read(ref currentOperation) < 2)
        {
            Thread.Sleep(500);
        }
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}

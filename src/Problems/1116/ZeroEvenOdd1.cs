using System;

namespace LeetCode.Problems._1116;

public class ZeroEvenOdd1
{
    private int n;
    private readonly Queue<int> Ints;
    private long _zeroOperationAvaliable;
    long countUp;

    public ZeroEvenOdd1(int n)
    {
        this.n = n;
        Ints = new Queue<int>(Enumerable.Range(1, 2 * n));
        _zeroOperationAvaliable = 1;
        countUp = 0;
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Zero(Action<int> printNumber)
    {
        if (Interlocked.Read(ref countUp) > 0)
        {
            Thread.Sleep(10);
        }

        printNumber(0);

        Interlocked.Increment(ref countUp);
    }

    public void Even(Action<int> printNumber)
    {
        while (Interlocked.Read(ref countUp) < 1)
        {
            Thread.Sleep(10);
        }

        printNumber(Ints.Dequeue());

        Interlocked.Decrement(ref _zeroOperationAvaliable);
    }

    public void Odd(Action<int> printNumber)
    {
        while (Interlocked.Read(ref countUp) < 2)
        {
            Thread.Sleep(10);
        }

        printNumber(Ints.Dequeue());

        Interlocked.Exchange(ref countUp, 0);
    }
}

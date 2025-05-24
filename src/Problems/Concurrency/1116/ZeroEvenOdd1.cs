using System;

namespace LeetCode.Problems.Concurrency._1116;

public class ZeroEvenOdd1
{
    private int n;
    readonly SemaphoreSlim _zeroSemaphore = new(1, 1);
    readonly SemaphoreSlim _evenSemaphore = new(0, 1);
    readonly SemaphoreSlim _oddSemaphore = new(0, 1);

    public ZeroEvenOdd1(int n)
    {
        this.n = n;
    }

    public void Zero(Action<int> printNumber)
    {
        for (int i = 1; i <= n; i++)
        {
            _zeroSemaphore.Wait();
            printNumber(0);
            if (i % 2 == 1)
                _oddSemaphore.Release();
            else
                _evenSemaphore.Release();
        }
    }

    public void Even(Action<int> printNumber)
    {
        for (int i = 2; i <= n; i+=2)
        {
            _evenSemaphore.Wait();
            printNumber(i);
            _zeroSemaphore.Release();
        }
    }

    public void Odd(Action<int> printNumber)
    {
        for (int i = 1; i <= n; i+=2)
        {
            _oddSemaphore.Wait();
            printNumber(i);
            _zeroSemaphore.Release();
        }
    }
}
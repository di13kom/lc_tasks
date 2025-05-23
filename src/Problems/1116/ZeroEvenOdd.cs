using System.Threading;

namespace LeetCode.Problems._1116;

public class ZeroEvenOdd
{
    private int n;
    readonly private Queue<int> Ints;
    readonly SemaphoreSlim _zeroSemaphore = new(1, 1);
    readonly SemaphoreSlim _evenSemaphore = new(0, 1);
    readonly SemaphoreSlim _oddSemaphore = new(0, 1);

    private int _semaphoreTimeout = 10;
    private int _zeroSemaphoreTimeout;
    private int _eventSemaphoreTimeout;
    private int _oddSemaphoreTimeout;

    long countUp;

    public ZeroEvenOdd(int n)
    {
        this.n = n;
        Ints = new Queue<int>(Enumerable.Range(1, n));
        countUp = 0;
        _zeroSemaphoreTimeout = _semaphoreTimeout;
        _eventSemaphoreTimeout = _semaphoreTimeout;
        _oddSemaphoreTimeout = _semaphoreTimeout;
    }

    public void Zero(Action<int> printNumber)
    {
        while (Interlocked.Read(ref countUp) < n)
        {
            if (!_zeroSemaphore.Wait(_zeroSemaphoreTimeout))
                return;

            printNumber(0);

            if (Interlocked.Increment(ref countUp) % 2 == 0)
                _evenSemaphore.Release();
            else
                _oddSemaphore.Release();
        }

    }

    public void Even(Action<int> printNumber)
    {
        while (Interlocked.Read(ref countUp) < n)
        {
            if (!_evenSemaphore.Wait(_eventSemaphoreTimeout))
                return;

            printNumber(Ints.Dequeue());

            _zeroSemaphore.Release();
        }
    }

    public void Odd(Action<int> printNumber)
    {
        while (Interlocked.Read(ref countUp) <= n)
        {
            if (!_oddSemaphore.Wait(_oddSemaphoreTimeout))
                return;

            printNumber(Ints.Dequeue());

            _zeroSemaphore.Release();
        }
    }
}
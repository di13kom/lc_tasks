using System.Threading;

namespace LeetCode.Problems.Concurrency._1117;

public class H2O_1
{
    private readonly SemaphoreSlim _hydrogenSemaphore, _oxygenSemaphore;

    public H2O_1()
    {
        _hydrogenSemaphore = new(0, 2);
        _oxygenSemaphore = new(0, 1);
    }

    public void Hydrogen(Action releaseHydrogen)
    {
        _hydrogenSemaphore.Wait();

        // releaseHydrogen() outputs "H". Do not change or remove this line.
        releaseHydrogen();

        _oxygenSemaphore.Release();
        if (_hydrogenSemaphore.CurrentCount == 0)
        {
            _hydrogenSemaphore.Release();
        }

    }
    public void Oxygen(Action releaseOxygen)
    {
        _oxygenSemaphore.Wait();
        // releaseOxygen() outputs "O". Do not change or remove this line.
        releaseOxygen();

        _hydrogenSemaphore.Release(2);
    }

}
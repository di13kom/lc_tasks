namespace LeetCode.Problems.Concurrency._1117;

public class H2O_2
{
    private long n;
    private readonly SemaphoreSlim _hydrogenSemaphore, _oxygenSemaphore;

    public H2O_2()
    {
        n = 0;
        _hydrogenSemaphore = new(0, 1);
        _oxygenSemaphore = new(0, 1);
    }

    public void Hydrogen(Action releaseHydrogen)
    {
        if (Interlocked.CompareExchange(ref n, 1, 0) == 0)
        {
            Console.WriteLine("Hydro");
            _hydrogenSemaphore.Release();
        }
        _hydrogenSemaphore.Wait();

        // releaseHydrogen() outputs "H". Do not change or remove this line.
        releaseHydrogen();

        if (Interlocked.Increment(ref n) % 2 == 0)
        {
            _hydrogenSemaphore.Release();
        }
        else
        {
            _oxygenSemaphore.Release();
        }
    }
    public void Oxygen(Action releaseOxygen)
    {
        if (Interlocked.CompareExchange(ref n, 1, 0) == 0)
        {
            Console.WriteLine("Oxy");
            _oxygenSemaphore.Release();
        }
        _oxygenSemaphore.Wait();
        // releaseOxygen() outputs "O". Do not change or remove this line.
        releaseOxygen();

        _hydrogenSemaphore.Release();
    }

}

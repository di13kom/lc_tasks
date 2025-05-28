using System.Threading;

namespace LeetCode.Problems.Concurrency._1117;

public class H2O
{
    private long n;
    private readonly SemaphoreSlim _hydrogenSemaphore, _oxygenSemaphore;

    public H2O()
    {
        n = 1;
        _hydrogenSemaphore = new(1, 1);
        _oxygenSemaphore = new(0, 1);
    }

    public void Hydrogen(Action releaseHydrogen)
    {
        while (Interlocked.Read(ref n) % 3 == 0)
        {
            Console.WriteLine("Waiting oxy");
        }
        // releaseHydrogen() outputs "H". Do not change or remove this line.
        releaseHydrogen();
        Interlocked.Increment(ref n);
    }

    public void Oxygen(Action releaseOxygen)
    {
        while (Interlocked.Read(ref n) % 3 != 0)
        {
            Console.WriteLine("Waiting hydro");
        }
        // releaseOxygen() outputs "O". Do not change or remove this line.
        releaseOxygen();
        Interlocked.Increment(ref n);
    }
}
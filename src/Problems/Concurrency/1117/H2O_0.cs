using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace LeetCode.Problems.Concurrency._1117;

public class H2O_0
{
    private long n;
    private readonly SemaphoreSlim _hydrogenSemaphore, _oxygenSemaphore;
    private Queue<int> _hydrogenQueue, _oxygenQueue;
    private readonly object _syncObject;

    public H2O_0()
    {
        n = 1;
        _hydrogenSemaphore = new(1, 1);
        _oxygenSemaphore = new(0, 1);
        _syncObject = new object();
    }

    public void Hydrogen(Action releaseHydrogen)
    {
        lock (_syncObject)
        {
            if (n == 1)
            {
                _hydrogenQueue = new Queue<int>(Enumerable.Range(1, 20).Where(x => x % 3 != 0));
                _oxygenQueue = new Queue<int>(Enumerable.Range(3, 20).Where(x => x % 3 == 0));
            }
            while (n != _hydrogenQueue.Peek())
            {
                Console.WriteLine("Waiting oxy");
            }
            // releaseHydrogen() outputs "H". Do not change or remove this line.
            releaseHydrogen();
            _hydrogenQueue.Dequeue();
            //Interlocked.Increment(ref n);
            n++;
        }
    }

    public void Oxygen(Action releaseOxygen)
    {
        lock (_syncObject)
        {
            if (n == 1)
            {
                _oxygenQueue = new Queue<int>([1, 4, 7, 10, 13, 16, 19]);
                _hydrogenQueue = new Queue<int>([2, 3, 5, 6, 8, 9, 11, 12, 14, 15, 17, 18, 20]);
            }
            while (n != _oxygenQueue.Peek())
            {
                Console.WriteLine("Waiting hydro");
            }
            // releaseOxygen() outputs "O". Do not change or remove this line.
            releaseOxygen();
            _oxygenQueue.Dequeue();
            n++;
        }
    }
}
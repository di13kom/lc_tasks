using System.Diagnostics;
using System.Threading;

namespace LeetCode.Problems.Concurrency._1195;

public class FizzBuzz
{
    private int n;
    private readonly Queue<int> _ints;
    private long curOpeation;
    readonly SemaphoreSlim _numberSemaphore = new(1, 1);
    readonly SemaphoreSlim _buzzSemaphore = new(0, 1);
    readonly SemaphoreSlim _fizzSemaphore = new(0, 1);
    readonly SemaphoreSlim _fizzBuzzSemaphore = new(0, 1);

    public FizzBuzz(int n)
    {
        this.n = n;
        _ints = new Queue<int>(Enumerable.Range(1, n).Where(x => x % 3 != 0 && x % 5 != 0));
        curOpeation = 0;

    }

    // printFizz() outputs "fizz".
    public void Fizz(Action printFizz)
    {
        int count = n / 3 - n / 15;
        for (int i = 0; i < count; i++)
        {

            _fizzSemaphore.Wait();

            printFizz();
            _numberSemaphore.Release();
        }
    }

    // printBuzzz() outputs "buzz".
    public void Buzz(Action printBuzz)
    {
        int count = n / 5 - n / 15;
        for (int i = 0; i < count; i++)
        {
            _buzzSemaphore.Wait();

            printBuzz();
            _numberSemaphore.Release();
        }
    }

    // printFizzBuzz() outputs "fizzbuzz".
    public void Fizzbuzz(Action printFizzBuzz)
    {
        int count = n / 15;
        for (int i = 0; i < count; i++)
        {
            _fizzBuzzSemaphore.Wait();

            printFizzBuzz();
            _numberSemaphore.Release();
        }
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Number(Action<int> printNumber)
    {
        for (int i = 0; i < n; i++)
        {
            _numberSemaphore.Wait();

            var newValue = Interlocked.Increment(ref curOpeation);
            //Debug.WriteLine(newValue);

            if (newValue > n)
                return;
            else if (newValue % 5 == 0 && newValue % 3 == 0)
                _fizzBuzzSemaphore.Release();
            else if (newValue % 5 == 0 && newValue % 3 != 0)
                _buzzSemaphore.Release();
            else if (newValue % 5 != 0 && newValue % 3 == 0)
                _fizzSemaphore.Release();
            else
            {
                printNumber(_ints.Dequeue());
                _numberSemaphore.Release();
            }
        }

    }
}
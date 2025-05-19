using System.Threading;

namespace LeetCode.Problems._1195;

public class FizzBuzz
{
    private int n;
    private readonly Queue<int> _ints;
    private long curOpeation;
    readonly SemaphoreSlim _numberSemaphore = new(1, 1);
    readonly SemaphoreSlim _buzzSemaphore = new(0, 1);
    readonly SemaphoreSlim _fizzSemaphore = new(0, 1);
    readonly SemaphoreSlim _fizzBuzzSemaphore = new(0, 1);
    private int _semaphoreTimeout = 50;
    private int _fizzSemaphoreTimeout;
    private int _buzzSemaphoreTimeout;
    private int _fizzBuzzSemaphoreTimeout;

    public FizzBuzz(int n)
    {
        this.n = n;
        _ints = new Queue<int>(Enumerable.Range(1, n).Where(x => x % 3 != 0 && x % 5 != 0));
        curOpeation = 0;

        _fizzBuzzSemaphoreTimeout = _semaphoreTimeout * 5;
        _fizzSemaphoreTimeout = _semaphoreTimeout * 2;
        _buzzSemaphoreTimeout = _semaphoreTimeout * 3;
    }

    // printFizz() outputs "fizz".
    public void Fizz(Action printFizz)
    {
        if (!_fizzSemaphore.Wait(_fizzSemaphoreTimeout))
            return;

        printFizz();
        //Interlocked.Increment(ref curOpeation);
        _numberSemaphore.Release();
    }

    // printBuzzz() outputs "buzz".
    public void Buzz(Action printBuzz)
    {
        if (!_buzzSemaphore.Wait(_buzzSemaphoreTimeout))
            return;

        printBuzz();
        //Interlocked.Increment(ref curOpeation);
        _numberSemaphore.Release();
    }

    // printFizzBuzz() outputs "fizzbuzz".
    public void Fizzbuzz(Action printFizzBuzz)
    {
        if (!_fizzBuzzSemaphore.Wait(_fizzBuzzSemaphoreTimeout))
            return;

        printFizzBuzz();
        //Interlocked.Increment(ref curOpeation);
        _numberSemaphore.Release();
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Number(Action<int> printNumber)
    {
        _numberSemaphore.Wait();

        var newValue = Interlocked.Increment(ref curOpeation);

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
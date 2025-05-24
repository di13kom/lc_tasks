using System;

namespace LeetCode.Problems.Concurrency._1115;

public class FooBar {
    private int n;
    private SemaphoreSlim _fooSemaphore = new SemaphoreSlim(1,1);
    private SemaphoreSlim _barSemaphore = new SemaphoreSlim(0,1);

    public FooBar(int n) {
        this.n = n;
    }

    public void Foo(Action printFoo) {
        
        for (int i = 0; i < n; i++) {
           _fooSemaphore.Wait(); 
        	// printFoo() outputs "foo". Do not change or remove this line.
        	printFoo();

            _barSemaphore.Release();
        }
    }

    public void Bar(Action printBar) {
        
        for (int i = 0; i < n; i++) {
           _barSemaphore.Wait(); 
            // printBar() outputs "bar". Do not change or remove this line.
        	printBar();

            _fooSemaphore.Release();
        }
    }
}

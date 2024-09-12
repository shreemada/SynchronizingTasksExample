namespace SynchronizingTasksExample.AdderSubtractor
{
    /*
     * interlocked is a powerful class in .NET that provides atomic operations for variables shared by multiple threads.
     * What Does Interlocked Do?
            * The Interlocked class helps protect against errors that can occur when multiple threads access and modify the same variable 
              concurrently.
            * It ensures that certain operations (like incrementing, decrementing, exchanging values, and comparing) are performed 
              atomically—that is, without interruption from other threads
     */
    internal class Count
    {
        private int _value;
        public int Value { get; }

        public void Increment()
        {
            Interlocked.Increment(ref _value);
        }
        public void Decrement()
        {
            Interlocked.Decrement(ref _value);
        }
    }
}

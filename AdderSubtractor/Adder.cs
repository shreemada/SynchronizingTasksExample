using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynchronizingTasksExample.AdderSubtractor
{
    internal class Adder
    {
        private readonly Count _count;

        public Adder(Count count)
        {
            _count = count;
        }

        public void IncrementCount()
        {
            for (int i = 1; i <= 100; i++)
            {
                // Simulate some work (you can adjust the delay as needed)
                Thread.Sleep(10);

                // Increment the count
                _count.Increment();
            }
        }
    }
}

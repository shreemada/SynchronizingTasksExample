using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynchronizingTasksExample.AdderSubtractor
{
    internal class Subtractor
    {
        private readonly Count _count;

        public Subtractor(Count count)
        {
            _count = count;
        }

        public void DecrementCount()
        {
            for (int i = 1; i <= 100; i++)
            {
                // Simulate some work (you can adjust the delay as needed)
                Thread.Sleep(10);

                // Decrement the count
                _count.Decrement();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynchronizingTasksExample.AdderSubtractor
{
    internal class AdderSubtractor
    {
        public static void Process()
        {
            var count = new Count();

            var adderThread = new Thread(new Adder(count).IncrementCount);
            var subtractorThread = new Thread(new Subtractor(count).DecrementCount);

            adderThread.Start();
            subtractorThread.Start();

            adderThread.Join();
            subtractorThread.Join();

            Console.WriteLine($"Final count value: {count.Value}");
        }
    }
}

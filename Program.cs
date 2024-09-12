using SynchronizingTasksExample;
using SynchronizingTasksExample.AdderSubtractor;

class Program
{
    static async Task Main(string[] args)
    {
        //await ProducerConsumer.Process();
        //await SequencialTasks.Process();

        //Adder Subtractor
        AdderSubtractor.Process();
    }
}

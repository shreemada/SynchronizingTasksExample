using SynchronizingTasksExample;

class Program
{
    static async Task Main(string[] args)
    {
        //await ProducerConsumer.Process();
        await SequencialTasks.Process();

    }
}

using System.Collections.Concurrent;

namespace SynchronizingTasksExample
{
    /*
        Task Completion:
            * The await Task.WhenAll(tasks); ensures that the main method waits for all producer and consumer tasks to complete 
             before printing “All tasks completed.”

        Simulated Work:
            * Task.Delay is used to simulate work in both producer and consumer tasks.

        Queue Processing:
            * The consumer tasks will exit the loop when the queue is empty, ensuring that they don’t run indefinitely.
     
     */
    public class ProducerConsumer
    {
        public static async Task Process()
        {
            ConcurrentQueue<int> sharedQueue = new ConcurrentQueue<int>();
            List<Task> tasks = new List<Task>();

            // Producer tasks
            for (int i = 0; i < 5; i++)
            {
                int producerId = i;
                tasks.Add(Task.Run(() => Producer(sharedQueue, producerId)));
            }

            // Consumer tasks
            for (int i = 0; i < 5; i++)
            {
                int consumerId = i;
                tasks.Add(Task.Run(() => Consumer(sharedQueue, consumerId)));
            }

            // Wait for all tasks to complete
            await Task.WhenAll(tasks);

            Console.WriteLine("All tasks completed.");
        }

        static void Producer(ConcurrentQueue<int> queue, int producerId)
        {
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
                Console.WriteLine($"Producer {producerId} enqueued {i}");
                Task.Delay(50).Wait(); // Simulate work
            }
        }

        static void Consumer(ConcurrentQueue<int> queue, int consumerId)
        {
            while (true)
            {
                if (queue.TryDequeue(out int item))
                {
                    Console.WriteLine($"Consumer {consumerId} dequeued {item}");
                }
                else
                {
                    break; // Exit when the queue is empty
                }
                Task.Delay(100).Wait(); // Simulate work
            }
        }
    }
}

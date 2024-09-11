namespace SynchronizingTasksExample
{
    /*
        Explanation:
        Creating Tasks:
            * A list of tasks is created, and 50 tasks are added to this list using a loop.
            * Each task is created by calling the ProcessTask method, which is now an async method.

        Executing Tasks Sequentially:
            *The tasks are executed sequentially using a foreach loop and await to ensure each task completes before the next one starts.

        Processing Each Task:
            *The ProcessTask method is now an async method that uses await Task.Delay(100) to simulate work.

        This approach ensures that each task is executed one after the other, maintaining the sequence.

     */
    public class SequencialTasks
    {
        public static async Task Process()
        {
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < 50; i++)
            {
                int taskId = i; // Capture the loop variable
                tasks.Add(ProcessTask(taskId));
            }

            // Execute tasks sequentially
            foreach (var task in tasks)
            {
                await task;
            }

            Console.WriteLine("All tasks completed.");
        }

        private static async Task ProcessTask(int taskId)
        {
            Console.WriteLine($"Processing task {taskId}");
            // Simulate some work
            await Task.Delay(100);
        }
    }
}

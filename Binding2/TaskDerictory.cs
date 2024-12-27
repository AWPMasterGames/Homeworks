using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class TaskDerictory
{
    private static ObservableCollection<Task> Tasks;
    public static Task CurrentTask;

    public static ObservableCollection<Task> GetTask()
    {
        if (Tasks == null)
        {
            Task task = new Task("Task 1", "12321321", DateTime.Now.ToString());
            task.AddSubTask("SubTask1");
            task.AddSubTask("SubTask2");
            task.AddSubTask("SubTask3");
            task.AddSubTask("SubTask4");
            Task task1 = new Task("Task 2", "12321321", DateTime.Now.ToString());
            task1.AddSubTask("SubTask5");
            task1.AddSubTask("SubTask6");
            task1.AddSubTask("SubTask7");
            task1.AddSubTask("SubTask8");

            Tasks = new ObservableCollection<Task>();
            Tasks.Add(task);
            Tasks.Add(task1);

            
        }
        return Tasks;
    }
    public static void AddTask(Task task)
    {
        Tasks.Add(task);
    }
    public static void RemoveTask(Task task)
    {
        Tasks.Remove(task);
    }
}
        
    



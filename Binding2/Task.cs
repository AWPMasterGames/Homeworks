using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
class Task
{
    public string Title { get; set; }
    public string DateOfCompletion { get; set; }
    public string Description {  get; set; }
    public ObservableCollection<SubTask> SubTasks { get; set; }  = new ObservableCollection<SubTask>();

    public Task() { }
    public Task(string title, string description , string dateOfCompletion)
    {
        Title = title;
        Description = description;
        DateOfCompletion = dateOfCompletion;
    }

    public void AddSubTask(string Name)
    {
        SubTasks.Add(new SubTask(Name));
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Binding2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();

            TaskListPanel.ItemsSource = TaskDerictory.GetTask();
        }

        private void TaskListPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TaskPanel.DataContext = TaskListPanel.SelectedItem;
            
        }

        private void AddTaskButton(object sender, RoutedEventArgs e)
        {
            if (TaskTitle.Text.Length < 3) return;
            if(TaskDescription.Text.Length < 3) return;
            if(DateComplete.Text.Length < 10) return;
            TaskDerictory.AddTask(new Task(TaskTitle.Text, TaskDescription.Text,DateComplete.Text));
            TaskListPanel.ItemsSource = TaskDerictory.GetTask();
        }
        private void AddSubTaskButton(object sender, RoutedEventArgs e)
        {
            Window1 AddSubTaskWindow = new Window1();
            AddSubTaskWindow.Show();
        }
        private void RemoveTaskButton(object sender, RoutedEventArgs e)
        {
            TaskDerictory.RemoveTask((Task)TaskListPanel.SelectedItem);
        }
    }
}

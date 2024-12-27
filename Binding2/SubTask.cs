using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

class SubTask
{
    private string _Name;
    public bool IsCompleted { get; set; }
    public string Name {  get { return _Name; } }
    public Brush Brush;

    public SubTask(string name, bool isColpeted = false)
    {
        _Name = name;
        IsCompleted = isColpeted;
        CheckComplet();
    }
    public void Complite()
    {
        IsCompleted = true;
        CheckComplet();
    }
    private void CheckComplet()
    {
        if (IsCompleted)
        {
            Brush = Brushes.Green;
            return;
        }
        if (!IsCompleted)
        {
            Brush = Brushes.Gray;
            return;
        }
    }
}


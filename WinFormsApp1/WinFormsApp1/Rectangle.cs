using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    private string _Name = string.Empty;
    private Panel _Element;
    private int[] _XY1 = new int[2];
    private int[] _XY2 = new int[2];
    public int Square { get { return GetSquare(); } }

    public string Name {  get { return _Name; } }
    public Panel Element { get { return _Element; } }
    public int X1 { get { return _XY1[0]; } }
    public int Y1 { get { return _XY1[1]; } }
    public int X2 { get { return _XY2[0]; } }
    public int Y2 { get { return _XY2[1]; } }

    public Rectangle(string name, Panel element, int x1, int y1, int x2, int y2)
    {
        _Name = name;
        _Element = element;
        _XY1[0] = x1;
        _XY1[1] = y1;
        _XY2[0] = x2;
        _XY2[1] = y2;
    }
    private int GetSquare()
    {
        int a = X2 - X1;
        int b = Y2 - Y1;
        if (a < 0) a = ~a + 1;
        if (b < 0) b = ~b + 1;
        return a+b;
    }
}


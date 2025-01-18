namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Rectangle> rectangles = new List<Rectangle>();
        private int X1;
        private int Y1;
        private int X2;
        private int Y2;
        private int PossX;
        private int PossY;
        private int PossX2;
        private int PossY2;
        public Form1()
        {
            InitializeComponent();
        }
        private int[] GetSize()
        {
            int[] result = new int[2];
            result[0] = X2 - X1;
            result[1] = Y2 - Y1;
            if (result[0] < 0) result[0] = ~result[0] +1;
            if (result[1] < 0) result[1] = ~result[1] +1;
            if(X1 > X2 & Y1 < Y2)
            {
                int x = X1 - X2;
                int y = Y2 - Y1;
                PossX = X1 - x; PossY = Y2 - y;
                PossX2 = X2 + x; PossY2 = Y1 + y;
                return result;
            }
            if (X1 < X2 & Y1 > Y2)
            {
                int x = X2 - X1;
                int y = Y1 - Y2;
                PossX = X2 - x; PossY = Y1 - y;
                PossX2 = X1 + x; PossY2 = Y2 + y;
                return result;
            }
            if (X1 < X2 & Y1 < Y2)
            {
                PossX = X1; PossY = Y1;
                PossX2 = X2; PossY2 = Y2;
                return result;
            }
            PossX = X2; PossY = Y2;
            PossX2 = X1; PossY2 = Y1;
            return result;
        }
        private void CreateRectangle(object sender)
        {
            var Size = GetSize();
            if (!CheckDistance())
            {
                ErrorInfo.Visible = true;
                return;
            }
            ErrorInfo.Visible = false;
            Panel rectangle = new Panel();
            rectangle.Location = new Point(PossX, PossY);
            rectangle.Name = "panel1";
            rectangle.Size = new Size(Size[0], Size[1]);
            rectangle.TabIndex = rectangles.Count + 1;
            rectangle.BackColor = Color.Gray;
            rectangle.MouseDoubleClick += MouseDoubleCkick;
            rectangle.MouseClick += MouseRightClick;
            Area.Controls.Add(rectangle);
            rectangles.Add(new Rectangle($"Rectangle", rectangle, PossX, PossY, PossX2, PossY2));
            RectanglCount.Text = $"Количство прямоугольков: {rectangles.Count}";
        }
        private void MouseDoubleCkick(object sender, MouseEventArgs e)
        {
            int RectangleIndex = 0;
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Element == (Panel)sender) RectangleIndex = i;
            }
            Area.Controls.Remove((Panel)sender);
            rectangles.RemoveAt(RectangleIndex);
            RectanglCount.Text = $"Количство прямоугольков: {rectangles.Count}";
        }
        private void MouseDownInArea(object sender, MouseEventArgs e)
        {
            X1 = e.X;
            Y1 = e.Y;
        }
        private bool CheckDistance()
        {
            int distanceX = ~(PossX - PossX2) + 1;
            int distanceY = ~(PossY - PossY2) + 1;
            if(distanceX < 10) return false;
            if(distanceY < 10) return false;
            return true;
        }
        private void MouseUpInArea(object sender, MouseEventArgs e)
        {
            X2 = e.X;
            Y2 = e.Y;
            
            CreateRectangle(sender);
        }
        private void MouseRightClick(object sender, MouseEventArgs e)
        {
            for(int i = 0; i < rectangles.Count; i++)
            {
                rectangles[i].Element.BackColor = Color.Gray;
            }
            if(e.Button != MouseButtons.Right) return;
            int RectangleIndex = 0;
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Element == (Panel)sender) RectangleIndex = i;
            }
            rectangles[RectangleIndex].Element.BackColor = Color.Orange;
            RectangleInfo.Text = $"Имя: {rectangles[RectangleIndex].Name}\nПлощадь: {rectangles[RectangleIndex].Square}\nВернхий левйы угол:\n   X: {rectangles[RectangleIndex].X1}\n   Y:{rectangles[RectangleIndex].Y1}\nПравый нинжний угол:\n   X: {rectangles[RectangleIndex].X2}\n   Y: {rectangles[RectangleIndex].Y1}";
        }
    }
}

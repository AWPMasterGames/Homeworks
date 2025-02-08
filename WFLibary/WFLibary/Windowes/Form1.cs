namespace WFLibary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == null || PasswordBox.Text == null)
            {
                MessageBox.Show("¬ведите логин и пароль!", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                var UserArray = UserResources.GetListOfUser().ToArray();
                for (int i = 0; i < UserArray.Length; i++)
                {
                    if (UserArray[i].Login == LoginBox.Text && PasswordBox.Text == UserArray[i].Password)
                    {
                        switch (UserArray[i].Permmisions)
                        {
                            case Permmisions.Admin:
                                Windowes.AdminMainWindow win = new Windowes.AdminMainWindow();
                                this.Visible = false;
                                if(win.ShowDialog() == DialogResult.Cancel)
                                {
                                    this.Close();
                                }
                                else
                                {
                                    this.Visible = true;
                                }
                                break;

                            case Permmisions.Worker:
                                Windowes.WorkerWindows.WorkerPanelWindow WorkerWindow = new Windowes.WorkerWindows.WorkerPanelWindow();
                                this.Visible = false;
                                if (WorkerWindow.ShowDialog() == DialogResult.Cancel)
                                {
                                    this.Close();
                                }
                                else
                                {
                                    this.Visible = true;
                                }
                                break;

                            case Permmisions.Visitor:
                                Windowes.VisitorWindow visitorWindow = new Windowes.VisitorWindow(i);
                                this.Visible = false;
                                if (visitorWindow.ShowDialog() == DialogResult.Cancel)
                                {
                                    this.Close();
                                }
                                else
                                {
                                    this.Visible = true;
                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}

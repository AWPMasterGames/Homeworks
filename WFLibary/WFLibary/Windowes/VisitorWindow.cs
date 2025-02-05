using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLibary.Windowes
{
    public partial class VisitorWindow : Form
    {
        public VisitorWindow(int userID)
        {
            User user = UserResources.GetListOfUser()[userID];
            InitializeComponent();
            Username.Text = user.Name;
            UserLogin.Text = user.Login;
            UserPassword.Text = user.Password;
            UserPermmisions.Text = user.Permmisions.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

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
    public partial class AdminMainWindow : Form
    {
        public AdminMainWindow()
        {
            InitializeComponent();
            listBox1.Items.AddRange(UserResources.GetListOfUser().ToArray());
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            AdminWindows.UserManagerWindow userManagerWindow = new AdminWindows.UserManagerWindow(user, true);
            if (userManagerWindow.ShowDialog() == DialogResult.OK)
            {
                UserResources.AddUserToLisr(user, listBox1);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            User user = UserResources.GetListOfUser()[listBox1.SelectedIndex];
            AdminWindows.UserManagerWindow userManagerWindow = new AdminWindows.UserManagerWindow(user, false);
            if (userManagerWindow.ShowDialog() == DialogResult.OK)
            {
                UserResources.EditUserToLisr(user, listBox1);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }

        private void delleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            if (listBox1.Items.Count <= 1) return;
            UserResources.RemoveUserToLisr(UserResources.GetListOfUser()[listBox1.SelectedIndex], listBox1);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}

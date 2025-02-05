using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLibary.Windowes.AdminWindows
{
    public partial class UserManagerWindow : Form
    {
        bool IsAdduser;
        User User;
        public UserManagerWindow(User user, bool addnew)
        {
            InitializeComponent();
            IsAdduser = addnew;
            User = user;
            comboBox1.Items.Add(Permmisions.Visitor.ToString());
            comboBox1.Items.Add(Permmisions.Worker.ToString());
            comboBox1.Items.Add(Permmisions.Admin.ToString());
            if (addnew)
            {
                this.Text = "Новый пользователь";
                button1.Text = "Добавить";
            }
            else
            {
                textBox1.Text = user.Name;
                textBox2.Text = user.Login;
                textBox3.Text = user.Password;
                comboBox1.SelectedIndex = (int)user.Permmisions;
                this.Text = "Редактирование пользователя";
                button1.Text = "Сохранить";
            }
        }

        private Permmisions SetPermmis()
        {
            Permmisions per = Permmisions.Visitor;
            switch (comboBox1.SelectedItem)
            {
                case "Visitor":
                    per = Permmisions.Visitor;
                    break;
                case "Worker":
                    per = Permmisions.Worker;
                    break;
                case "Admin":
                    per = Permmisions.Admin;
                    break;
                default:
                    per = Permmisions.Visitor;
                    break;
            }
            return per;
        }
        /*private bool CheckAdmins()
        {
            var Users = UserResources.GetListOfUser();
            
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null)
            {
                MessageBox.Show("Заполните все поля");
            }
            if (!IsAdduser & SetPermmis() != Permmisions.Admin)
            {

            }
            User.Name = textBox1.Text;
            User.Login = textBox2.Text;
            User.Password = textBox3.Text;
            User.Permmisions = SetPermmis();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

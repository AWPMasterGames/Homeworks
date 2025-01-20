namespace GuessUserNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        User user;
        Bot bot;
        private void button1_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            int inputNumber = 0;
            try
            {
                inputNumber = Int32.Parse(UserInputTB.Text);
            }
            catch(FormatException) {
                ErrorLabel.Text = "Ошибка: Неверный формат!   Укажите целое число";
                return;
            }
            UserInputTB.Visible = false;
            UserInputL.Text = UserInputTB.Text;
            UserInputL.Visible = true;
            user = new User(inputNumber);
            bot = new Bot(user);
            SeeResult();
        }
        private void SeeResult()
        {
            DialogResult result = MessageBox.Show($"Загаданное число: {bot.GetNumber()}\nКоличество попыток: {bot.TryCount}", "Информация Бота",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                UserInputTB.Visible = true;
                UserInputL.Visible = false;
            }
            this.TopMost = true;
        }
    }
}

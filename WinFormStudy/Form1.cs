namespace WinFormStudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonStudy.Text = "OK";
        }

        private void buttonStudy_MouseEnter(object sender, EventArgs e)
        {

            buttonStudy.Text = "Enter";
        }

        private void buttonStudy_MouseLeave(object sender, EventArgs e)
        {

            buttonStudy.Text = "Leave";
        }
    }
}

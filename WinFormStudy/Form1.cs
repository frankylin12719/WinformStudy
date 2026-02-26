namespace WinFormStudy
{
    public partial class Form1 : Form
    {
        Button btn;
        public Form1()
        {
            InitializeComponent();
            btn = new()
            {
                Text = "OK new",
                Location = new Point(20, 20),
                Width = 100,
                Height = 100
            };
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
        }


        private void Btn_Click(object? sender, EventArgs e)
        {
            btn.Text = "OKK";
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

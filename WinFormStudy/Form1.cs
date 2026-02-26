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
            for (int i = 0; i < 4; i++)
            {
                Button buttonLoop = new()
                {
                    Text = "btn" + i,
                    Location = new Point(100 + i * 40, 100 + i * 50),
                    Width = 150,
                    Height = 50
                };
                buttonLoop.Click += ButtonLoop_Click;
                this.Controls.Add(buttonLoop);
            }
        }

        private void ButtonLoop_Click(object? sender, EventArgs e)
        {
            
            if (sender != null)
            {
                Button btnLoop = (Button)sender;
                btnLoop.Text = "Clicked";
            }
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

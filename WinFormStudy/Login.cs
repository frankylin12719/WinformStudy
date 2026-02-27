using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormStudy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("点！！！");
            string account = textBox1.Text;
            string password = textBox2.Text;

            //MessageBox.Show(account + password);
            if (account != "1111")
            {
                MessageBox.Show("账号有误");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            if (password != "2222")
            {
                MessageBox.Show("密码有误");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            //MessageBox.Show("验证通过，跳转中...");
            Home home = new(account);
            home.Show();

            this.Hide(); //单例模式 this 指的是 login


        }
    }
}

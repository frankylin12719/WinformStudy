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
    public partial class Home : Form
    {
        public Home(String account)
        {
            InitializeComponent();
            label2.Text = "Hi，" + account + "- " + GlobalFunc.Instance.Name +"- PASSWORD:"+GlobalFunc.Instance.PasswordG;
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

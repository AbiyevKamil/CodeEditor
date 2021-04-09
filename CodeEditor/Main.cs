using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emulator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup signupPage = new Signup();
            this.Hide();
            signupPage.Show();
        }

        private void buttonLoginPage_Click(object sender, EventArgs e)
        {
            Login loginPage = new Login();
            this.Hide();
            loginPage.Show();
        }
    }
}

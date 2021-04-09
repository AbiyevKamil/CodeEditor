using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Emulator
{
    public partial class Login : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public Login()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("hh:mm tt");
            labelNowTime.Text = time;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timerNow.Start();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string dataMemberDirectory = @"\Data\" + username;
            string winDir = Path.GetDirectoryName(Application.ExecutablePath);
            string path = winDir + dataMemberDirectory;
            string dataFilePath = path + @"\data.txt";
            if (username != "" && password != "")
            {
                if (Directory.Exists(path))
                {
                    StreamReader srForPassword = new StreamReader(dataFilePath);
                    srForPassword.ReadLine();
                    srForPassword.ReadLine();
                    string passwordSaved = srForPassword.ReadLine();
                    if (passwordSaved == password)
                    {
                        CodeEditor cd = new CodeEditor(username);
                        cd.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //string passwordSaved = File.ReadLines(dataFilePath).ToString();
                    // MessageBox.Show(passwordSaved);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Wrong Username \nClick OK if you want to sign up.", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                        Signup mainForm = new Signup();
                        mainForm.Visible = true;
                    }
                }
            }
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please register again!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
            Signup mainForm = new Signup();
            mainForm.Visible = true;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            } else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
    }
}

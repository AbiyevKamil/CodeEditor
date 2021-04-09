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
    public partial class Signup : Form
    {
        Login LoginForm = new Login();
        private bool mouseDown;
        private Point lastLocation;
        public Signup()
        {
            InitializeComponent();
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timerNow.Start();
            textBoxPassword.PasswordChar = '*';
            textBoxAgainPassword.PasswordChar = '*';
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void labelHaveAccount_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Visible = false;
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
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

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string name = textBoxNameSurname.Text;
            string password = textBoxPassword.Text;
            string passwordAgain = textBoxAgainPassword.Text;
            if (password == passwordAgain)
            {
                if (username.Contains(" ") || username.Contains("#") || username.Contains("<") || username.Contains("$") || username.Contains("+") || username.Contains("%") || username.Contains(">") || username.Contains("`") || username.Contains("!") || username.Contains("&") || username.Contains("*") || username.Contains("'") || username.Contains("|") || username.Contains("{") || username.Contains("}") || username.Contains("?") || username.Contains("\"") || username.Contains("=") || username.Contains("/") || username.Contains(":") || username.Contains("@"))
                {
                    MessageBox.Show("Username can`t contain any of the following characters:\n! \" ' / ! ? < > # $ + % ! *", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (username != "" && name != "" && password != "" && passwordAgain != "" && !username.Contains(" "))
                {
                    string dataMemberDirectory = @"\Data\" + username;
                    string winDir = Path.GetDirectoryName(Application.ExecutablePath);
                    string path = winDir + dataMemberDirectory;
                    string dataFilePath = path + @"\data.txt";
                    string notesFilePath = path + @"\notes.txt";
                    string htmlFilePath = path + @"\index.html";
                    string cssFilePath = path + @"\main.css";
                    string jsFilePath = path + @"\main.js";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                        FileStream dataFile = File.Create(dataFilePath);
                        StreamWriter swDataFile = new StreamWriter(dataFile);
                        swDataFile.WriteLine(username);
                        swDataFile.WriteLine(name);
                        swDataFile.WriteLine(password);

                        // HTML AREA
                        FileStream htmlFile = File.Create(htmlFilePath);
                        htmlFile.Close();

                        // CSS AREA
                        FileStream cssFile = File.Create(cssFilePath);
                        cssFile.Close();
                        // JS AREA
                        FileStream jsFile = File.Create(jsFilePath);
                        jsFile.Close();

                        swDataFile.Close();
                        LoginForm.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Username already exists!", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (username == "" || name == "" || password == "" || passwordAgain == "")
                {
                    MessageBox.Show("Fill the form!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Passwords doesn`t match!", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxAgainPassword.PasswordChar = '\0';
            }
            else
            {

                textBoxPassword.PasswordChar = '*';
                textBoxAgainPassword.PasswordChar = '*';
            }
        }
    }
}

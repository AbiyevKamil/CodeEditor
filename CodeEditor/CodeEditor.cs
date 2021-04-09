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
    public partial class CodeEditor : Form
    {
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        public CodeEditor(string username)
        {
            InitializeComponent();
            labelUsername.Text = "Welcome back, " + username + ".";
            labelTemporary.Text = username;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            Login loginForm = new Login();
            string username = labelTemporary.Text;
            string cssCodes = textBoxCSSInput.Text;
            string htmlCodes = textBoxHTMLInput.Text;
            string jsCodes = textBoxJSInput.Text;
            string dataMemberDirectory = @"\Data\" + username;
            string winDir = Path.GetDirectoryName(Application.ExecutablePath);
            string path = winDir + dataMemberDirectory;
            string dataFilePath = path + @"\data.txt";
            string htmlFilePath = path + @"\index.html";
            string htmlSavePath = path + @"\htmlData.txt";
            string cssFilePath = path + @"\main.css";
            string jsFilePath = path + @"\main.js";
            string fileName = htmlFilePath;
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileName
            };
            process.Start();
            if (!process.HasExited)
            {
                process.Kill();
            }
            if (Directory.Exists(path))
            {
                // HTML AREA
                using (StreamWriter swHtmlFile = new StreamWriter(htmlFilePath))
                {
                    swHtmlFile.WriteLine("<!DOCTYPE html>");
                    swHtmlFile.WriteLine("<html lang=\"en\">");
                    swHtmlFile.WriteLine("<head>");
                    swHtmlFile.WriteLine("<meta http-equiv=\"content - type\" content=\"text / html; charset = utf - 8\" />");
                    swHtmlFile.WriteLine("<meta content=\"text / html; charset = utf - 8\" http-equiv=\"Content - Type\">");
                    swHtmlFile.WriteLine("<meta content=\"utf - 8\" http-equiv=\"encoding\">");
                    swHtmlFile.WriteLine("<meta charset=\"UTF - 8\">");
                    swHtmlFile.WriteLine("<meta http-equiv=\"X - UA - Compatible\" content=\"IE = edge\">");
                    swHtmlFile.WriteLine("<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\">");
                    swHtmlFile.WriteLine("<title>Document</title>");
                    swHtmlFile.WriteLine("<link rel=\"stylesheet\" href=\"./main.css\">");
                    swHtmlFile.WriteLine("</head>");
                    swHtmlFile.WriteLine("<body>");
                    swHtmlFile.WriteLine(htmlCodes);
                    swHtmlFile.WriteLine("<script src=\"./main.js\"></script>");
                    swHtmlFile.WriteLine("</body>");
                    swHtmlFile.WriteLine("</html>");
                    swHtmlFile.Close();
                    StreamWriter saveHtmlCode = new StreamWriter(htmlSavePath);
                    saveHtmlCode.WriteLine(htmlCodes);
                    saveHtmlCode.Close();
                }
                // CSS AREA
                using (StreamWriter swCssFile = new StreamWriter(cssFilePath))
                {
                    swCssFile.WriteLine(cssCodes);
                    swCssFile.Close();
                }
                // JS AREA
                using (StreamWriter swJSFile = new StreamWriter(jsFilePath))
                {
                    swJSFile.WriteLine(jsCodes);
                    swJSFile.Close();
                }
            }
        }

        private void CodeEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            string username = labelTemporary.Text;
            string dataMemberDirectory = @"\Data\" + username;
            string winDir = Path.GetDirectoryName(Application.ExecutablePath);
            string path = winDir + dataMemberDirectory;
            string htmlFilePath = path + @"\index.html";
            string cssFilePath = path + @"\main.css";
            string jsFilePath = path + @"\main.js";
            StreamReader readHTML = new StreamReader(htmlFilePath);

            string fileName = htmlFilePath;
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileName
            };
            process.Start();
            process.WaitForExit();

            readHTML.Close();
        }

        private void CodeEditor_Load(object sender, EventArgs e)
        {
            string username = labelTemporary.Text;
            string dataMemberDirectory = @"\Data\" + username;
            string winDir = Path.GetDirectoryName(Application.ExecutablePath);
            string path = winDir + dataMemberDirectory;
            string htmlFilePath = path + @"\index.html";
            string htmlSavePath = path + @"\htmlData.txt";
            string cssFilePath = path + @"\main.css";
            string jsFilePath = path + @"\main.js";
            if (File.Exists(htmlSavePath))
            {
                StreamReader readHTML = new StreamReader(htmlSavePath);
                StreamReader readCSS = new StreamReader(cssFilePath);
                StreamReader readJS = new StreamReader(jsFilePath);
                textBoxCSSInput.Text = readCSS.ReadToEnd();
                textBoxHTMLInput.Text = readHTML.ReadToEnd();
                textBoxJSInput.Text = readJS.ReadToEnd();
                readHTML.Close();
                readCSS.Close();
                readJS.Close();
            }

        }

    }
}

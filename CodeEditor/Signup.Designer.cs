
namespace Emulator
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonCloseWindow = new System.Windows.Forms.Button();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordAgain = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxNameSurname = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxAgainPassword = new System.Windows.Forms.TextBox();
            this.labelHaveAccount = new System.Windows.Forms.Label();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.labelNowTime = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMinimize.Location = new System.Drawing.Point(481, 1);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(43, 34);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.Text = "-";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonCloseWindow
            // 
            this.buttonCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseWindow.FlatAppearance.BorderSize = 0;
            this.buttonCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseWindow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseWindow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseWindow.Location = new System.Drawing.Point(586, 2);
            this.buttonCloseWindow.Name = "buttonCloseWindow";
            this.buttonCloseWindow.Size = new System.Drawing.Size(51, 33);
            this.buttonCloseWindow.TabIndex = 1;
            this.buttonCloseWindow.Text = "X";
            this.buttonCloseWindow.UseVisualStyleBackColor = true;
            this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
            // 
            // labelSignUp
            // 
            this.labelSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSignUp.Location = new System.Drawing.Point(263, 57);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(121, 33);
            this.labelSignUp.TabIndex = 3;
            this.labelSignUp.Text = "Sign Up";
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaximize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMaximize.Location = new System.Drawing.Point(527, 1);
            this.buttonMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(56, 34);
            this.buttonMaximize.TabIndex = 15;
            this.buttonMaximize.Text = "/-/";
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsername.Location = new System.Drawing.Point(117, 124);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(129, 27);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username:";
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSurname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNameSurname.Location = new System.Drawing.Point(52, 163);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(194, 27);
            this.labelNameSurname.TabIndex = 6;
            this.labelNameSurname.Text = "Name, Surname:";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPassword.Location = new System.Drawing.Point(122, 207);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(124, 27);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password:";
            // 
            // labelPasswordAgain
            // 
            this.labelPasswordAgain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPasswordAgain.AutoSize = true;
            this.labelPasswordAgain.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordAgain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPasswordAgain.Location = new System.Drawing.Point(56, 254);
            this.labelPasswordAgain.Name = "labelPasswordAgain";
            this.labelPasswordAgain.Size = new System.Drawing.Size(190, 27);
            this.labelPasswordAgain.TabIndex = 8;
            this.labelPasswordAgain.Text = "Again password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(269, 120);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(230, 31);
            this.textBoxUsername.TabIndex = 9;
            // 
            // textBoxNameSurname
            // 
            this.textBoxNameSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNameSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameSurname.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameSurname.Location = new System.Drawing.Point(269, 162);
            this.textBoxNameSurname.Name = "textBoxNameSurname";
            this.textBoxNameSurname.Size = new System.Drawing.Size(230, 31);
            this.textBoxNameSurname.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(269, 209);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(230, 31);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxAgainPassword
            // 
            this.textBoxAgainPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAgainPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAgainPassword.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAgainPassword.Location = new System.Drawing.Point(269, 256);
            this.textBoxAgainPassword.Name = "textBoxAgainPassword";
            this.textBoxAgainPassword.Size = new System.Drawing.Size(230, 31);
            this.textBoxAgainPassword.TabIndex = 12;
            // 
            // labelHaveAccount
            // 
            this.labelHaveAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHaveAccount.AutoSize = true;
            this.labelHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.labelHaveAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHaveAccount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHaveAccount.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelHaveAccount.Location = new System.Drawing.Point(265, 343);
            this.labelHaveAccount.Name = "labelHaveAccount";
            this.labelHaveAccount.Size = new System.Drawing.Size(242, 23);
            this.labelHaveAccount.TabIndex = 13;
            this.labelHaveAccount.Text = "Already have an account ?";
            this.labelHaveAccount.Click += new System.EventHandler(this.labelHaveAccount_Click);
            // 
            // buttonSignup
            // 
            this.buttonSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSignup.BackColor = System.Drawing.Color.Transparent;
            this.buttonSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignup.FlatAppearance.BorderSize = 0;
            this.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignup.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup.ForeColor = System.Drawing.Color.Crimson;
            this.buttonSignup.Location = new System.Drawing.Point(232, 378);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(181, 44);
            this.buttonSignup.TabIndex = 14;
            this.buttonSignup.Text = "Sign up";
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // timerNow
            // 
            this.timerNow.Interval = 1000;
            this.timerNow.Tick += new System.EventHandler(this.timerNow_Tick);
            // 
            // labelNowTime
            // 
            this.labelNowTime.AutoSize = true;
            this.labelNowTime.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNowTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNowTime.Location = new System.Drawing.Point(12, 9);
            this.labelNowTime.Name = "labelNowTime";
            this.labelNowTime.Size = new System.Drawing.Size(71, 27);
            this.labelNowTime.TabIndex = 17;
            this.labelNowTime.Text = "00:00";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(269, 302);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(144, 27);
            this.checkBoxShowPassword.TabIndex = 23;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.labelNowTime);
            this.Controls.Add(this.buttonMaximize);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonSignup);
            this.Controls.Add(this.labelHaveAccount);
            this.Controls.Add(this.textBoxAgainPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNameSurname);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPasswordAgain);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNameSurname);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.buttonCloseWindow);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(646, 456);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordAgain;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxNameSurname;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxAgainPassword;
        private System.Windows.Forms.Label labelHaveAccount;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.Label labelNowTime;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}


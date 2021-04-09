
namespace Emulator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonLoginPage = new System.Windows.Forms.Button();
            this.buttonSignupPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoginPage
            // 
            this.buttonLoginPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLoginPage.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLoginPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoginPage.FlatAppearance.BorderSize = 0;
            this.buttonLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginPage.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoginPage.Location = new System.Drawing.Point(315, 134);
            this.buttonLoginPage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonLoginPage.Name = "buttonLoginPage";
            this.buttonLoginPage.Size = new System.Drawing.Size(345, 115);
            this.buttonLoginPage.TabIndex = 0;
            this.buttonLoginPage.Text = "Login";
            this.buttonLoginPage.UseVisualStyleBackColor = false;
            this.buttonLoginPage.Click += new System.EventHandler(this.buttonLoginPage_Click);
            // 
            // buttonSignupPage
            // 
            this.buttonSignupPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSignupPage.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSignupPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignupPage.FlatAppearance.BorderSize = 0;
            this.buttonSignupPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignupPage.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignupPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSignupPage.Location = new System.Drawing.Point(315, 289);
            this.buttonSignupPage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonSignupPage.Name = "buttonSignupPage";
            this.buttonSignupPage.Size = new System.Drawing.Size(345, 115);
            this.buttonSignupPage.TabIndex = 1;
            this.buttonSignupPage.Text = "Sign Up";
            this.buttonSignupPage.UseVisualStyleBackColor = false;
            this.buttonSignupPage.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(967, 550);
            this.Controls.Add(this.buttonSignupPage);
            this.Controls.Add(this.buttonLoginPage);
            this.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Code Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginPage;
        private System.Windows.Forms.Button buttonSignupPage;
    }
}
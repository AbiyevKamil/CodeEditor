
namespace Emulator
{
    partial class CodeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEditor));
            this.textBoxCSSInput = new System.Windows.Forms.TextBox();
            this.labelCSS = new System.Windows.Forms.Label();
            this.labelHTML = new System.Windows.Forms.Label();
            this.textBoxHTMLInput = new System.Windows.Forms.TextBox();
            this.labelJS = new System.Windows.Forms.Label();
            this.textBoxJSInput = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTemporary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCSSInput
            // 
            this.textBoxCSSInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxCSSInput.ForeColor = System.Drawing.Color.Gold;
            this.textBoxCSSInput.Location = new System.Drawing.Point(12, 66);
            this.textBoxCSSInput.Multiline = true;
            this.textBoxCSSInput.Name = "textBoxCSSInput";
            this.textBoxCSSInput.Size = new System.Drawing.Size(483, 659);
            this.textBoxCSSInput.TabIndex = 0;
            // 
            // labelCSS
            // 
            this.labelCSS.AutoSize = true;
            this.labelCSS.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCSS.ForeColor = System.Drawing.Color.Crimson;
            this.labelCSS.Location = new System.Drawing.Point(12, 42);
            this.labelCSS.Name = "labelCSS";
            this.labelCSS.Size = new System.Drawing.Size(45, 20);
            this.labelCSS.TabIndex = 1;
            this.labelCSS.Text = "CSS";
            // 
            // labelHTML
            // 
            this.labelHTML.AutoSize = true;
            this.labelHTML.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHTML.ForeColor = System.Drawing.Color.Crimson;
            this.labelHTML.Location = new System.Drawing.Point(508, 43);
            this.labelHTML.Name = "labelHTML";
            this.labelHTML.Size = new System.Drawing.Size(62, 20);
            this.labelHTML.TabIndex = 3;
            this.labelHTML.Text = "HTML";
            // 
            // textBoxHTMLInput
            // 
            this.textBoxHTMLInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxHTMLInput.ForeColor = System.Drawing.Color.Gold;
            this.textBoxHTMLInput.Location = new System.Drawing.Point(512, 66);
            this.textBoxHTMLInput.Multiline = true;
            this.textBoxHTMLInput.Name = "textBoxHTMLInput";
            this.textBoxHTMLInput.Size = new System.Drawing.Size(474, 659);
            this.textBoxHTMLInput.TabIndex = 2;
            // 
            // labelJS
            // 
            this.labelJS.AutoSize = true;
            this.labelJS.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJS.ForeColor = System.Drawing.Color.Crimson;
            this.labelJS.Location = new System.Drawing.Point(997, 42);
            this.labelJS.Name = "labelJS";
            this.labelJS.Size = new System.Drawing.Size(105, 20);
            this.labelJS.TabIndex = 5;
            this.labelJS.Text = "Javascript";
            // 
            // textBoxJSInput
            // 
            this.textBoxJSInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxJSInput.ForeColor = System.Drawing.Color.Gold;
            this.textBoxJSInput.Location = new System.Drawing.Point(1001, 66);
            this.textBoxJSInput.Multiline = true;
            this.textBoxJSInput.Name = "textBoxJSInput";
            this.textBoxJSInput.Size = new System.Drawing.Size(512, 659);
            this.textBoxJSInput.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.Location = new System.Drawing.Point(637, 751);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.buttonSave.Size = new System.Drawing.Size(121, 56);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRun.BackColor = System.Drawing.Color.Transparent;
            this.buttonRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRun.FlatAppearance.BorderSize = 0;
            this.buttonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRun.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.buttonRun.Image = ((System.Drawing.Image)(resources.GetObject("buttonRun.Image")));
            this.buttonRun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRun.Location = new System.Drawing.Point(773, 751);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Padding = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.buttonRun.Size = new System.Drawing.Size(109, 56);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = "Run";
            this.buttonRun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(8, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(103, 20);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username:";
            // 
            // labelTemporary
            // 
            this.labelTemporary.AutoSize = true;
            this.labelTemporary.Location = new System.Drawing.Point(408, 9);
            this.labelTemporary.Name = "labelTemporary";
            this.labelTemporary.Size = new System.Drawing.Size(0, 20);
            this.labelTemporary.TabIndex = 9;
            this.labelTemporary.Visible = false;
            // 
            // CodeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 819);
            this.Controls.Add(this.labelTemporary);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelJS);
            this.Controls.Add(this.textBoxJSInput);
            this.Controls.Add(this.labelHTML);
            this.Controls.Add(this.textBoxHTMLInput);
            this.Controls.Add(this.labelCSS);
            this.Controls.Add(this.textBoxCSSInput);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CodeEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CodeEditor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodeEditor_FormClosing);
            this.Load += new System.EventHandler(this.CodeEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCSSInput;
        private System.Windows.Forms.Label labelCSS;
        private System.Windows.Forms.Label labelHTML;
        private System.Windows.Forms.TextBox textBoxHTMLInput;
        private System.Windows.Forms.Label labelJS;
        private System.Windows.Forms.TextBox textBoxJSInput;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelTemporary;
    }
}
﻿
namespace amazingAdventures
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.Use = new System.Windows.Forms.Label();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usrnInvalidFirstLabel = new System.Windows.Forms.Label();
            this.usrnInvalidSecondLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginBtn.Location = new System.Drawing.Point(140, 176);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(199, 35);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.loginPasswordLabel.Location = new System.Drawing.Point(100, 163);
            this.loginPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(97, 24);
            this.loginPasswordLabel.TabIndex = 10;
            this.loginPasswordLabel.Text = "Password:";
            this.loginPasswordLabel.Visible = false;
            // 
            // Use
            // 
            this.Use.AutoSize = true;
            this.Use.BackColor = System.Drawing.Color.Transparent;
            this.Use.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Use.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Use.Location = new System.Drawing.Point(100, 98);
            this.Use.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Use.Name = "Use";
            this.Use.Size = new System.Drawing.Size(102, 24);
            this.Use.TabIndex = 9;
            this.Use.Text = "Username:";
            // 
            // loginPassword
            // 
            this.loginPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.loginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.loginPassword.Location = new System.Drawing.Point(104, 189);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(2);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(287, 29);
            this.loginPassword.TabIndex = 8;
            this.loginPassword.Visible = false;
            // 
            // loginUsername
            // 
            this.loginUsername.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.loginUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.loginUsername.Location = new System.Drawing.Point(104, 124);
            this.loginUsername.Margin = new System.Windows.Forms.Padding(2);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(287, 29);
            this.loginUsername.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(74, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amazing Adventures";
            // 
            // usrnInvalidFirstLabel
            // 
            this.usrnInvalidFirstLabel.AutoSize = true;
            this.usrnInvalidFirstLabel.BackColor = System.Drawing.Color.Transparent;
            this.usrnInvalidFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usrnInvalidFirstLabel.ForeColor = System.Drawing.Color.LightSalmon;
            this.usrnInvalidFirstLabel.Location = new System.Drawing.Point(162, 225);
            this.usrnInvalidFirstLabel.MinimumSize = new System.Drawing.Size(128, 17);
            this.usrnInvalidFirstLabel.Name = "usrnInvalidFirstLabel";
            this.usrnInvalidFirstLabel.Size = new System.Drawing.Size(165, 17);
            this.usrnInvalidFirstLabel.TabIndex = 12;
            this.usrnInvalidFirstLabel.Text = "New Username Detected";
            this.usrnInvalidFirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrnInvalidFirstLabel.Visible = false;
            // 
            // usrnInvalidSecondLabel
            // 
            this.usrnInvalidSecondLabel.AutoSize = true;
            this.usrnInvalidSecondLabel.BackColor = System.Drawing.Color.Transparent;
            this.usrnInvalidSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnInvalidSecondLabel.ForeColor = System.Drawing.Color.LightSalmon;
            this.usrnInvalidSecondLabel.Location = new System.Drawing.Point(73, 245);
            this.usrnInvalidSecondLabel.MinimumSize = new System.Drawing.Size(323, 16);
            this.usrnInvalidSecondLabel.Name = "usrnInvalidSecondLabel";
            this.usrnInvalidSecondLabel.Size = new System.Drawing.Size(361, 16);
            this.usrnInvalidSecondLabel.TabIndex = 13;
            this.usrnInvalidSecondLabel.Text = "Please enter the correct account details to proceed";
            this.usrnInvalidSecondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrnInvalidSecondLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::amazingAdventures.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(492, 372);
            this.Controls.Add(this.usrnInvalidSecondLabel);
            this.Controls.Add(this.usrnInvalidFirstLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginPasswordLabel);
            this.Controls.Add(this.Use);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label Use;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usrnInvalidFirstLabel;
        private System.Windows.Forms.Label usrnInvalidSecondLabel;
        public System.Windows.Forms.Label loginPasswordLabel;
        public System.Windows.Forms.TextBox loginPassword;
    }
}


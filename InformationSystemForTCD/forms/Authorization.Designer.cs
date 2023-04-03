
namespace InformationSystemForTCD
{
    partial class Authorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Welcome = new System.Windows.Forms.Label();
            this.EnterLoginAndPassword = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Welcome.Location = new System.Drawing.Point(-52, 13);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(552, 32);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = " Добро пожаловать!";
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EnterLoginAndPassword
            // 
            this.EnterLoginAndPassword.AutoSize = true;
            this.EnterLoginAndPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterLoginAndPassword.Location = new System.Drawing.Point(59, 53);
            this.EnterLoginAndPassword.Name = "EnterLoginAndPassword";
            this.EnterLoginAndPassword.Size = new System.Drawing.Size(329, 28);
            this.EnterLoginAndPassword.TabIndex = 1;
            this.EnterLoginAndPassword.Text = "Введите логин и пароль для входа";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(25, 77);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '•';
            this.PasswordBox.PlaceholderText = "password";
            this.PasswordBox.Size = new System.Drawing.Size(202, 27);
            this.PasswordBox.TabIndex = 2;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(25, 29);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.PlaceholderText = "login";
            this.LoginBox.Size = new System.Drawing.Size(202, 27);
            this.LoginBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowPassword);
            this.groupBox1.Controls.Add(this.LoginBox);
            this.groupBox1.Controls.Add(this.PasswordBox);
            this.groupBox1.Location = new System.Drawing.Point(101, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 148);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(54, 114);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(150, 24);
            this.ShowPassword.TabIndex = 3;
            this.ShowPassword.Text = "Показать пароль";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LoginButton.Location = new System.Drawing.Point(126, 252);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(202, 29);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 293);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EnterLoginAndPassword);
            this.Controls.Add(this.Welcome);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(470, 340);
            this.MinimumSize = new System.Drawing.Size(470, 340);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label EnterLoginAndPassword;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox ShowPassword;
    }
}


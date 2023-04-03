
namespace InformationSystemForTCD.forms
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProfileImage = new System.Windows.Forms.PictureBox();
            this.Information = new System.Windows.Forms.GroupBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.Actions = new System.Windows.Forms.GroupBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ServicesButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.ArchiveButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).BeginInit();
            this.Information.SuspendLayout();
            this.Actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfileImage
            // 
            this.ProfileImage.Location = new System.Drawing.Point(185, 12);
            this.ProfileImage.Name = "ProfileImage";
            this.ProfileImage.Size = new System.Drawing.Size(182, 186);
            this.ProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileImage.TabIndex = 0;
            this.ProfileImage.TabStop = false;
            // 
            // Information
            // 
            this.Information.Controls.Add(this.AddressBox);
            this.Information.Controls.Add(this.NumberBox);
            this.Information.Controls.Add(this.PasswordBox);
            this.Information.Controls.Add(this.NameBox);
            this.Information.Controls.Add(this.EmailBox);
            this.Information.Controls.Add(this.SurnameBox);
            this.Information.Controls.Add(this.LoginBox);
            this.Information.Location = new System.Drawing.Point(10, 212);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(262, 270);
            this.Information.TabIndex = 1;
            this.Information.TabStop = false;
            this.Information.Text = "Информация";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(22, 158);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(218, 27);
            this.AddressBox.TabIndex = 4;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(22, 191);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(218, 27);
            this.NumberBox.TabIndex = 5;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(22, 59);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '•';
            this.PasswordBox.Size = new System.Drawing.Size(218, 27);
            this.PasswordBox.TabIndex = 1;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(22, 92);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(218, 27);
            this.NameBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(22, 224);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(218, 27);
            this.EmailBox.TabIndex = 6;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(22, 125);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(218, 27);
            this.SurnameBox.TabIndex = 3;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(22, 26);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(218, 27);
            this.LoginBox.TabIndex = 0;
            // 
            // Actions
            // 
            this.Actions.Controls.Add(this.ShowPassword);
            this.Actions.Controls.Add(this.SaveButton);
            this.Actions.Controls.Add(this.Exit);
            this.Actions.Controls.Add(this.ServicesButton);
            this.Actions.Controls.Add(this.ClientsButton);
            this.Actions.Controls.Add(this.ArchiveButton);
            this.Actions.Controls.Add(this.OrdersButton);
            this.Actions.Location = new System.Drawing.Point(280, 212);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(262, 270);
            this.Actions.TabIndex = 2;
            this.Actions.TabStop = false;
            this.Actions.Text = "Действия";
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(55, 161);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(150, 24);
            this.ShowPassword.TabIndex = 13;
            this.ShowPassword.Text = "Показать пароль";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SaveButton.Location = new System.Drawing.Point(21, 191);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(218, 29);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Сохранить изменения";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Salmon;
            this.Exit.Location = new System.Drawing.Point(21, 224);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(218, 29);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ServicesButton
            // 
            this.ServicesButton.Location = new System.Drawing.Point(21, 125);
            this.ServicesButton.Name = "ServicesButton";
            this.ServicesButton.Size = new System.Drawing.Size(218, 29);
            this.ServicesButton.TabIndex = 10;
            this.ServicesButton.Text = "Услуги";
            this.ServicesButton.UseVisualStyleBackColor = true;
            // 
            // ClientsButton
            // 
            this.ClientsButton.Location = new System.Drawing.Point(21, 92);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(218, 29);
            this.ClientsButton.TabIndex = 9;
            this.ClientsButton.Text = "Клиенты";
            this.ClientsButton.UseVisualStyleBackColor = true;
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.Location = new System.Drawing.Point(21, 59);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(218, 29);
            this.ArchiveButton.TabIndex = 8;
            this.ArchiveButton.Text = "Архив";
            this.ArchiveButton.UseVisualStyleBackColor = true;
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(21, 26);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(218, 29);
            this.OrdersButton.TabIndex = 7;
            this.OrdersButton.Text = "Все заказы";
            this.OrdersButton.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 497);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.ProfileImage);
            this.MaximumSize = new System.Drawing.Size(569, 544);
            this.MinimumSize = new System.Drawing.Size(569, 544);
            this.Name = "Profile";
            this.Text = "Профиль";
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImage)).EndInit();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.Actions.ResumeLayout(false);
            this.Actions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfileImage;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.GroupBox Actions;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ServicesButton;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button ArchiveButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.CheckBox ShowPassword;
    }
}
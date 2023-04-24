
namespace InformationSystemForTCD.forms
{
    partial class ClientForm
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
            this.clientsTable = new System.Windows.Forms.DataGridView();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsTable
            // 
            this.clientsTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.clientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsTable.Location = new System.Drawing.Point(12, 11);
            this.clientsTable.Name = "clientsTable";
            this.clientsTable.ReadOnly = true;
            this.clientsTable.RowHeadersWidth = 51;
            this.clientsTable.RowTemplate.Height = 29;
            this.clientsTable.Size = new System.Drawing.Size(926, 348);
            this.clientsTable.TabIndex = 0;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(9, 26);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.PlaceholderText = "Фамилия";
            this.surnameBox.Size = new System.Drawing.Size(125, 27);
            this.surnameBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(140, 26);
            this.nameBox.Name = "nameBox";
            this.nameBox.PlaceholderText = "Имя";
            this.nameBox.Size = new System.Drawing.Size(125, 27);
            this.nameBox.TabIndex = 2;
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(271, 26);
            this.numberBox.Name = "numberBox";
            this.numberBox.PlaceholderText = "Номер";
            this.numberBox.Size = new System.Drawing.Size(125, 27);
            this.numberBox.TabIndex = 3;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(402, 26);
            this.emailBox.Name = "emailBox";
            this.emailBox.PlaceholderText = "Почта";
            this.emailBox.Size = new System.Drawing.Size(125, 27);
            this.emailBox.TabIndex = 4;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(533, 26);
            this.addressBox.Name = "addressBox";
            this.addressBox.PlaceholderText = "Адрес";
            this.addressBox.Size = new System.Drawing.Size(125, 27);
            this.addressBox.TabIndex = 5;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(664, 26);
            this.loginBox.Name = "loginBox";
            this.loginBox.PlaceholderText = "Логин";
            this.loginBox.Size = new System.Drawing.Size(125, 27);
            this.loginBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(795, 26);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PlaceholderText = "Пароль";
            this.passwordBox.Size = new System.Drawing.Size(125, 27);
            this.passwordBox.TabIndex = 7;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.addButton);
            this.groupBox.Controls.Add(this.numberBox);
            this.groupBox.Controls.Add(this.exitButton);
            this.groupBox.Controls.Add(this.passwordBox);
            this.groupBox.Controls.Add(this.surnameBox);
            this.groupBox.Controls.Add(this.loginBox);
            this.groupBox.Controls.Add(this.nameBox);
            this.groupBox.Controls.Add(this.addressBox);
            this.groupBox.Controls.Add(this.emailBox);
            this.groupBox.Location = new System.Drawing.Point(12, 365);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(926, 102);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addButton.Location = new System.Drawing.Point(792, 62);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(128, 29);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Salmon;
            this.exitButton.Location = new System.Drawing.Point(6, 62);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 29);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Назад";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 476);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.clientsTable);
            this.MinimumSize = new System.Drawing.Size(966, 523);
            this.Name = "ClientForm";
            this.Text = "Клиенты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResizeEnd += new System.EventHandler(this.ClientForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsTable;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addButton;
    }
}
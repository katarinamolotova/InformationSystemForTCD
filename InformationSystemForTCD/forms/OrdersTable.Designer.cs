
namespace InformationSystemForTCD.forms
{
    partial class OrdersTable
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
            this.orderTable = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // orderTable
            // 
            this.orderTable.AllowUserToAddRows = false;
            this.orderTable.AllowUserToDeleteRows = false;
            this.orderTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTable.Location = new System.Drawing.Point(12, 12);
            this.orderTable.Name = "orderTable";
            this.orderTable.ReadOnly = true;
            this.orderTable.RowHeadersWidth = 51;
            this.orderTable.RowTemplate.Height = 29;
            this.orderTable.Size = new System.Drawing.Size(776, 348);
            this.orderTable.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Salmon;
            this.exitButton.Location = new System.Drawing.Point(12, 369);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 29);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Назад";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // OrdersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.orderTable);
            this.Name = "OrdersTable";
            this.Text = "Мои заказы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersTable_FormClosed);
            this.Load += new System.EventHandler(this.OrdersTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderTable;
        private System.Windows.Forms.Button exitButton;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InformationSystemForTCD.forms
{
    public partial class ClientForm : Form
    {
        DB db = new DB();
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            //  изменение размера таблицы вместе с изменением размера окна
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from client", db.GetConnection());
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "client");
            clientsTable.DataSource = dataSet.Tables["client"];
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ClientForm_ResizeEnd(object sender, EventArgs e)
        {
            clientsTable.Height = this.Height - 175;
            clientsTable.Width = this.Width - 42;
            groupBox.Location = new Point(this.Width / 2 - groupBox.Width / 2, this.Height - 158);
        }
    }
}

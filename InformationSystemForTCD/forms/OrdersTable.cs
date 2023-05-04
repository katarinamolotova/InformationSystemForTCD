using InformationSystemForTCD.models;
using InformationSystemForTCD.repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystemForTCD.forms
{
    public partial class OrdersTable : Form
    {
        Person person;
        RepositoryOrderImpl repository = new RepositoryOrderImpl();

        public OrdersTable(Person person)
        {
            this.person = person;
            InitializeComponent();
        }

        private void OrdersTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form form = new Profile(person);
            this.Hide();
            form.Show();
        }

        private void OrdersTable_Load(object sender, EventArgs e)
        {
            //orderTable.DataSource = repository.DoQuerySelect("select * from client"); //  заджойнить, чтобы отобразились имена
        }

        //  resize screen
    }
}

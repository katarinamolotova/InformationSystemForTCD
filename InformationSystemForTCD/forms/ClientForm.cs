using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InformationSystemForTCD.models;
using InformationSystemForTCD.repositories;
using MySql.Data.MySqlClient;

namespace InformationSystemForTCD.forms
{
    public partial class ClientForm : Form
    {
        RepositoryClientImpl repository = new RepositoryClientImpl();
        private Person person;

        public ClientForm(Person person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form form = new Profile(person);
            this.Hide();
            form.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Name = nameBox.Text;
            client.Surname = surnameBox.Text;
            client.Login = loginBox.Text;
            client.Number = numberBox.Text;
            client.Password = passwordBox.Text;
            client.Address = addressBox.Text;
            client.Email = emailBox.Text;
            repository.Save(client);
            UpdateTable();
        }

        private void UpdateTable()
        {
            clientsTable.DataSource = repository.DoQuerySelect("select * from client");
        }
    }
}

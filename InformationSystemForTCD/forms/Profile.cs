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
    public partial class Profile : Form
    {
        RepositoryEmployeeImpl repositoryEmployee = new RepositoryEmployeeImpl();
        RepositoryClientImpl repositoryClient = new RepositoryClientImpl();
        private Person person;
        public Profile(Person person)
        {
            InitializeComponent();
            ProfileImage.Image = Image.FromFile(".\\..\\..\\..\\resources\\images\\profile.png");
            this.person = person;
            ChangeVisible();
            ShowInformations();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            OpenNewWIndow(new Authorization());
        }

        private void OpenNewWIndow(Form form)
        {
            this.Hide();
            form.Show();
        }

        private void ChangeVisible()
        {
            if (person is Client)
            {
                ArchiveButton.Visible = false;
                ClientsButton.Visible = false;
                ServicesButton.Visible = false;
            }
            else
            {
                SurnameBox.Visible = false;
                EmailBox.Visible = false;
                NumberBox.Visible = false;
                AddressBox.Visible = false;
            }
        }

        private void ShowInformations()
        {
            LoginBox.Text = person.Login;
            NameBox.Text = person.Name;
            PasswordBox.Text = person.Password;
            if (person is Client client)
            {
                SurnameBox.Text = client.Surname;
                AddressBox.Text = client.Address;
                EmailBox.Text = client.Email;
                NumberBox.Text = client.Number;
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
                PasswordBox.PasswordChar = (char)0;
            else
                PasswordBox.PasswordChar = '•';
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool isChanged = (NameBox.Text != person.Name || LoginBox.Text != person.Login || PasswordBox.Text != person.Password);
            if (isChanged)
            {
                try
                {
                    person.Name = NameBox.Text;
                    person.Login = LoginBox.Text;
                    person.Password = PasswordBox.Text;
                    if (person is Client)
                    {
                        Client client = person as Client;
                        client.Address = AddressBox.Text;
                        client.Email = EmailBox.Text;
                        client.Surname = SurnameBox.Text;
                        client.Number = NumberBox.Text;
                        repositoryClient.Update(client);
                    } 
                    else
                    {
                        repositoryEmployee.Update(person as Employee);
                    }
                    MessageBox.Show("Данные успешно изменены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Изменять нечего", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OpenNewWIndow(new OrdersTable());
        }

        private void ArchiveButton_Click(object sender, EventArgs e)
        {
            //  как-то пометить, что это архив
            OpenNewWIndow(new OrdersTable());
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            OpenNewWIndow(new ClientForm(person));
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            OpenNewWIndow(new ServiceForm());
        }
    }
}

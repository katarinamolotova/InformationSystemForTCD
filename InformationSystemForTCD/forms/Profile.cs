using InformationSystemForTCD.models;
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
            if (person is Employee)
            {
                SurnameBox.Visible = false;
                EmailBox.Visible = false;
                NumberBox.Visible = false;
                AddressBox.Visible = false;
            }
            else
            {
                ArchiveButton.Visible = false;
                ClientsButton.Visible = false;
                ServicesButton.Visible = false;
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

        }
    }
}

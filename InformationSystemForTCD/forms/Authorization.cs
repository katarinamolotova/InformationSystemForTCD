using InformationSystemForTCD.forms;
using InformationSystemForTCD.models;
using InformationSystemForTCD.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InformationSystemForTCD
{
    public partial class Authorization : Form
    {
        RepositoryEmployeeImpl repositoryEmployee = new RepositoryEmployeeImpl();

        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String login = LoginBox.Text;
            String pass = PasswordBox.Text;

            //  enter as client
            List<Employee> employees = repositoryEmployee.GetAll()
                .Where(employee => employee.Login == login && employee.Password == pass)
                .ToList();

            //  передать объект сотрудника или клиента
            if (employees.Count > 0)
                OpenNewWIndow(employees[0]);
            else
                MessageBox.Show("Нет пользователя с такими данными! Убедитесь, что вы правильно ввели логин и пароль.", "Внимание!");
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
                PasswordBox.PasswordChar = (char)0;
            else
                PasswordBox.PasswordChar = '•';
        }

        private void OpenNewWIndow(Person person)
        {
            this.Hide();
            Profile profile = new Profile(person);
            profile.Show();
        }
    }
}

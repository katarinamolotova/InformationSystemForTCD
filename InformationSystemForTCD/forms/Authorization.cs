using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystemForTCD
{
    public partial class Authorization : Form
    {
        DB db = new DB();

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
            String query = $"select * from employee where login='{login}' and password='{pass}';";
            
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Login");
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
    }
}

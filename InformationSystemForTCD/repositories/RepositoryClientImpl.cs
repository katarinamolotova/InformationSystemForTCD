using InformationSystemForTCD.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemForTCD.repositories
{
    class RepositoryClientImpl : RepositoryPersonImpl
    {
        protected override string tableName { get; } = "client";

        public List<Client> GetAll()
        {
            return GetCLients($"select * from {tableName}");
        }

        public override Client GetById(int id)
        {
            return GetCLients($"select * from {tableName} where id = {id}").First();
        }

        private List<Client> GetCLients(String query)
        {
            DataTable result = DoQuerySelect(query);
            List<Client> clients = new List<Client>();

            for (int i = 0; i < (int)result.Rows.Count; i++)
            {
                Client client = new Client();
                client.Id = (int)result.Rows[i][0];
                client.Surname = result.Rows[i][1].ToString();
                client.Name = result.Rows[i][2].ToString();
                client.Number = result.Rows[i][3].ToString();
                client.Email = result.Rows[i][4].ToString();
                client.Address = result.Rows[i][5].ToString();
                client.Login = result.Rows[i][6].ToString();
                client.Password = result.Rows[i][7].ToString();
                clients.Add(client);
            }

            return clients;
        }

        public void Save(Client model)
        {
            String query = $"insert into {tableName} (surname, name, number, email, address, login, password) " +
                $"values ('{model.Surname}', '{model.Name}', '{model.Number}', " +
                $"'{model.Email}', '{model.Address}', '{model.Login}', '{model.Password}')";
            DoQueryInsertAndDelete(query);
        }

        public void Update(Client model)
        {
            db.OpenConnection();
            String query = $"update {tableName} set name = @name, surname = @surname, " +
                $"number = @number, email = @email, address = @address, login = @login, " +
                $"password = @password where id = @id";
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = model.Name;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = model.Login;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = model.Surname;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = model.Address;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = model.Email;
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = model.Number;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = model.Password;
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = model.Id;

            command.ExecuteNonQuery();
            db.CloseConnection();
        }
    }
}

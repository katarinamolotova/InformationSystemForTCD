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
    class RepositoryPersonImpl : IRepository<models.Person>
    {
        protected DB db = new DB();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        protected virtual string tableName { get; } = "";

        public void Delete(Person model)
        {
            String query = $"delete from {tableName} where id = {model.Id}";
            DoQueryInsertAndDelete(query);
        }

        public List<Person> GetAll()
        {
            return GetPerson($"select * from {tableName}");
        }

        public virtual Person GetById(int id)
        {
            List<Person> people = GetPerson($"select * from {tableName} where id = {id}");
            return people.First();
        }

        private List<Person> GetPerson(String query)
        {
            DataTable result = DoQuerySelect(query);
            List<Person> people = new List<Person>();

            for (int i = 0; i < (int)result.Rows.Count; i++)
            {
                Person person = new Person();
                person.Id = (int)result.Rows[i][0];
                person.Name = result.Rows[i][1].ToString();
                person.Login = result.Rows[i][2].ToString();
                person.Password = result.Rows[i][3].ToString();
                people.Add(person);
            }

            return people;
        }

        public void Save(Person model)
        {
            String query = $"insert into {tableName} (name, login, password)" +
                $" values ('{model.Name}', '{model.Login}', '{model.Password}')";
            DoQueryInsertAndDelete(query);
        }

        public void Update(Person model)
        {
            db.OpenConnection();
            String query = $"update {tableName} set name = @name, " +
                $"login = @login, password = @password where id = @id";
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = model.Name;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = model.Login;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = model.Password;
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = model.Id;

            command.ExecuteNonQuery();
            db.CloseConnection();
        }

        public void DoQueryInsertAndDelete(String query)
        {
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            command.ExecuteNonQuery();
            db.CloseConnection();
        }

        public DataTable DoQuerySelect(String query)
        {
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}

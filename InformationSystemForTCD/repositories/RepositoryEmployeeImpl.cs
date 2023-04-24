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
    class RepositoryEmployeeImpl : IRepository<models.Employee>
    {
        DB db = new DB();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        String tableName = "employee";

        public void Delete(Employee model)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            DataTable result = DoQuerySelect("select * from employee");
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < (int)result.Rows.Count; i++)
            {
                Employee employee = new Employee();
                employee.Id = (int)result.Rows[i][0];
                employee.Name = result.Rows[i][1].ToString();
                employee.Login = result.Rows[i][2].ToString();
                employee.Password = result.Rows[i][3].ToString();
                employees.Add(employee);
            }

            return employees;
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Employee model)
        {
            throw new NotImplementedException();
        }

        //  не работает
        public void Update(Employee model)
        {
            /*
             * DataSet dataSet = new DataSet();
            dataSet.Tables[tableName].Rows[model.Id]["name"] = model.Name;
            dataSet.Tables[tableName].Rows[model.Id]["login"] = model.Login;
            dataSet.Tables[tableName].Rows[model.Id]["password"] = model.Password;
             */
            db.OpenConnection();
            String query = $"update employee " +
                $"set name = @name, " +
                $"login = @login, " +
                $"password = @password " +
                $"where id = @id";
            MySqlCommand command = new MySqlCommand();
            command.Connection = db.GetConnection();
            command.CommandText = query;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = model.Name;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = model.Login;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = model.Password;
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = model.Id;
            command.ExecuteNonQuery();
            db.CloseConnection();
            //adapter.UpdateCommand = command;

        }

        private DataTable DoQuerySelect(String query)
        {
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}

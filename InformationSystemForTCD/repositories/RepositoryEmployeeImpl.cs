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

        public void Delete(Employee model)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            DataTable result = DoQuery("select * from employee");
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

        public void Update(Employee model)
        {
            throw new NotImplementedException();
        }

        private DataTable DoQuery(String query)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}

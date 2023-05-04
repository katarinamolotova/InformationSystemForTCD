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
    class RepositoryEmployeeImpl : RepositoryPersonImpl
    {
        protected override String tableName { get; } = "employee";
    }
}

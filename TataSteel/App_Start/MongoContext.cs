using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using System.Configuration;

namespace TataSteel.Models
{
    public class EmployeeDB
    {
        public String connectionString = "mongodb://localhost";
        public String DataBaseName = "EmployeeDB";
        //====================================================

        public MongoDatabase Database;

        public EmployeeDB()
        {
            var client = new MongoClient(connectionString);
            MongoServer mongoServer = client.GetServer();
            var server = mongoServer;

            Database = server.GetDatabase(DataBaseName);
        }

        public MongoCollection<EmployeeModel> employees
        {
            get
            {
                var employees = Database.GetCollection<EmployeeModel>("Employees");

                return employees;
            }
        }
    }
}

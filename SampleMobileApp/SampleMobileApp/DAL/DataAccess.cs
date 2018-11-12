using Plugin.NetStandardStorage.Abstractions.Interfaces;
using Plugin.NetStandardStorage.Implementations;
using SampleMobileApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SampleMobileApp.DAL
{
    public class DataAccess
    {
        private SQLiteConnection database;
        public DataAccess()
        {
            database = GetConnection();
            database.CreateTable<Employee>();
        }

        private SQLiteConnection GetConnection()
        {
            var sqlliteFileName = "MyDb.db3";
            IFolder folder = new FileSystem().LocalStorage;
            string path = Path.Combine(folder.FullPath, sqlliteFileName);
            return new SQLiteConnection(path);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            string strSql = @"select * from Employee order by EmpName";
            return database.Query<Employee>(strSql);
        }

        public int InsertEmployee(Employee employee)
        {
            try
            {
                return database.Insert(employee);
            }
            catch (Exception ex)
            { 
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public int DeleteEmployee(Employee employee)
        {
            try
            {
                return database.Delete(employee);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}

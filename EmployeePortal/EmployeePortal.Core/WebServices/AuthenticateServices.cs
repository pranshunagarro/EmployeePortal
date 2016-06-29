using EmployeePortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Core.WebServices
{
    public static class AuthenticateServices
    {
        public static async Task<Employee> Authentication (string username, string password)
        {
            await WebServiceSimulator();
            Employee retVal = null;
            if (username == "admin" && password == "admin")
            {
                retVal = new Employee() { Id = 1, EmployeeCode = 1, FirstName = "Admin", LastName = "" };
            }

            else
            {
                retVal = new Employee() { Id = 2, EmployeeCode = 2, FirstName = "Nagarro", LastName = "User" };
            }
            return retVal;
        }

        private static async Task WebServiceSimulator()
        {
           await Task.Run(() =>
           {
               Task.Delay(10000);
           });
        }
    }
}

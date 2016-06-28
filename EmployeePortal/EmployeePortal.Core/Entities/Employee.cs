using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}

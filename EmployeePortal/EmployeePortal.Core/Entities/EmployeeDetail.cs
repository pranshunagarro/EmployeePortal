using EmployeePortal.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Core.Entities
{
    public class EmployeeDetail : Employee
    {
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public List<Qualification> ListOfQualifications { get; set; }
        public DateTime DOB { get; set; }
        public Login Login { get; set; }
        public string Designation { get; set; }
        public Gender Gender { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public MaritalStatus MaritalStatus { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Core.Entities
{
    public class Qualification
    {
        public int Id { get; set; }
        public string Degree { get; set; }
        public float Percentage { get; set; }
        public int YearOfPassing {get;set;}
        public string Institution { get; set; }
    }
}

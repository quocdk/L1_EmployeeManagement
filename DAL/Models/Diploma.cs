using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Diploma
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Guid CityId { get; set; } 
        public Guid EmployeeId { get; set; } 

        public virtual Employee? Employee { get; set; }
        public virtual City? City { get; set; }
    }
}

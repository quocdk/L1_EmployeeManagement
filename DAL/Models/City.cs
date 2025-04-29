using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<District>? Districts { get; set; }
        public virtual ICollection<Diploma>? Diplomas { get; set; }
        //public virtual ICollection<Employee>? Employees { get; set; }
    }
}

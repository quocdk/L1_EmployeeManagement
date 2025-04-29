using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class District
    {
        public Guid Id { get; set; }
        public Guid CityId { get; set; }
        public string Name { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Commune>? Communes { get; set; }
        //public virtual ICollection<Employee>? Employees { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Commune
    {
        public Guid Id { get; set; }
        public Guid DistrictId { get; set; }
        public Guid CityId { get; set; }
        public string Name { get; set; }

        public virtual District? District { get; set; }  
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}

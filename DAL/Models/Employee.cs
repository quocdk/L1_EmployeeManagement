using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public Guid EthnicId { get; set; }
        public Guid OccupationId { get; set; }
        public string? CitizenIdentityCard { get; set; }
        public string? PhoneNumber { get; set; }
        public Guid CityId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? CommuneId { get; set; }
        public string? SpecificAddress { get; set; }
        public int DiplomaNumber { get; set; }

        public virtual Ethnic? Ethnic { get; set;}
        public virtual Occupation? Occupation { get; set;}
        //public virtual City? City { get; set;}
        //public virtual District? District { get; set;}
        public virtual Commune? Commune { get; set;}
        public virtual ICollection<Diploma>? Diplomas { get; set; }
    }
}

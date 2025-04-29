using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services.Interfaces
{
    public interface IOccupationService
    {
        Occupation GetById(Guid idOccupation);
        List<Occupation> GetList();
        bool Add(Occupation request);
        bool Update(Occupation request);
        bool Delete(Guid idOccupation);
    }
}

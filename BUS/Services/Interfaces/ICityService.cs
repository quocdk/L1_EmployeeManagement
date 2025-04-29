using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services.Interfaces
{
    public interface ICityService
    {
        City GetById(Guid idCity);
        List<City> GetList();
        bool Add(City request);
        bool Update(City request);
        bool Delete(Guid idCity);
    }
}

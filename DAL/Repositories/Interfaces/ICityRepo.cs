using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface ICityRepo
    {
        City GetById(Guid idCity);
        City GetByName(string nameCity);
        List<City> GetList();
        bool Add(City request);
        bool Update(City request);
        bool Delete(Guid idCity);
    }
}

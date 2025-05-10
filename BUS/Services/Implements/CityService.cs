using BUS.Services.Interfaces;
using DAL.Models;
using DAL.Repositories.Implements;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services.Implements
{
    public class CityService : ICityService
    {
        ICityRepo _cityRepo; 

        public CityService()
        {
            _cityRepo = new CityRepo(); 
        }
        public bool Add(City request)
        {
            return _cityRepo.Add(request);
        }

        public bool Delete(Guid idCity)
        {
            return _cityRepo.Delete(idCity);
        }

        public City GetById(Guid idCity)
        {
            var obj = _cityRepo.GetById(idCity);

            return obj;
        }
        public City GetByName(string nameCity)
        {
            var obj = _cityRepo.GetByName(nameCity);

            return obj;
        }

        public List<City> GetList()
        {
            var listObj = _cityRepo.GetList();

            return listObj;
        }

        public bool Update(City request)
        {
            return _cityRepo.Update(request);
        }
    }
}

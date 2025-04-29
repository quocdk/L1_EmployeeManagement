using DAL.ApplicationDbContext;
using DAL.Models;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Implements
{
    public class CityRepo : ICityRepo
    {
        AppDbContext _dbContext;
        public CityRepo()
        {
            _dbContext = new();
        }
        public bool Add(City request)
        {
            try
            {
                _dbContext.Cities.Add(request);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid idCity)
        {
            try
            {
                var existedObj = _dbContext.Cities.FirstOrDefault(o => o.Id == idCity);
                if (existedObj == null)
                {
                    return false;
                }
                else
                {
                    _dbContext.Remove(existedObj);
                    _dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public City GetById(Guid idCity)
        {
            var obj = _dbContext.Cities.FirstOrDefault(o => o.Id == idCity);
            return obj;
        }

        public List<City> GetList()
        {
            var listObj = _dbContext.Cities.ToList();
            return listObj;
        }

        public bool Update(City request)
        {
            try
            {
                var existedObj = _dbContext.Cities.FirstOrDefault(o => o.Id == request.Id);
                if (existedObj == null)
                {
                    return false;
                }
                else
                {
                    existedObj.Name = request.Name;                  
                    _dbContext.Update(existedObj);
                    _dbContext.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

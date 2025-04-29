using DAL.ApplicationDbContext;
using DAL.Models;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Implements
{
    public class DistrictRepo : IDistrictRepo
    {
        AppDbContext _dbContext;
        public DistrictRepo()
        {
            _dbContext = new();
        }
        public bool Add(District request)
        {
            try
            {
                _dbContext.Districts.Add(request);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid idDistrict)
        {
            try
            {
                var existedObj = _dbContext.Districts.FirstOrDefault(o => o.Id == idDistrict);
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

        public District GetById(Guid idDistrict)
        {
            var obj = _dbContext.Districts.FirstOrDefault(o => o.Id == idDistrict);
            return obj;
        }

        public List<District> GetList()
        {
            var listObj = _dbContext.Districts.ToList();
            return listObj;
        }

        public bool Update(District request)
        {
            try
            {
                var existedObj = _dbContext.Districts.FirstOrDefault(o => o.Id == request.Id);
                if (existedObj == null)
                {
                    return false;
                }
                else
                {
                    existedObj.Name = request.Name;
                    existedObj.CityId = request.CityId;
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

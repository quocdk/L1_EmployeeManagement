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
    public class OccupationRepo : IOccupationRepo
    {
        AppDbContext _dbContext;
        public OccupationRepo()
        {
            _dbContext = new();
        }
        public bool Add(Occupation request)
        {
            try
            {
                _dbContext.Occupations.Add(request);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid idOccupation)
        {
            try
            {
                var existedObj = _dbContext.Occupations.FirstOrDefault(o => o.Id == idOccupation);
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

        public Occupation GetById(Guid idOccupation)
        {
            var obj = _dbContext.Occupations.FirstOrDefault(o => o.Id == idOccupation);
            return obj;
        }

        public List<Occupation> GetList()
        {
            var listObj = _dbContext.Occupations.ToList();
            return listObj;
        }

        public bool Update(Occupation request)
        {
            try
            {
                var existedObj = _dbContext.Occupations.FirstOrDefault(o => o.Id == request.Id);
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

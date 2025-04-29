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
    public class CommuneRepo : ICommuneRepo
    {
        AppDbContext _dbContext;
        public CommuneRepo()
        {
            _dbContext = new();
        }
        public bool Add(Commune request)
        {
            try
            {
                _dbContext.Communes.Add(request);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid idCommune)
        {
            try
            {
                var existedObj = _dbContext.Communes.FirstOrDefault(o => o.Id == idCommune);
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

        public Commune GetById(Guid idCommune)
        {
            var obj = _dbContext.Communes.FirstOrDefault(o => o.Id == idCommune);
            return obj;
        }

        public List<Commune> GetList()
        {
            var listObj = _dbContext.Communes.ToList();
            return listObj;
        }

        public bool Update(Commune request)
        {
            try
            {
                var existedObj = _dbContext.Communes.FirstOrDefault(o => o.Id == request.Id);
                if (existedObj == null)
                {
                    return false;
                }
                else
                {
                    existedObj.Name = request.Name;
                    existedObj.DistrictId = request.DistrictId;
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

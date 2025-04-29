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
    public class EthnicRepo : IEthnicRepo
    {
        AppDbContext _dbContext;
        public EthnicRepo()
        {
            _dbContext = new();
        }
        public bool Add(Ethnic request)
        {
            try
            {
                _dbContext.Ethnics.Add(request);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid idEthnic)
        {
            try
            {
                var existedObj = _dbContext.Ethnics.FirstOrDefault(o => o.Id == idEthnic);
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

        public Ethnic GetById(Guid idEthnic)
        {
            var obj = _dbContext.Ethnics.FirstOrDefault(o => o.Id == idEthnic);
            return obj;
        }

        public List<Ethnic> GetList()
        {
            var listObj = _dbContext.Ethnics.ToList();
            return listObj;
        }

        public bool Update(Ethnic request)
        {
            try
            {
                var existedObj = _dbContext.Ethnics.FirstOrDefault(o => o.Id == request.Id);
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

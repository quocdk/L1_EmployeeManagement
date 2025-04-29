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
    public class DiplomaRepo : IDiplomaRepo
    {
        AppDbContext _dbContext;
        public DiplomaRepo()
        {
            _dbContext = new();
        }
        public bool Add(Diploma request)
        {
            try
            {
                _dbContext.Diplomas.Add(request);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid idDiploma)
        {
            try
            {
                var existedObj = _dbContext.Diplomas.FirstOrDefault(o => o.Id == idDiploma);
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

        public Diploma GetById(Guid idDiploma)
        {
            var obj = _dbContext.Diplomas.FirstOrDefault(o => o.Id == idDiploma);
            return obj;
        }

        public List<Diploma> GetList()
        {
            var listObj = _dbContext.Diplomas.ToList();
            return listObj;
        }

        public bool Update(Diploma request)
        {
            try
            {
                var existedObj = _dbContext.Diplomas.FirstOrDefault(o => o.Id == request.Id);
                if (existedObj == null)
                {
                    return false;
                }
                else
                {
                    existedObj.Name = request.Name;
                    existedObj.IssueDate = request.IssueDate;
                    existedObj.ExpiryDate = request.ExpiryDate;
                    existedObj.CityId = request.CityId;
                    existedObj.EmployeeId = request.EmployeeId;
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

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
    public class EmployeeRepo : IEmployeeRepo
    {
        AppDbContext _dbContext;
        public EmployeeRepo()
        {
            _dbContext = new();
        }
        public bool Add(Employee request)
        {
            try
            {
                _dbContext.Employees.Add(request);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid idEmployee)
        {
            try
            {
                var existedObj = _dbContext.Employees.FirstOrDefault(o => o.Id == idEmployee);
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

        public Employee GetById(Guid idEmployee)
        {
            var obj = _dbContext.Employees.FirstOrDefault(o => o.Id == idEmployee);
            return obj;
        }

        public List<Employee> GetList()
        {
            var listObj = _dbContext.Employees.ToList();
            return listObj;
        }

        public bool Update(Employee request)
        {
            try
            {
                var existedObj = _dbContext.Employees.FirstOrDefault(o => o.Id == request.Id);
                if (existedObj == null)
                {
                    return false;
                }
                else
                {
                    existedObj.FullName = request.FullName;
                    existedObj.DateOfBirth = request.DateOfBirth;
                    existedObj.Age = request.Age;
                    existedObj.EthnicId = request.EthnicId;
                    existedObj.OccupationId = request.OccupationId;
                    existedObj.CitizenIdentityCard = request.CitizenIdentityCard;
                    existedObj.PhoneNumber = request.PhoneNumber;
                    existedObj.CityId = request.CityId;
                    existedObj.DistrictId = request.DistrictId;
                    existedObj.CommuneId = request.CommuneId;
                    existedObj.SpecificAddress = request.SpecificAddress;
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

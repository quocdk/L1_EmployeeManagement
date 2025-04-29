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
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepo _employeeRepo; 

        public EmployeeService()
        {
            _employeeRepo = new EmployeeRepo(); 
        }
        public bool Add(Employee request)
        {
            return _employeeRepo.Add(request);
        }

        public bool Delete(Guid idEmployee)
        {
            return _employeeRepo.Delete(idEmployee);
        }

        public Employee GetById(Guid idEmployee)
        {
            var obj = _employeeRepo.GetById(idEmployee);

            return obj;
        }

        public List<Employee> GetList()
        {
            var listObj = _employeeRepo.GetList();

            return listObj;
        }

        public bool Update(Employee request)
        {
            return _employeeRepo.Update(request);
        }
    }
}

using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IEmployeeRepo
    {
        Employee GetById(Guid idEmployee);
        List<Employee> GetList();
        bool Add(Employee request);
        bool Update(Employee request);
        bool Delete(Guid idEmployee);
    }
}

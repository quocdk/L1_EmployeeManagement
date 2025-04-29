using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IDiplomaRepo
    {
        Diploma GetById(Guid idDiploma);
        List<Diploma> GetList();
        bool Add(Diploma request);
        bool Update(Diploma request);
        bool Delete(Guid idDiploma);
    }
}
